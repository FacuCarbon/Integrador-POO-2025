using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador
{
    public partial class Form_vendedor : Form
    {
        public Form_vendedor()
        {
            InitializeComponent();
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Todavía no guarda :)");
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            input_vendedor_nombre.Text = "";
            input_vendedor_apellido.Text = "";
            input_vendedor_dni.Text = "";
            input_vendedor_cuit.Text = "";
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    
    }
}
