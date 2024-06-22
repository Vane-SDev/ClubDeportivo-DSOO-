using ClubDeportivo;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;

namespace ClubDeportivo
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void frm_login_Load(object sender, EventArgs e)
        {

        }


        /*Text button para ingreso de usuario*/

        private void TxtBUsuario_Enter(object sender, EventArgs e)
        {
            /* Evento cuando llega el foco*/
            /*Codigo: si llega el cursor se pone en blanco (vacio)*/

            if (TxtBUsuario.Text == "Usuario")
            {
                TxtBUsuario.Text = "";
            }

        }

        /*Text button Usuario cuando el foco se va
         Vuelve a aparecer la palabra usuario, de modo que si no se completa no quede vacio*/

        private void TxtBUsuario_Leave(object sender, EventArgs e)
        {
            if (TxtBUsuario.Text == "")
            {
                TxtBUsuario.Text = "Usuario";
            }
        }

        /*Cuando se pone el foco en contraseña, aparece ****/

        private void TxTBPass_Enter(object sender, EventArgs e)
        {
            {
                if (TxTBPass.Text == "Contraseña")
                {
                    TxTBPass.Text = "";
                    TxTBPass.UseSystemPasswordChar = true; /*Propiedad que permite camuflar la contraseña, 
                                                            * si esta en true se ve camuflado lo que se escribe*/
                }

            }
        }

        /*Evento que sucede al sacar el foco de contraseña*/

        private void TxTBPass_Leave(object sender, EventArgs e)
        {
            if (TxTBPass.Text == "")
            {
                TxTBPass.Text = "Contraseña";
                TxTBPass.UseSystemPasswordChar = false; /*Propiedad que permite camuflar la contraseña, 
                                                            * si esta en false se ve lo que se escribe*/
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
            Datos.Usuarios dato = new Datos.Usuarios(); // variable que contiene todas las caracteristicas de la clase
            tablaLogin = dato.Log_Usu(TxtBUsuario.Text, TxTBPass.Text);

            if (tablaLogin.Rows.Count > 0)
            {
                // quiere decir que el resultado tiene 1 fila por lo que el usuario EXISTE
                MessageBox.Show("Ingreso exitoso");
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto");
            }

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
