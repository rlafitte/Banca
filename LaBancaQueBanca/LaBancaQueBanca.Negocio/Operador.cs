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
        public Operador()
        {
            Prestamo p = new Prestamo();
            this.Comision = 0.15;

        }

        public double Comision { get => _comision; set => _comision = value; }
        public List<Prestamo> ListaPrestamos()
        {
            //llamar API para traer lista préstamos
            List<Prestamo> _list = new List<Prestamo>();
            
            return _list;
        }
        public double PorcentajeComision()
        {
            double d=0;
            return d;
        }
    }
}
