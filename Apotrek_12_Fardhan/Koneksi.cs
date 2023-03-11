using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apotrek_12_Fardhan
{
    internal class Koneksi
    {
        // method getconnection untuk koneksi ke database
        public static MySqlConnection getConnection()
        {
            // objek mysqlconnection yang bernama koneksi
            MySqlConnection koneksi = null;

            try
            {
                // variable untuk koneksi ke database yg diinginkan
                string sConnstring = "server=localhost; uid=root; password=; database=db_sekolah";
                // objek mysqlconnection dengan string yg sudah dibuat dan disimpan ke variable koneksi
                koneksi = new MySqlConnection(sConnstring);
            }
            catch (MySqlException sqlex)
            {
                // pesan error jika tidak berhasil melakukan koneksi 
                throw new Exception(sqlex.Message.ToString());
            }
            return koneksi;
        }
    }
}
