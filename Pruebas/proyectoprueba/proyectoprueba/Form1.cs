using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoprueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=(local) ; database=Renta ; integrated security = true");
            string consulta = "select alquiler.cedula, cliente.nombre, fecha as Fecha_alquiler, dias_alquiler as Tiempo_Alquilado, saldo, alquiler.placa, marca from alquiler inner join cliente ON cliente.cedula = alquiler.cedula inner join carro ON carro.placa = alquiler.placa";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.alquilerTableAdapter.FillBy(this.rentaDataSet.Alquiler, fechaIToolStripTextBox.Text, fechaFToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Filtrar();
        }
        void Filtrar()
        {
            SqlConnection conexion = new SqlConnection("server=(local) ; database=Renta ; integrated security = true");
            SqlDataAdapter da = new SqlDataAdapter("filtrar", conexion);
            da.SelectCommand.Parameters.Add("@fechaI", SqlDbType.DateTime).Value = dateTimePicker1;
            da.SelectCommand.Parameters.Add("@fechaF", SqlDbType.DateTime).Value = dateTimePicker2;
            DataTable dt = new DataTable();
            _ = da.Fill(dt);
            this.dataGridView1.DataSource = dt;
        }
      

        private void filtroToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.alquilerTableAdapter.Filtro(this.rentaDataSet.Alquiler, fechaIToolStripTextBox1.Text, fechaFToolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void alquilerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
