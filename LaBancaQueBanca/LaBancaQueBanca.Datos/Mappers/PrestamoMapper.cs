using Estudio.Entidades.Entidades;
using LaBancaQueBanca.Entidades.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaBancaQueBanca.Datos.Mappers
{
    public class PrestamoMapper
    {
        private Prestamo _prestamo;
        public PrestamoMapper()
        {
            this._prestamo = new Prestamo();
        }

        public List<Prestamo> TraerPrestamos()
        {
            string json = WebHelper.Get("/");
            List<Prestamo> resultado = MapList(json);
            return resultado;
        }

        private List<Prestamo> MapList(string json)
        {
            List<Prestamo> lista = JsonConvert.DeserializeObject<List<Prestamo>>(json);
            return lista;
        }
        public TransactionResult Agregar(Prestamo pre)
        {
            NameValueCollection parametros = ReverseMap(pre);
            string json = WebHelper.Post("/", parametros);
            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);
            return resultado;
        }

        private NameValueCollection ReverseMap(Prestamo pre)
        {
            NameValueCollection n = new NameValueCollection();
            return n;
        }
    }
}
