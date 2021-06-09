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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarTiposPrestamos();
            CargarPrestamos();
            ActualizarComision();
        }

        private void CargarTiposPrestamos()
        {
            Operador Op = new Operador();
            lstTipoPrest.DataSource = null;
            lstTipoPrest.DataSource = Op.ListaTipoPrestamos();
        }

        private void CargarPrestamos()
        {
            Operador Op = new Operador();
            lstPrestamos.DataSource = null;
            lstPrestamos.DataSource = Op.ListaPrestamos(); 
        }

        private void lstTipoPrest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTipoPrest.SelectedIndex != null || lstTipoPrest.SelectedIndex != 0)
            {
                TipoPrestamo tp = (TipoPrestamo)lstTipoPrest.SelectedItem;
                tbLinea.Text = tp.Id.ToString();
                tbTNA.Text = tp.Tna.ToString();

            }
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            PrestamoNegocio p = new PrestamoNegocio();
            try
            {
            ValidarCampos();
            p.ValidarDatosPrestamo(tbMonto.Text, tbPlazo.Text);
            tbCuotaCap.Text = p.SimulacionCap(tbTNA.Text, tbMonto.Text, tbPlazo.Text);
            tbCuotaInt.Text = p.SimulacionInt(tbMonto.Text, tbPlazo.Text, tbTNA.Text);
            tbCuotaTotal.Text = (Convert.ToDouble(tbCuotaCap.Text) + Convert.ToDouble(tbCuotaInt.Text)).ToString("0.00"); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ValidarCampos()
        {
            if(tbMonto.Text == "" ||
                tbPlazo.Text == "")
            {
                throw new Exception("Complete campos Monto y Plazo.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfirmarAltaGUI frm = new ConfirmarAltaGUI();
            CargarPrestamos();
            ActualizarComision();
            frm.Owner = this;
            frm.Show();
        }

        private void ActualizarComision()
        {
            Operador op = new Operador();
            tbComiTotal.Text = op.PorcentajeComision().ToString("0.00");
        }
    }
}
