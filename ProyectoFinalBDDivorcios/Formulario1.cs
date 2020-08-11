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
    public partial class Formulario1 : Form
    {
        OracleConnection conOra2 = new OracleConnection("DATA SOURCE = xe ; PASSWORD = familiaMendoza ; USER ID = system");
        
        public Formulario1()
        {
            InitializeComponent();
            cargarPaises();
            BloqueoExtranjero();

        }
        void cargarPaises()
        {
            
            try
            {
                conOra2.Open();
                OracleCommand comando = new OracleCommand(" select nom_prov from provincias", conOra2);


                OracleDataReader leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    cmbProvincia.Items.Add(leer["nom_prov"].ToString());
                }
                conOra2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conOra2.Close();
            }
        }
        void NivelInstruccion()
        {

            if (rbtnSILeer.Checked == true)
            {
                grNivelIntruccion.Visible = false;
            }
        }
        void cargarCantones(int id_pais)
        {
            try
            {
                conOra2.Open();
                OracleCommand comando = new OracleCommand(" select nom_canton from Cantones where id_prov=:idprov", conOra2);

                comando.Parameters.AddWithValue(":idprov", OracleType.Int32).Value = id_pais;
                OracleDataReader leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    cmbCanton.Items.Add(leer["nom_canton"].ToString());
                }
                conOra2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conOra2.Close();
            }
        }
        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnNoLeer.Checked==true)
            {
                grNivelIntruccion.Visible = false;
            }
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                conOra2.Open();
                
                OracleCommand comando = new OracleCommand("insert into DIVORCIADO values(:cedula,:nacionalidad,:fechaNaci,:edad,:numHijos,:idEtnia,:instruccion,:prov,:canton)", conOra2);

                comando.Parameters.Add(":cedula", OracleType.VarChar).Value =txtCedula.Text;
                if (rbtnEcuatoriano.Checked == true)
                {
                    comando.Parameters.Add(":nacionalidad", OracleType.VarChar).Value ="Ecuatoriano";
                }
                if (rbntExtranjero.Checked == true)
                {
                    comando.Parameters.Add(":nacionalidad", OracleType.VarChar).Value =txtExtranjero.Text;
                }
                
                comando.Parameters.Add(":fechaNaci", OracleType.VarChar).Value = fechaNAcimiento.Text;
                comando.Parameters.Add(":edad", OracleType.Number).Value =Convert.ToInt32(txtEdad.Text);
                comando.Parameters.Add(":numHijos", OracleType.Number).Value =Convert.ToInt32(txtNumHijos.Text);
                
                if (RE1.Checked == true)
                {
                    comando.Parameters.Add(":idEtnia", OracleType.VarChar).Value = RE1.Text;
                }
                if (RE2.Checked == true)
                {
                    comando.Parameters.Add(":idEtnia", OracleType.VarChar).Value = RE2.Text;
                }
                if (RE3.Checked == true)
                {
                    comando.Parameters.Add(":idEtnia", OracleType.VarChar).Value = RE3.Text;
                }
                if (RE4.Checked == true)
                {
                    comando.Parameters.Add(":idEtnia", OracleType.VarChar).Value = RE4.Text;
                }
                if (RE5.Checked == true)
                {
                    comando.Parameters.Add(":idEtnia", OracleType.VarChar).Value = RE5.Text;
                }
                if (RE6.Checked == true)
                {
                    comando.Parameters.Add(":idEtnia", OracleType.VarChar).Value = RE6.Text;
                }
                if (RE7.Checked == true)
                {
                    comando.Parameters.Add(":idEtnia", OracleType.VarChar).Value = RE7.Text;
                }
                if (RE8.Checked == true)
                {
                    comando.Parameters.Add(":idEtnia", OracleType.VarChar).Value = RE8.Text;
                }
                
                if (rbnNoLeer.Checked == true)
                {
                    comando.Parameters.Add(":instruccion", OracleType.VarChar).Value = RI1.Text;
                }
                if (rbtnSILeer.Checked == true)
                {
                    if (RI1.Checked == true)
                    {
                        comando.Parameters.Add(":instruccion", OracleType.VarChar).Value = RI1.Text;
                    }
                    if (RI2.Checked == true)
                    {
                        comando.Parameters.Add(":instruccion", OracleType.VarChar).Value = RI2.Text;
                    }
                    if (RI3.Checked == true)
                    {
                        comando.Parameters.Add(":instruccion", OracleType.VarChar).Value = RI3.Text;
                    }
                    if (RI4.Checked == true)
                    {
                        comando.Parameters.Add(":instruccion", OracleType.VarChar).Value = RI4.Text;
                    }
                    if (RI5.Checked == true)
                    {
                        comando.Parameters.Add(":instruccion", OracleType.VarChar).Value = RI5.Text;
                    }
                    if (RI6.Checked == true)
                    {
                        comando.Parameters.Add(":instruccion", OracleType.VarChar).Value = RI6.Text;
                    }
                    if (RI7.Checked == true)
                    {
                        comando.Parameters.Add(":instruccion", OracleType.VarChar).Value = RI7.Text;
                    }
                    if (RI8.Checked == true)
                    {
                        comando.Parameters.Add(":instruccion", OracleType.VarChar).Value = RI8.Text;
                    }
                    if (RI9.Checked == true)
                    {
                        comando.Parameters.Add(":instruccion", OracleType.VarChar).Value = RI9.Text;
                    }
                }
                
                comando.Parameters.Add(":prov", OracleType.VarChar).Value = cmbProvincia.Text;
                comando.Parameters.Add(":canton", OracleType.VarChar).Value = cmbCanton.Text;
                

                


                comando.ExecuteNonQuery();

                
                MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conOra2.Close();
                Formulario2 f2 = new Formulario2();
                f2.Visible = true;
                this.Visible = false;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conOra2.Close();
            }
            
        }

        private void CmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCanton.Items.Clear();


            int id_prov = cmbProvincia.SelectedIndex;
            cargarCantones(id_prov + 1);
            
        }
        void BloqueoExtranjero()
        {
            
            if (rbtnEcuatoriano.Checked == true)
            {
                txtExtranjero.Visible = false;
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbntExtranjero.Checked == true)
            {
                txtExtranjero.Visible = true;
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEcuatoriano.Checked == true)
            {
                txtExtranjero.Visible = false;
            }
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSILeer.Checked == true)
            {
                grNivelIntruccion.Visible = true;
            }
        }
    }
}
