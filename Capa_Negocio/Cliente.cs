using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Capa_Datos;




namespace Capa_Negocio
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenar_gridCl();
        }

        public DataTable llenar_gridCl()
        {
            Conexion.Conectarbd();
            DataTable dt = new DataTable();
            string consulta = "Select * from Clientes";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectarbd());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_Idcl.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_Nombrecl.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_Apellidocl.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_Direcl.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_Telefcl.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_Nis.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txt_Monto.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            }

            catch
            {

            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Conexion.Conectarbd();
            string insertar = "INSERT INTO Clientes (Id,Nombre,Apellido,Direccion,Telefono,Nis,Monto) VALUES (@Id,@Nombre,@Apellido,@Direccion,@Telefono,@Nis,@Monto)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectarbd());
            cmd1.Parameters.AddWithValue("@Id", txt_Idcl.Text);
            cmd1.Parameters.AddWithValue("@Nombre", txt_Nombrecl.Text);
            cmd1.Parameters.AddWithValue("@Apellido", txt_Apellidocl.Text);
            cmd1.Parameters.AddWithValue("@Direccion", txt_Direcl.Text);
            cmd1.Parameters.AddWithValue("@Telefono", txt_Telefcl.Text);
            cmd1.Parameters.AddWithValue("@Nis", txt_Nis.Text);
            cmd1.Parameters.AddWithValue("@Monto", txt_Monto.Text);

            cmd1.ExecuteNonQuery();

            MessageBox.Show("Los datos fueron agregados con exito");

            dataGridView1.DataSource = llenar_gridCl();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Conexion.Conectarbd();
            string update = "UPDATE Clientes SET Id=@Id, Nombre=@Nombre, Apellido=@Apellido, Direccion=@Direccion, Telefono=@Telefono, Nis=@Nis, Monto=@Monto WHERE Id=@Id";
            SqlCommand cmd5 = new SqlCommand(update, Conexion.Conectarbd());

            cmd5.Parameters.AddWithValue("@Id", txt_Idcl.Text);
            cmd5.Parameters.AddWithValue("@Nombre", txt_Nombrecl.Text);
            cmd5.Parameters.AddWithValue("@Apellido", txt_Apellidocl.Text);
            cmd5.Parameters.AddWithValue("@Direccion", txt_Direcl.Text);
            cmd5.Parameters.AddWithValue("@Telefono", txt_Telefcl.Text);
            cmd5.Parameters.AddWithValue("@Nis", txt_Nis.Text);
            cmd5.Parameters.AddWithValue("@Monto", txt_Monto.Text);

            cmd5.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron actualizados con exito");

            dataGridView1.DataSource = llenar_gridCl();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Conexion.Conectarbd();
            string eliminar = "DELETE FROM Clientes WHERE Id=@Id";
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectarbd());
            cmd3.Parameters.AddWithValue("@Id", txt_Idcl.Text);

            cmd3.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron eliminados con exito");

            dataGridView1.DataSource = llenar_gridCl();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Idcl.Clear();
            txt_Nombrecl.Clear();
            txt_Apellidocl.Clear();
            txt_Direcl.Clear();
            txt_Telefcl.Clear();
            txt_Nis.Clear();
            txt_Monto.Clear();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Facturar_Click(object sender, EventArgs e)
        {
            Facturas abrir = new Facturas();
            abrir.Show();
            this.Hide();
        }

        private void txt_Monto_TextChanged(object sender, EventArgs e)
        {
            txt_Monto.Enabled = false;
        }
    }
}
