using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e){
            Boolean bUserFound = false;
            Usuario u1 = new Usuario("Alejandro", "1234");
            Usuario u2 = new Usuario("Juan", "123");
            if (u1.Usu_nombreUsuario == textBoxUserName.Text && u1.Usu_contrasenia == textBoxUserPassword.Text)
            {
                bUserFound = true;
            }
            if (u2.Usu_nombreUsuario == textBoxUserName.Text && u2.Usu_contrasenia == textBoxUserPassword.Text)
            {
                bUserFound = true;
            }

            if (bUserFound)
            {
                MessageBox.Show("Bienvenido/a: " + textBoxUserName.Text);
            }
            else {
                MessageBox.Show("Datos de Ingreso Incorrectos");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e){

        }
    }
}
