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
    public partial class Formulario : Form
    {
        OracleConnection conOra1 = new OracleConnection("DATA SOURCE = xe ; PASSWORD = familiaMendoza ; USER ID = system");
        

        public Formulario()
        {
            InitializeComponent();
            cargarPaises();
           
        }

        void cargarPaises()
        {
            
            try
            {
                conOra1.Open();
                OracleCommand comando = new OracleCommand(" select nom_prov from provincias", conOra1);


                OracleDataReader leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    cmbProvincia.Items.Add(leer["nom_prov"].ToString());
                }
                conOra1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conOra1.Close();
            }
        }
        void cargarCantones(int id_pais)
        {
            try
            {
                conOra1.Open();
                OracleCommand comando = new OracleCommand(" select nom_canton from Cantones where id_prov=:idprov", conOra1);

                comando.Parameters.AddWithValue(":idprov", OracleType.Int32).Value = id_pais;
                OracleDataReader leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    cmbCanton.Items.Add(leer["nom_canton"].ToString());
                }
                conOra1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conOra1.Close();
            }
        }
        private void Formulario_Load(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Label16_Click(object sender, EventArgs e)
        {

        }

        private void Label17_Click(object sender, EventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void Label19_Click(object sender, EventArgs e)
        {

        }

        private void Label20_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label21_Click(object sender, EventArgs e)
        {

        }

        private void Label22_Click(object sender, EventArgs e)
        {

        }

        private void Label23_Click(object sender, EventArgs e)
        {

        }

        private void Label24_Click(object sender, EventArgs e)
        {

        }

        private void Label25_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void Button1_Click(object sender, EventArgs e)
        {

           
                try
                {
                    conOra1.Open();

                   
                    OracleCommand comando = new OracleCommand("  insert into CABECERA values (:actaIncripcion,:provincia,:canton,:fechaIncripcion,:fechaSentencia,:fechaMatrimonio,:capitulacion,:causaDiv,:duracion)", conOra1);

                    comando.Parameters.Add(":actaIncripcion", OracleType.Int32).Value = Convert.ToInt32(txtActaInscripcion.Text);
                    comando.Parameters.Add(":provincia", OracleType.VarChar).Value = cmbProvincia.Text;
                    comando.Parameters.Add(":canton", OracleType.VarChar).Value = cmbCanton.Text;
                    comando.Parameters.Add(":fechaIncripcion", OracleType.VarChar).Value = fechaInscripcion.Text;
                    comando.Parameters.Add(":fechaSentencia", OracleType.VarChar).Value = fechaSentencia.Text;
                    comando.Parameters.Add(":fechaMatrimonio", OracleType.VarChar).Value = fechaMAtrimonio.Text;
                    if (rbntNo.Checked == true)
                    {
                        comando.Parameters.Add(":capitulacion", OracleType.VarChar).Value = rbntNo.Text;
                    }
                    if (rbtnSi.Checked == true)
                    {
                        comando.Parameters.Add(":capitulacion", OracleType.VarChar).Value = rbtnSi.Text;
                    }
                    if (R1.Checked == true)
                    {
                        comando.Parameters.Add(":causaDiv", OracleType.VarChar).Value = lb1.Text;
                    }
                    if (R2.Checked == true)
                    {
                        comando.Parameters.Add(":causaDiv", OracleType.VarChar).Value = lb2.Text;
                    }
                    if (R3.Checked == true)
                    {
                        comando.Parameters.Add(":causaDiv", OracleType.VarChar).Value = lb3.Text;
                    }
                    if (R4.Checked == true)
                    {
                        comando.Parameters.Add(":causaDiv", OracleType.VarChar).Value = lb4.Text;
                    }
                    if (R5.Checked == true)
                    {
                        comando.Parameters.Add(":causaDiv", OracleType.VarChar).Value = lb5.Text;
                    }
                    if (R6.Checked == true)
                    {
                        comando.Parameters.Add(":causaDiv", OracleType.VarChar).Value = lb6.Text;
                    }
                    if (R7.Checked == true)
                    {
                        comando.Parameters.Add(":causaDiv", OracleType.VarChar).Value = lb7.Text;
                    }
                    if (R8.Checked == true)
                    {
                        comando.Parameters.Add(":causaDiv", OracleType.VarChar).Value = lb8.Text;
                    }
                    if (R9.Checked == true)
                    {
                        comando.Parameters.Add(":causaDiv", OracleType.VarChar).Value = lb9.Text;
                    }
                    if (R10.Checked == true)
                    {
                        comando.Parameters.Add(":causaDiv", OracleType.VarChar).Value = lb10.Text;
                    }
                    
                    comando.Parameters.Add(":duracion", OracleType.Number).Value = Convert.ToInt32( txtAnosMAtrimonio.Text);
                    int acta =Convert.ToInt32( txtActaInscripcion.Text);
                    comando.ExecuteNonQuery();

                    conOra1.Close();

                    MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Formulario1 form1 = new Formulario1();
                    form1.Visible = true;
                    this.Visible = false;
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conOra1.Close();
                }

            }
            
            
        

        private void CmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCanton.Items.Clear();
            
            
            int id_prov = cmbProvincia.SelectedIndex;
            cargarCantones(id_prov+1);
            
        }
    }
}
