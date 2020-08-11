using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalBDDivorcios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BntIniciarSecion_Click(object sender, EventArgs e)
        {
            if (cmbTiposUsuario.Text == "Administrador")
            {
                LogingAdministrador la = new LogingAdministrador();
                la.Visible = true;
                this.Visible = false;
            }
            else if(cmbTiposUsuario.Text=="Usuario")
            {
                LogingUsuario lu = new LogingUsuario();
                lu.Visible = true;
                this.Visible = false;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Form1 ofrm = new Form1();
            ofrm.Show();
            Close();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (cmbTiposUsuario.Text == "Administrador")
            {
                RegistrarAdministrador ra = new RegistrarAdministrador();
                ra.Visible = true;
                this.Visible = false;

            }
            else if (cmbTiposUsuario.Text == "Usuario")
            {
                RegistrarUsuario ru = new RegistrarUsuario();
                ru.Visible = true;
                this.Visible = false;

            }
        }
    }
}
