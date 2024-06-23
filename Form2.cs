using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class VentanaPpal : Form
    {
        public VentanaPpal()
        {
            InitializeComponent();
        }
        internal string? usuario;
        private void VentanaPpal_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "USUARIO: " + usuario;

        }


        private void btn_salirLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnInscribir_Click(object sender, EventArgs e)
        {
            registroPersona inscripcion = new registroPersona();
            inscripcion.Show();
            this.Hide();

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            registroPersona inscripcion = new registroPersona();
            inscripcion.Show();
            this.Hide();

        }
    }
}
