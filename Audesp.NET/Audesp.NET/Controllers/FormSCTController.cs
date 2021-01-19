using Audesp.NET.Dao;
using Audesp.NET.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Audesp.NET.Controllers
{
    public class FormSCTController
    {
        public List<Empenho> GetByProcesso(string processo)
        {
            var dao = new EmpenhoDao();

            try
            {
                var empenhos = dao.GetByProcesso(processo);
                return empenhos;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
