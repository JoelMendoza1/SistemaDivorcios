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
    public partial class LogingAdministrador : Form
    {
        public LogingAdministrador()
        {
            InitializeComponent();
        }

        private void LbMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
        OracleConnection conOra5 = new OracleConnection("DATA SOURCE = xe ; PASSWORD = familiaMendoza ; USER ID = system");
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                conOra5.Open();
                OracleCommand comando = new OracleCommand(" select UsuarioAdmin, PasswordAdmin from Administrador where UsuarioAdmin = :usuario AND PasswordAdmin= :password", conOra5);

                comando.Parameters.AddWithValue(":usuario", OracleType.VarChar).Value = txtUsuario.Text;
                comando.Parameters.AddWithValue(":password", OracleType.VarChar).Value = txtPassword.Text;

                OracleDataReader leer = comando.ExecuteReader();

                if (leer.Read())
                {
                    Auditoria audi = new Auditoria();
                    audi.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrecta");
                }
                conOra5.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conOra5.Close();
            }

        }
    }
}
