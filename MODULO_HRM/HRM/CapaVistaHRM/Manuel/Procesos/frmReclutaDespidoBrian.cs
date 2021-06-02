using CapaControladorHRM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaHRM.Manuel.Procesos
{
    public partial class frmReclutaDespidoBrian : Form
    {
        ControladorBS BS = new ControladorBS();
        public frmReclutaDespidoBrian()
        {
            InitializeComponent();
            llenado1();
            llenado2();
        }
        private void llenado1() {

            dataGridView1.Rows.Clear();
            OdbcDataReader mostrar = BS.funcMostrarRecluta();
            try
            {
                while (mostrar.Read())
                {
                    dataGridView1.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4), mostrar.GetString(5));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        private void llenado2()
        {

            dataGridView2.Rows.Clear();
            OdbcDataReader mostrar = BS.funcMostrarDespido();
            try
            {
                while (mostrar.Read())
                {
                    dataGridView2.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("INGRESE TODOS LOS CAMPOS");
            }
            else
            {
                OdbcDataReader consulta = BS.funcinsertarReclutadespedido(textBox1.Text, textBox2.Text, "1");
                MessageBox.Show("INGRESE EXITOSO");
                llenado2();
            }
        }
        private void frmReclutaDespidoBrian_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
