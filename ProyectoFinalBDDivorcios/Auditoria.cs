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
    public partial class Auditoria : Form
    {
        public Auditoria()
        {
            InitializeComponent();
        }
        OracleConnection conOraAu = new OracleConnection("DATA SOURCE = xe ; PASSWORD = familiaMendoza ; USER ID = system");
        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Visible = true;
            this.Visible = false;
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            conOraAu.Open();
            OracleCommand command = new OracleCommand(" select*from AUDITORIA1", conOraAu);
            //command.CommandType= System.Data.CommandType.StoredProcedure;
            //command.Parameters.Add("Auditorias", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = command;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dtTablaAuditoria.DataSource = tabla;
            conOraAu.Close();

        }
    }
}
