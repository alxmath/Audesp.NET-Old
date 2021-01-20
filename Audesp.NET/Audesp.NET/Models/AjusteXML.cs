using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using static Audesp.NET.Models.Empenho;

namespace Audesp.NET.Models
{
    public class AjusteXML : ModuloXML
    {

        private readonly Empenho _empenho;
        public static string XmlDirectory { get; } = @"schemas\xml";

        public AjusteXML(Empenho empenho)
        {
            _empenho = empenho;
        }

        public override void GerarXML()
        {

            /* Cria o diretório xml se o mesmo não existe */
            if (!Directory.Exists(XmlDirectory))
            {
                Directory.CreateDirectory(XmlDirectory);
                Console.WriteLine("Diretório xml criado.");
            }

            //string filename = @"schemas\xml\ajuste.xml";
            string filename = $@"{XmlDirectory}\ajuste.xml";
            string xsdLocation = ConfigurationManager.AppSettings["XSDLocation"];

            XmlTextWriter xmlWriter = new XmlTextWriter(filename, Encoding.UTF8)
            {
                Formatting = Formatting.Indented
            };

            xmlWriter.WriteStartDocument();

            xmlWriter.WriteComment("Root");

            #region Root Definition and Namespaces

            /** Abre a tag principal Ajuste */
            xmlWriter.WriteStartElement("ns3:Ajuste");
            xmlWriter.WriteAttributeString("xmlns:ns1", "http://www.tce.sp.gov.br/audesp/xml/tagcomum");
            xmlWriter.WriteAttributeString("xmlns:ns2", "http://www.tce.sp.gov.br/audesp/xml/generico");
            xmlWriter.WriteAttributeString("xmlns:ns3", "http://www.tce.sp.gov.br/audesp/xml/ajuste");
            xmlWriter.WriteAttributeString("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            xmlWriter.WriteAttributeString("xsi:schemaLocation", $"http://www.tce.sp.gov.br/audesp/xml/ajuste {xsdLocation}");

            #region Descritor

            xmlWriter.WriteComment("Descritor");
            xmlWriter.WriteStartElement("ns3:Descritor"); // inicio da tag Descritor
            xmlWriter.WriteElementString("ns2:AnoExercicio", DateTime.Today.Year.ToString());
            xmlWriter.WriteElementString("ns2:TipoDocumento", "AJUSTE");
            xmlWriter.WriteElementString("ns2:Entidade", "10122");
            xmlWriter.WriteElementString("ns2:Municipio", "6179");
            xmlWriter.WriteElementString("ns2:DataCriacaoXML", DateTime.Today.ToString("yyyy-MM-dd"));
            xmlWriter.WriteEndElement(); // fim da tag Descritor

            #endregion

            #region Tag ArrayAjuste Definition

            xmlWriter.WriteComment("ArrayAJuste");
            xmlWriter.WriteStartElement("ns3:ArrayAjuste"); // incio da tag ArrayAjuste

            xmlWriter.WriteElementString("ns3:LicitacaoProprioOrgaoSim", "S");
            xmlWriter.WriteElementString("ns3:CodigoLicitacao", _empenho.CodigoAudespLicitacao);

            if (_empenho.Modalidade == Empenho.TipoAjuste.Empenho) // Se nota de empenho doc similar
            {
                xmlWriter.WriteComment("NotaEmpenhoDocSimilar");
                xmlWriter.WriteStartElement("ns3:NotaEmpenhoDocSimilar"); // inicio da tag NotaEmpenhoDocSimilar
                xmlWriter.WriteElementString("ns3:CodigoAjuste", _empenho.CodigoAjuste);

                /***
                 * TODO: GERAR A LISTA DE ITENS NO XML
                 */
                xmlWriter.WriteElementString("ns3:NumeroDosLotes", "14");

                SetDocumento(_empenho.TipoDocumentoCredor, xmlWriter);

                /***
                 * TODO: BUSCAR NO NOME DO CREDOR NA BASE DE DADOS.
                 */
                xmlWriter.WriteElementString("ns3:NomeRazaoSocial", "ERAGON COMERCIO E SERVIÇOS DE INFORMATICA E PAPELA");

                WriteNotaEmpenhoTag(xmlWriter);

                WriteTermoCienciaContratantesTag(xmlWriter);

                WriteTermoCienciaContratadosTag(xmlWriter);

                xmlWriter.WriteEndElement(); // fim da tag NotaEmpenhoDocSimilar
            }
            else // Se contrato
            {
                xmlWriter.WriteComment("Contrato");
                xmlWriter.WriteStartElement("ns3:Contrato"); // inicio da tag Contrato
                xmlWriter.WriteElementString("ns3:CodigoAjuste", _empenho.CodigoAjuste);

                /***
                 * TODO: GERAR A LISTA DE ITENS NO XML
                 */
                xmlWriter.WriteElementString("ns3:NumeroLotes", "1");


                //xmlWriter.WriteElementString("ns3:NumContrato", _empenho.NumeroContratoAdministrativo);
                //xmlWriter.WriteElementString("ns3:AnoContrato", _empenho.AnoContratoAdministrativo);
                //xmlWriter.WriteElementString("ns3:ValorContrato", _empenho.Valor.ToString(CultureInfo.InvariantCulture));
                //xmlWriter.WriteElementString("ns3:ObjetoContrato", _empenho.ObjetoContrato);
                //xmlWriter.WriteElementString("ns3:Quantidade", _empenho.QuantidadeContrato.ToString(CultureInfo.InvariantCulture));
                //xmlWriter.WriteElementString("ns3:UnidadeMedida", _empenho.UnidadeContrato);

                SetDocumento(_empenho.TipoDocumentoCredor, xmlWriter);

                /***
                * TODO: BUSCAR NO NOME DO CREDOR NA BASE DE DADOS.
                */
                xmlWriter.WriteElementString("ns3:NomeRazaoSocial", "DIAGNÓSTICOS SUL PRODUTOS HOSPITALARES LTDA");

                /* opcional */
                xmlWriter.WriteElementString("ns3:ClausulasFinanceira",
                    "Cláusula dos Preços: SÉTIMA; Cláusula dos Recursos Orçamentários: OITAVA; Cláusula dos Pagamentos: NONA.");

                #region Classificação Econômica

                xmlWriter.WriteComment("Classificação Econômica");
                xmlWriter.WriteStartElement("ns3:ClassificacaoEconomica"); // inicio tag ClassificacaoEconomica

                /*
                 * Opções TipoClassificacaoEconomica:
                 * 1: Receita
                 * 2: Despesa
                 */
                //xmlWriter.WriteElementString("ns1:TipoClassificacaoEconomica", "2");
                //xmlWriter.WriteElementString("ns1:CodigoClassificacaoEconomica", _empenho.CodigoClassificacaoEconomica);
                //xmlWriter.WriteEndElement(); // fim tag ClassificacaoEconomica

                #endregion

                WriteNotaEmpenhoTag(xmlWriter);

                #region Exigencia de Garantia

                //if (_empenho.IsExigidoGarantia)
                //{
                //    xmlWriter.WriteComment("Exigência de Garantia");
                //    xmlWriter.WriteStartElement("ns3:ExigenciaGarantiaSim"); // inicio tag ExigenciaGarantiaSim
                //    xmlWriter.WriteElementString("ns3:ValorGarantia", "600.000");
                //    xmlWriter.WriteElementString("ns3:ValorGarantiaPercentualContrato", "0.32");
                //    xmlWriter.WriteElementString("ns3:ClausulasGarantia", "Cláusula Genérica da Garatia");
                //    xmlWriter.WriteEndElement(); // fim tag ExigenciaGarantiaSim
                //}
                //else
                //{
                //    xmlWriter.WriteElementString("ns3:ExigenciaGarantiaNao", "N");
                //}

                //#endregion

                //#region Cláusula Penal

                //if (_empenho.HasClausulaPenal)
                //{
                //    xmlWriter.WriteElementString("ns3:ClausulasPenaisSim", "Cláusula das Sanções: DÉCIMA SEGUNDA");
                //}
                //else
                //{
                //    xmlWriter.WriteElementString("ns3:ClausulasPenaisNao", "N");
                //}

                //#endregion

                //#region Exigencia de Gestor

                //if (_empenho.IsExigidoGestor)
                //{
                //    xmlWriter.WriteComment("Exigência de Gestor");
                //    xmlWriter.WriteStartElement("ns3:GestorDoContratoSim"); // inicio tag GestorDoContratoSim
                //    xmlWriter.WriteElementString("ns3:GestorCPF", "13712040806");
                //    xmlWriter.WriteElementString("ns3:GestorCargo", "Diretor Técnico de Saúde I");
                //    xmlWriter.WriteEndElement(); // fim tag GestorDoContratoSim
                //}
                //else
                //{
                //    xmlWriter.WriteElementString("ns3:GestorDoContratoNao", "N");
                //}

                //#endregion

                //#region Vigência

                //if (_empenho.TipoVigencia == Vigencia.Data)
                //{
                //    xmlWriter.WriteComment("Vigência");
                //    xmlWriter.WriteStartElement("ns3:VigenciaPorData"); // inicio tag VigenciaPorData
                //    xmlWriter.WriteElementString("ns3:InicioVigenciaDt", "2020-12-10");
                //    xmlWriter.WriteElementString("ns3:FimVigenciaDt", "2021-02-10");
                //    xmlWriter.WriteEndElement(); // fim tag VigenciaPorData
                //}
                //else
                //{
                //    xmlWriter.WriteElementString("ns3:ValidadeMeses", "60");
                //}

                //#endregion

                //xmlWriter.WriteElementString("ns3:AssinaturaDt", "2020-01-15");

                //#region Publicação

                //if (_empenho.HasPublicacao)
                //{
                //    xmlWriter.WriteComment("Publicação");
                //    xmlWriter.WriteStartElement("ns3:PublicacaoExtratoContrato"); // inicio tag PublicacaoExtratoContrato

                //    /* VeiculoPublicacao opções: 
                //     * 1: DOU, 
                //     * 2: Jornal de grande circulação nacional
                //     * 3: Outros sites
                //     * 4: Jornal de grande circulação regional/municipal
                //     * 5: DOE
                //     * 6: Site da Administração Direta na Internet
                //     * 7: DOM
                //     * 8: Quadro ou mural de acesso público
                //     * 9: DJE (Diário da Justiça Eletrônico)
                //     */
                //    xmlWriter.WriteElementString("ns1:VeiculoPublicacao", "1");

                //    /* opcional */
                //    xmlWriter.WriteElementString("ns1:PublicacaoData", "2021-02-10");

                //    /* opcional */
                //    xmlWriter.WriteElementString("ns1:PublicacaoDescr", "Descrição da publicação");

                //    /*
                //     * PublicacaoOficial : S ou N
                //     */
                //    xmlWriter.WriteElementString("ns1:PublicacaoOficial", "S");
                //    xmlWriter.WriteEndElement(); // fim tag PublicacaoExtratoContrato
                //}
                //else
                //{
                //    xmlWriter.WriteElementString("ns3:PublicacaoExtratoContratoNao", "N");
                //}

                #endregion

                WriteTermoCienciaContratantesTag(xmlWriter);

                WriteTermoCienciaContratadosTag(xmlWriter);

                xmlWriter.WriteEndElement(); // fim da tag NotaEmpenhoDocSimilar
            }

            xmlWriter.WriteEndElement(); // fim da tag ArrayAjuste

            #endregion


            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Flush();
            xmlWriter.Close();

            #endregion

            Console.WriteLine("Documento escrito");

            ValidateXML($@"{XmlDirectory}\ajuste.xml");
            Console.ReadLine();
            //System.Threading.Thread.Sleep(1000);
        }

        private void SetDocumento(Empenho.TipoDocumento documento, XmlTextWriter xmlWriter)
        {
            switch (documento)
            {
                case Empenho.TipoDocumento.Cnpj:
                    xmlWriter.WriteElementString("ns3:CNPJ", _empenho.CredorDocumento);
                    break;
                case Empenho.TipoDocumento.Cpf:
                    xmlWriter.WriteElementString("ns3:CPF", _empenho.CredorDocumento);
                    break;
                case Empenho.TipoDocumento.OutroDoc:
                    xmlWriter.WriteElementString("ns3:OutroDoc", _empenho.CredorDocumento);
                    break;
                default:
                    break;
            }
        }

        private void WriteTermoCienciaContratadosTag(XmlTextWriter xmlWriter)
        {
            xmlWriter.WriteComment("Ciência Contratado");
            xmlWriter.WriteStartElement("ns3:TermoCienciaContratados"); // inicio tag TermoCienciaContratados
            xmlWriter.WriteElementString("ns1:CPF", "01558973818");
            xmlWriter.WriteElementString("ns1:Nome", "Márcia Florinda Gonçalves Pacheco");
            xmlWriter.WriteElementString("ns1:AssinouContrato", "S");
            xmlWriter.WriteEndElement(); // fim tag TermoCienciaContratados
        }

        private void WriteTermoCienciaContratantesTag(XmlTextWriter xmlWriter)
        {
            xmlWriter.WriteComment("Ciência Contratante");
            xmlWriter.WriteStartElement("ns3:TermoCienciaContratantes"); // inicio tag TermoCienciaContratantes
            xmlWriter.WriteElementString("ns1:CPF", "04758063877");
            xmlWriter.WriteElementString("ns1:Nome", "Lenilda de A. Lins R. dos Santos");
            xmlWriter.WriteElementString("ns1:EmailProfissional", "hra-diretoriageral@saude.sp.gov.br");
            xmlWriter.WriteElementString("ns1:EmailPessoal", "lenildars@hotmail.com");
            xmlWriter.WriteElementString("ns1:AssinouContrato", "S");
            xmlWriter.WriteEndElement(); // fim tag TermoCienciaContratantes
        }

        private void WriteNotaEmpenhoTag(XmlTextWriter xmlWriter)
        {
            xmlWriter.WriteComment("Nota de Empenho");
            xmlWriter.WriteStartElement("ns3:NotaEmpenho"); // inicio da tag NotaEmpenho
            xmlWriter.WriteElementString("ns1:NumNotaEmpenho", "2020NE00562");
            xmlWriter.WriteElementString("ns1:NotaEmpenhoDt", "2020-04-22");
            xmlWriter.WriteElementString("ns1:NotaEmpenhoValor", "320.00");

            /*
             * Opções fonte recursos:
             * 1: Tesouro
             * 2: Transferências e convênios estaduais-vinculados
             * 3: Recursos Próprios de Fundos Especiais de Despesa-Vinculados
             * 4: Recursos Próprios da Administração Indireta
             * 5: Transferências e Convênios Federais-Vinculados
             * 6: Outras Fontes de Recursos
             * 7: Operações de Crédito
             * 8: Emendas Parlamentares Individuais
             */
            xmlWriter.WriteElementString("ns1:FonteRecursos", "1");
            xmlWriter.WriteEndElement(); // fim da tag NotaEmpenho
        }

        /// <summary>
        /// Valida os arquivos XML's contra seus respectivos XSD's.
        /// </summary>
        /// <param name="filename">Caminho para o arquivo XML.</param>
        private void ValidateXML(string filename)
        {

            XmlReader xmlReader = null;

            try
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.ValidationType = ValidationType.Schema;
                settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessSchemaLocation;
                settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
                settings.ValidationEventHandler += new ValidationEventHandler(ValidationEventHandle);

                xmlReader = XmlReader.Create(filename, settings);

                while (xmlReader.Read())
                {

                }

                Console.WriteLine("XML validado.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
            finally
            {
                if (xmlReader != null)
                {
                    xmlReader.Close();
                }
            }

        }

        private void ValidationEventHandle(object sender, ValidationEventArgs args)
        {
            //Console.WriteLine("\r\n\tValidation Error: " + args.Message);
            throw new Exception("Validação do arquivo XML falhou: " + args.Message);
        }
    }
}
