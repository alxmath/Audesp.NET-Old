using Audesp.NET.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Audesp.NET.Controllers
{
    public class FormAjusteController
    {
        public Licitacao ParseLicitacaoFromHtml()
        {
            HtmlAgilityPack.HtmlDocument doc;
            var webget = new HtmlWeb();
            var ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                doc = webget.Load(ofd.FileName);
                //doc.OptionEmptyCollection = true;
            }
            else
            {
                return null;
            }

            Licitacao licitacao = new Licitacao();

            HtmlNodeCollection lotes = doc.DocumentNode.SelectNodes("//td");
            licitacao.NumeroLicitacao = doc.DocumentNode.SelectSingleNode("//*[@id='id_Cabecalho_Processo']/div/div[1]/span").InnerText.Trim();

            licitacao.CodigoAudespLicitacao = doc.DocumentNode.SelectSingleNode("//div[@class='processo_status'][3]").InnerText.Trim();
            int indexOfColon = licitacao.CodigoAudespLicitacao.IndexOf(":");
            licitacao.CodigoAudespLicitacao = licitacao.CodigoAudespLicitacao.Substring(indexOfColon + 1).Trim();

            int contador = 1;
            for (int i = 0; i < lotes.Count - 1; i++)
            {
                if (lotes[i].InnerText.Length >= 4)
                {
                    if (lotes[i].InnerText.Substring(0,4) == "Item")
                    {
                        if (lotes[i].InnerText.IndexOf("-Grupo") != -1)
                        {

                        }
                        else
                        {
                            licitacao.Tipo = "N"; // normal

                            int indexOfSlash = lotes[i].InnerText.IndexOf("-");
                            indexOfColon = lotes[i].InnerText.IndexOf(":");

                            Lote lote = new Lote();
                            lote.LoteSiafisico = lotes[i].InnerText
                                .Substring(indexOfColon + 1, (indexOfSlash - 1) - (indexOfColon + 1)).Trim();

                            int indexOfQuantidade = lotes[i].InnerText.LastIndexOf("Quantidade");
                            string secaoQuantidadePreco = lotes[i].InnerText.Substring(indexOfQuantidade).Trim();

                            indexOfColon = secaoQuantidadePreco.IndexOf(":");
                            indexOfSlash = secaoQuantidadePreco.IndexOf("-");
                            int indexOfCifrao = secaoQuantidadePreco.IndexOf("R$");

                            lote.Sequencia = contador;
                            lote.Quantidade = Convert.ToDouble(secaoQuantidadePreco.Substring(indexOfColon + 1, (indexOfSlash - 1) - (indexOfColon + 1)).Trim());
                            lote.ValorNegociado = Convert.ToDecimal(secaoQuantidadePreco.Substring(indexOfCifrao + 2).Trim());

                            licitacao.Add(lote);
                            contador++;
                        }
                    }                                                                                            

                }
            }

 
            return licitacao;
        }
    }
}
