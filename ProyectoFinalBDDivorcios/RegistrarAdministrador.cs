using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
namespace ProyectoFinalBDDivorcios
{
    public partial class RegistrarAdministrador : Form
    {
        public RegistrarAdministrador()
        {
            InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Visible = true;
            this.Visible = false;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Form1 ofrm = new Form1();
            ofrm.Show();
            Close();
        }
        OracleConnection conOra6 = new OracleConnection("DATA SOURCE = xe ; PASSWORD = familiaMendoza ; USER ID = system");
        private void BntRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

            
            conOra6.Open();
            OracleCommand comando = new OracleCommand(" insert into Administrador values (:CI,:nombre,:apellido,:usuario,:email,:password)", conOra6);

            comando.Parameters.Add(":CI",OracleType.VarChar).Value=txtCedula.Text;
            comando.Parameters.Add(":nombre", OracleType.VarChar).Value = txtNombre.Text;
            comando.Parameters.Add(":apellido", OracleType.VarChar).Value = txtApellido.Text;
            comando.Parameters.Add(":usuario", OracleType.VarChar).Value = txtUsuario.Text;
            comando.Parameters.Add(":email", OracleType.VarChar).Value = txtEmail.Text;
            comando.Parameters.Add(":password", OracleType.VarChar).Value = txtPassword.Text;

            comando.ExecuteNonQuery();

            conOra6.Close();

            MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtUsuario.Clear();
            txtEmail.Clear();
            txtPassword.Clear();

            Form1 f1 = new Form1();
            f1.Visible = true;
            this.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
