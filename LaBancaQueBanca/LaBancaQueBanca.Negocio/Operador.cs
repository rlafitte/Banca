using LaBancaQueBanca.Datos.Mappers;
using LaBancaQueBanca.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaBancaQueBanca.Negocio
{
    public class Operador
    {
        private double _comision;
        private PrestamoMapper _presMapper;
        private TipoPrestamoMapper _tipoPresMapper;
        public Operador()
        {
            Prestamo p = new Prestamo();
            this.Comision = 0.15;

        }

        public double Comision { get => _comision; set => _comision = value; }
        public List<Prestamo> ListaPrestamos()
        {
            _presMapper = new PrestamoMapper();
            //llamar API para traer lista préstamos
            List<Prestamo> _list = _presMapper.TraerPrestamos();
            
            return _list;
        }

        public object ListaTipoPrestamos()
        {
            _tipoPresMapper = new TipoPrestamoMapper();
            //llamar API para traer lista préstamos
            List<TipoPrestamo> _list = _tipoPresMapper.TraerTipoPrestamos();

            return _list;
        }

        public double PorcentajeComision()
        {
            double d=0;
            return d;
        }
    }
}
