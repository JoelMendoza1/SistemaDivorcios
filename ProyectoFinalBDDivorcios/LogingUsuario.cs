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
    public partial class LogingUsuario : Form
    {
        public LogingUsuario()
        {
            InitializeComponent();
        }

        private void LbMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Visible = true;
            this.Visible = false;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Form1 ofrm = new Form1();
            ofrm.Show();
            Close();
        }
        OracleConnection conOra4 = new OracleConnection("DATA SOURCE = xe ; PASSWORD = familiaMendoza ; USER ID = system");

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                conOra4.Open();
                OracleCommand comando = new OracleCommand(" select Usuario, PasswordUsu from Usuario where Usuario = :usuario AND PasswordUsu= :password", conOra4);

                comando.Parameters.AddWithValue(":usuario", OracleType.VarChar).Value = txtUsuario.Text;
                comando.Parameters.AddWithValue(":password", OracleType.VarChar).Value = txtPassword.Text;

                OracleDataReader leer = comando.ExecuteReader();

                if (leer.Read())
                {
                    Formulario formu = new Formulario();
                    formu.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrecta");
                }
                conOra4.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conOra4.Close();
            }

        }
    }
}
