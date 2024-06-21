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
    public partial class registroPersona : Form
    {
        public registroPersona()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Agregar una fila para completar un registro
            //Se inserta una fila al final

            int fila = dtgvRegistro.Rows.Add();
            string tipodoc;
            int eleccion = cboxTipo.SelectedIndex;
           
                
                  

            //Se agregan datos a las filas, considerando que s einicia en la columna 0

            dtgvRegistro.Rows[fila].Cells[1].Value = txtNombre.Text;
            dtgvRegistro.Rows[fila].Cells[2].Value = txtApellido.Text;
           
            //tipo - combo box

            switch (eleccion)

             {
                 case 0:
                     dtgvRegistro.Rows[fila].Cells[3].Value =  "DNI";
                     break;
                 case 1:
                     dtgvRegistro.Rows[fila].Cells[3].Value = "Pasaporte";
                     break;
                 case 2:
                     dtgvRegistro.Rows[fila].Cells[3].Value = "Libreta Civica";
                     break;
             }
            dtgvRegistro.Rows[fila].Cells[4].Value = txtNumero.Text;
            //boton apto fisico
            if (chkAptoFisico.Checked==false)
            {
                dtgvRegistro.Rows[fila].Cells[5].Value = "No entregado";
            }
            else
            {
                dtgvRegistro.Rows[fila].Cells[5].Value = "Entregado";
            }
            //socio-no socio
            if (rdbtnSocio.Checked == true)
            {
                dtgvRegistro.Rows[fila].Cells[6].Value = "Socio";
            }
            else
            {
                dtgvRegistro.Rows[fila].Cells[6].Value = "No Socio";
            }


            //Blanqueo de los text box 

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNumero.Text = "";
            rdbtnSocio.Checked = true;
            chkAptoFisico.Checked = false;

            //Pone foco en el objeto detallado

            txtNombre.Focus();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void registroPersona_Load(object sender, EventArgs e)
        {

        }

        private void rdbtnSocio_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
