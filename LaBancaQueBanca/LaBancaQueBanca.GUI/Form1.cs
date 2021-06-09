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
            Operador Op = new Operador();
            lstTipoPrest.DataSource = null;
            lstTipoPrest.DataSource = Op.ListaTipoPrestamos();
            lstPrestamos.DataSource = null;
            //lstPrestamos.DataSource = Op.ListaPrestamos();
        }
    }
}
