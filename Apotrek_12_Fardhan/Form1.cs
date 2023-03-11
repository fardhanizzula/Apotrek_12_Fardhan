using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace Apotrek_12_Fardhan
{
    public partial class Form1 : Form
    {
        // koneksi ke database
        MySqlConnection koneksi = Koneksi.getConnection();
        // membuat objek dari class DataTable
        DataTable dataTable = new DataTable();

        //Tampilan MySql
        public DataTable getDataTable()
        {
            dataTable.Reset();
            dataTable = new DataTable();
            using (MySqlCommand command = new MySqlCommand("SELECT * FROM fardhan_apotek", koneksi))
            {
                koneksi.Open();

                MySqlDataReader reader = command.ExecuteReader();
                dataTable.Load(reader);
            }
            return dataTable;
        }

        // method mengambil data tabel dan memasukannya ke column yang ada di gridview
        public void filldataTable()
        {
            dgv_obat.AutoGenerateColumns = false;
            dgv_obat.RowTemplate.Height = 100;
            dgv_obat.DataSource = getDataTable();
            Column1.DataPropertyName = "id";
            Column2.DataPropertyName = "nama_obat";
            Column3.DataPropertyName = "kategori";
            Column4.DataPropertyName = "harga_beli";
            Column5.DataPropertyName = "harga_jual";
            Column6.DataPropertyName = "jumlah";
            Column7.DataPropertyName = "gambar";

        }

        // method menghapus isi field
        public void clear()
        {
            tb_id.Clear();
            nama_obat.Clear();
            kategori.Clear();
            harga_beli.Clear();
            harga_jual.Clear();
            jumlah.Clear();
            pictureBox1.Image = null;
        }

        // method mengurutkan id
        public void resetIncrement()
        {
            MySqlScript script = new MySqlScript(koneksi, "SET @id :=0; Update fardhan_apotek SET id = @id := (@id+1); " + "ALTER TABLE fardhan_apotek AUTO_INCREMENT = 1;");
            script.Execute();
        }

        // method mencari data
        public void searchData(string ValueToFind)
        {
            string searchQuery = "SELECT * FROM fardhan_apotek WHERE CONCAT (id, nama_obat, kategori, harga_beli, harga_jual, jumlah) LIKE '%" + ValueToFind + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, koneksi);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv_obat.DataSource = table;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filldataTable();

            tb_id.Enabled = false;
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pnlLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;

            try
            {
                // Convert image ke byte array
                byte[] imageData;
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageData = ms.ToArray();
                }
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "INSERT INTO fardhan_apotek(nama_obat, kategori, harga_beli, harga_jual, jumlah, gambar) VALUE(@nama_obat, @kategori, @harga_beli, @harga_jual, @jumlah, @gambar)";
                cmd.Parameters.AddWithValue("@nama_obat", nama_obat.Text);
                cmd.Parameters.AddWithValue("@kategori", kategori.Text);
                cmd.Parameters.AddWithValue("@harga_beli", harga_beli.Text);
                cmd.Parameters.AddWithValue("@harga_jual", harga_jual.Text);
                cmd.Parameters.AddWithValue("@jumlah", jumlah.Text);
                cmd.Parameters.AddWithValue("@gambar", imageData);
                cmd.ExecuteNonQuery();

                koneksi.Close();
                dataTable.Clear();
                filldataTable();
            }
            catch (Exception ex)
            {

            }
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_2(object sender, EventArgs e)
        {

        }

        private void dgv_obat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgv_obat.CurrentCell.RowIndex.ToString());
            tb_id.Text = dgv_obat.Rows[id].Cells[0].Value.ToString();
            nama_obat.Text = dgv_obat.Rows[id].Cells[1].Value.ToString();
            kategori.Text = dgv_obat.Rows[id].Cells[2].Value.ToString();
            harga_beli.Text = dgv_obat.Rows[id].Cells[3].Value.ToString();
            harga_jual.Text = dgv_obat.Rows[id].Cells[4].Value.ToString();
            jumlah.Text = dgv_obat.Rows[id].Cells[5].Value.ToString();
            // mengambil data gambar BLOB untuk baris yang diklik dan buat objek Gambar
            Byte[] img = (Byte[])dgv_obat.CurrentRow.Cells[6].Value;

            //MemoryStream digunakan untuk membaca dan menulis data ke dalam memori yang diwakili oleh objek byte[].
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;

            try
            {
                // Convert image ke byte array
                byte[] imageData;
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageData = ms.ToArray();
                }
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "UPDATE fardhan_apotek SET nama_obat = @nama_obat, kategori = @kategori, harga_beli = @harga_beli, harga_jual = @harga_jual, jumlah = @jumlah, gambar = @gambar WHERE ID = @id";
                cmd.Parameters.AddWithValue("@id", tb_id.Text);
                cmd.Parameters.AddWithValue("@nama_obat", nama_obat.Text);
                cmd.Parameters.AddWithValue("@kategori", kategori.Text);
                cmd.Parameters.AddWithValue("@harga_beli", harga_beli.Text);
                cmd.Parameters.AddWithValue("@harga_jual", harga_jual.Text);
                cmd.Parameters.AddWithValue("@jumlah", jumlah.Text);
                cmd.Parameters.AddWithValue("@gambar", imageData);
                cmd.ExecuteNonQuery();
                koneksi.Close();
                dataTable.Clear();
                filldataTable();
            }
            catch (Exception ex)
            {

            }
        }

        private void dgv_obat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            searchData(textBox1.Text);
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tb_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;

            try
            {
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "DELETE from fardhan_apotek WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", tb_id.Text);
                cmd.ExecuteNonQuery();

                resetIncrement();
                clear();
                koneksi.Close();
                dataTable.Clear();
                filldataTable();
            }
            catch (MySqlException ex)
            {
            }
        }

        private void btn_pilih_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfd = new OpenFileDialog();
            openfd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            if (openfd.ShowDialog() == DialogResult.OK)
            {
                var fileSize = new FileInfo(openfd.FileName).Length; // get the size of the selected file
                if (fileSize > 1000000) // check if the size is more than 1000KB
                {
                    MessageBox.Show("Ukuran file gambar terlalu besar! (max = 1000kb)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    pictureBox1.Image = new Bitmap(openfd.FileName);
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
