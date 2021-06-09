using LaBancaQueBanca.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaBancaQueBanca.Negocio
{
    public class PrestamoNegocio
    {
        public void ValidarDatosPrestamo(string text, string text1)
        {
            Prestamo p = new Prestamo();

                double.TryParse(text, out double _monto);
                int.TryParse(text1, out int _plazo);
                p.Monto = _monto;
                p.Plazo = _plazo;
                if (p.Monto == 0)
                {
                throw new Exception("Monto inválido. Corrija su entrada.");
                }
                if (p.Plazo == 0)
                {

                throw new Exception("Plazo inválido. Corrija su entrada.");
                }
        }

        public string SimulacionCap(string tna, string monto, string plazo)
        {
            Prestamo p = new Prestamo();
            p.Monto = Convert.ToDouble(monto);
            p.Plazo = Convert.ToInt32(plazo);
            return p.CuotaCapital().ToString("0.00");

        }

        public string SimulacionInt(string monto, string plazo, string tna)
        {
            Prestamo p = new Prestamo();
            p.Monto = Convert.ToDouble(monto);
            p.Plazo = Convert.ToInt32(plazo);
            p.Tna = Convert.ToDouble(tna);
            return p.CuotaInteres().ToString("0.00");
        }
    }
}
