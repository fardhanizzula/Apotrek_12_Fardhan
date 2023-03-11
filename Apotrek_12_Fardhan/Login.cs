using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotrek_12_Fardhan
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // percabnagan untuk login

            if (username.Text == "admin" && password.Text == "admin")
            {
                //jika textfield usernmae dan password berisi login, berpindah halaman ke form1
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
                MessageBox.Show("Login Berhasil", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                //jika textfield username dan password bukan admin, muncul pesan error
                username.Focus();
                username.Clear();
                password.Clear();
                MessageBox.Show("Perhatiakan kembali usernmae dan password anda!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
