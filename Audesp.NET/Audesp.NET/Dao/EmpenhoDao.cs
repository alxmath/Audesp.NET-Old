using Audesp.NET.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Audesp.NET.Dao
{
    public class EmpenhoDao : MyConnection
    {


        /// <summary>
        /// Busca notas de empenho por processo
        /// </summary>
        /// <throws>Exception</throws>
        /// <param name="processo">Número do processo a ser pesquisado.</param>
        /// <returns>Lista de empenhos para o dado processo.</returns>
        public List<Empenho> GetByProcesso(string processo)
        {
            string query = "SELECT * FROM empenhos WHERE numero_processo = @processo";
            List<Empenho> empenhos = new List<Empenho>();

            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();

                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@processo", processo);

                using var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var empenho = new Empenho()
                        {
                            NumeroEmpenho = reader["numero_empenho"].ToString(),
                            CodigoAjuste = reader["codigo_ajuste"].ToString(),
                            NaturezaDespesa = reader["natureza_despesa"].ToString(),
                            Modalidade = reader["modalidade"].ToString(),
                            Valor = Convert.ToDecimal(reader["valor"]),
                            Emissao = Convert.ToDateTime(reader["emissao"]),
                            CredorDocumento = reader["credor_documento"].ToString(),
                            FonteRecursos = reader["fonte_recursos"].ToString(),
                            NumeroLicitacao = reader["numero_licitacao"].ToString(),
                            Processo = reader["numero_processo"].ToString(),
                            QuantidadeContrato = Convert.ToDouble(reader["qtd_contrato"]),
                            UnidadeContrato = reader["und_contrato"].ToString(),
                            DataEstimadaEntrega = Convert.ToDateTime(reader["dt_estimada_entrega"]),
                            TipoLicitacao = reader["tipo_licitacao"].ToString(),
                            Pacote = reader["pacote"].ToString(),
                            Documento = reader["documento"].ToString(),
                            Situacao = reader["situacao"].ToString(),
                            ValorExecucoes = Convert.ToDecimal(reader["valor_execucoes"]),
                            ValorNfs = Convert.ToDecimal(reader["valor_nfs"]),
                            ValorPagamentos = Convert.ToDecimal(reader["valor_pagamentos"]),
                            ValorRecolhimentos = Convert.ToDecimal(reader["valor_recolhimentos"]),
                            ValorCancelamentos = Convert.ToDecimal(reader["valor_cancelamentos"]),
                            IsEncerrado = Convert.ToByte(reader["is_encerrado"]) == 1 ? true : false
                        };

                        empenhos.Add(empenho);
                    }
                }
                else
                {
                    throw new Exception("Não existem empenhos para este processo.");
                }
            }

            return empenhos;
        }
    }
}
