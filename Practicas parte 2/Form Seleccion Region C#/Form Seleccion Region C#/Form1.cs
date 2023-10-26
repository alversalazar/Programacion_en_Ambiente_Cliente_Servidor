using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace Form_Seleccion_Region_C_
{
    public partial class Form1 : Form
    {
        private DataSet ds = new DataSet();
        private SqlDataAdapter da = new SqlDataAdapter();
        private SqlConnection conexion;
        private string consulta;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            string cadena = "Data Source=DESKTOP-KE2G5CS\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;TrustServerCertificate=True";

            conexion = new SqlConnection(cadena);
            conexion.Open();

            consulta = "select * from Region order by RegionID";
            da = new SqlDataAdapter(consulta, conexion);
            ds.Clear(); // Limpia los datos existentes en el DataSet.
            da.Fill(ds, "Region");

            // Asigna los datos al DataGridView
            dataGridView1.DataSource = ds.Tables["Region"];

            conexion.Close();
        }
    }
}