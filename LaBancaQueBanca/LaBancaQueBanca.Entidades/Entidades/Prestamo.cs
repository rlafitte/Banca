using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaBancaQueBanca.Entidades.Entidades
{
    public class Prestamo
    {
        private string _linea;
        private double _tna;
        private int _plazo;
        private double _monto;
        private string _usuario;
        private int _id;

        public Prestamo(string linea, double tna, int plazo, double monto, string usuario, int id)
        {
            Linea = linea;
            Tna = tna;
            Plazo = plazo;
            Monto = monto;
            Usuario = usuario;
            Id = id;
        }
        public Prestamo()
        {

        }

        public string Linea { get => _linea; set => _linea = value; }
        public double Tna { get => _tna; set => _tna = value; }
        public int Plazo { get => _plazo; set => _plazo = value; }
        public double Monto { get => _monto; set => _monto = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public int Id { get => _id; set => _id = value; }

        public double CuotaCapital()
        {
            return (this.Monto / this.Plazo);
        }
        public double CuotaInteres()
        {
            double t = CuotaCapital() * (Tna/12/100);
            return t;
        }
        public double Cuota()
        {
            return (CuotaCapital() + CuotaInteres());
        }


    }
}
