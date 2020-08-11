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
    public partial class Formulario2 : Form
    {
        OracleConnection conOra3 = new OracleConnection("DATA SOURCE = xe ; PASSWORD = familiaMendoza ; USER ID = system");
        
        public Formulario2()
        {
            InitializeComponent();
            
            cargarPaises();
            BloqueoExtranjero();
            Instruccion();
        }

        void cargarPaises()
        {
            
            try
            {
                conOra3.Open();
                OracleCommand comando = new OracleCommand(" select nom_prov from provincias", conOra3);


                OracleDataReader leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    cmbProvincias.Items.Add(leer["nom_prov"].ToString());
                }
                conOra3.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conOra3.Close();
            }
        }
        public void cargarCantones(int id_pais)
        {
            try
            {
                conOra3.Open();
                OracleCommand comando = new OracleCommand(" select nom_canton from Cantones where id_prov=:idprov", conOra3);

                comando.Parameters.AddWithValue(":idprov", OracleType.Int32).Value = id_pais;
                OracleDataReader leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    cmbCantones.Items.Add(leer["nom_canton"].ToString());
                }
                conOra3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conOra3.Close();
            }
        }
        void BloqueoExtranjero()
        {

            if (rbtnEcuatoriano.Checked == true)
            {
                txtExtrajero.Visible = false;
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            //Validacion 1

            try
            {

                conOra3.Open();
               
                OracleCommand comando = new OracleCommand("insert into DIVORCIADA values(:cedula,:nacionalidad,:fechaNaci,:edad,:numHijos,:idEtnia,:instruccion,:prov,:canton)", conOra3);

                comando.Parameters.Add(":cedula", OracleType.VarChar).Value = txtCedula.Text;
                if (rbtnEcuatoriano.Checked == true)
                {
                    comando.Parameters.Add(":nacionalidad", OracleType.VarChar).Value = "Ecuatoriano";
                }
                if (rbtnExtrajero.Checked == true)
                {
                    comando.Parameters.Add(":nacionalidad", OracleType.VarChar).Value = txtExtrajero.Text;
                }

                comando.Parameters.Add(":fechaNaci", OracleType.VarChar).Value = fechaNacimiento.Text;
                comando.Parameters.Add(":edad", OracleType.Number).Value = Convert.ToInt32(txtEdad.Text);
                comando.Parameters.Add(":numHijos", OracleType.Number).Value = Convert.ToInt32(txtNumHijos.Text);

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

                if (rbtnNoLeer.Checked == true)
                {
                    comando.Parameters.Add(":instruccion", OracleType.VarChar).Value = RI1.Text;
                }
                if (rbtnSiLeer.Checked == true)
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
                
                comando.Parameters.Add(":prov", OracleType.VarChar).Value = cmbProvincias.Text;
                comando.Parameters.Add(":canton", OracleType.VarChar).Value = cmbCantones.Text;
               

                comando.ExecuteNonQuery();
                


                MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conOra3.Close();
                Form1 fr1 = new Form1();
                fr1.Visible = true;
                this.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conOra3.Close();
            }

            

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCantones.Items.Clear();


            int id_prov =cmbProvincias.SelectedIndex;
            cargarCantones(id_prov + 1);
            
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEcuatoriano.Checked == true)
            {
                txtExtrajero.Visible = false;
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnExtrajero.Checked == true)
            {
                txtExtrajero.Visible = true;
            }
        }
        void Instruccion()
        {
            if (rbtnSiLeer.Checked == true)
            {
                grInstruccion.Visible = true;
            }
        }

        private void RbtnSiLeer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSiLeer.Checked == true)
            {
                grInstruccion.Visible = true;
            }
        }

        private void RbtnNoLeer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNoLeer.Checked == true)
            {
                grInstruccion.Visible = false;
            }
        }
    }
}
