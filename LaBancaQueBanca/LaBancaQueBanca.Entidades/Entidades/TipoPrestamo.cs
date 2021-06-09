using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaBancaQueBanca.Entidades.Entidades
{
    public class TipoPrestamo
    {
        private string _linea;
        private double _tna;
        private int _id;

        public TipoPrestamo(string linea, double tna, int id)
        {
            Linea = linea;
            Tna = tna;
            Id = id;
        }

        public string Linea { get => _linea; set => _linea = value; }
        public double Tna { get => _tna; set => _tna = value; }
        public int Id { get => _id; set => _id = value; }
    }
}
