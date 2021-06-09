using LaBancaQueBanca.Entidades.Entidades;
using LaBancaQueBanca.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaBancaQueBanca.GUI
{
    public partial class ConfirmarAltaGUI : Form
    {
        private Form1 form;
        private PrestamoNegocio _prNeg;
        public ConfirmarAltaGUI()
        {
            InitializeComponent();
            _prNeg = new PrestamoNegocio();
            this.Owner = form;
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            Prestamo p = new Prestamo("Prestamo Refinanciación", 60, 30, 100000, "877071", 0);

            _prNeg.AltaPrestamo(p);
            Owner.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();

        }
    }
}
