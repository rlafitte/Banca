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
    public class TipoPrestamoMapper
    {
        private TipoPrestamo _tipoPrestamo;
        public TipoPrestamoMapper()
        {
            this._tipoPrestamo = new TipoPrestamo();
        }

        public List<TipoPrestamo> TraerTipoPrestamos()
        {
            string json = WebHelper.Get("tipo/");
            List<TipoPrestamo> resultado = MapList(json);
            return resultado;
        }

        private List<TipoPrestamo> MapList(string json)
        {
            List<TipoPrestamo> lista = JsonConvert.DeserializeObject<List<TipoPrestamo>>(json);
            return lista;
        }
        public TransactionResult Agregar(TipoPrestamo tipoPre)
        {
            NameValueCollection parametros = ReverseMap(tipoPre);
            string json = WebHelper.Post("/", parametros);
            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);
            return resultado;
        }

        private NameValueCollection ReverseMap(TipoPrestamo tipoPre)
        {
            NameValueCollection n = new NameValueCollection();
            return n;
        }
    }
}
