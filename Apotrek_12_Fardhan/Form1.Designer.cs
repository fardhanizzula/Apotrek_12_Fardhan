
namespace Apotrek_12_Fardhan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_obat = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            harga_jual = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            jumlah = new System.Windows.Forms.TextBox();
            harga_beli = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            btn_simpan = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label = new System.Windows.Forms.Label();
            tb_id = new System.Windows.Forms.TextBox();
            nama_obat = new System.Windows.Forms.TextBox();
            btn_update = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label9 = new System.Windows.Forms.Label();
            main_panel = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            btn_clear = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            label6 = new System.Windows.Forms.Label();
            kategori = new System.Windows.Forms.TextBox();
            panel2 = new System.Windows.Forms.Panel();
            btn_pilih = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgv_obat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            main_panel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_obat
            // 
            dgv_obat.AllowUserToAddRows = false;
            dgv_obat.AllowUserToDeleteRows = false;
            dgv_obat.AllowUserToResizeRows = false;
            dgv_obat.BackgroundColor = System.Drawing.Color.White;
            dgv_obat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgv_obat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_obat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgv_obat.Dock = System.Windows.Forms.DockStyle.Left;
            dgv_obat.Location = new System.Drawing.Point(0, 0);
            dgv_obat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgv_obat.Name = "dgv_obat";
            dgv_obat.ReadOnly = true;
            dgv_obat.RowHeadersVisible = false;
            dgv_obat.RowHeadersWidth = 51;
            dgv_obat.RowTemplate.Height = 29;
            dgv_obat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv_obat.Size = new System.Drawing.Size(664, 615);
            dgv_obat.TabIndex = 11;
            dgv_obat.CellClick += dgv_obat_CellClick;
            dgv_obat.CellContentClick += dgv_obat_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 42;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Nama Obat";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Kategori";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 76;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Harga Beli";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 86;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Harga Jual";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 87;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Column6.HeaderText = "Jumlah";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 70;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Column7.HeaderText = "Gambar";
            Column7.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // harga_jual
            // 
            harga_jual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            harga_jual.Location = new System.Drawing.Point(260, 91);
            harga_jual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            harga_jual.Multiline = true;
            harga_jual.Name = "harga_jual";
            harga_jual.Size = new System.Drawing.Size(192, 29);
            harga_jual.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(259, 131);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(64, 21);
            label5.TabIndex = 16;
            label5.Text = "jumlah";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(259, 14);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 21);
            label2.TabIndex = 12;
            label2.Text = "Harga Beli";
            // 
            // jumlah
            // 
            jumlah.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            jumlah.Location = new System.Drawing.Point(260, 154);
            jumlah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            jumlah.Multiline = true;
            jumlah.Name = "jumlah";
            jumlah.Size = new System.Drawing.Size(192, 29);
            jumlah.TabIndex = 15;
            // 
            // harga_beli
            // 
            harga_beli.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            harga_beli.Location = new System.Drawing.Point(259, 37);
            harga_beli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            harga_beli.Multiline = true;
            harga_beli.Name = "harga_beli";
            harga_beli.Size = new System.Drawing.Size(193, 29);
            harga_beli.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(260, 68);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(93, 21);
            label3.TabIndex = 14;
            label3.Text = "Harga Jual";
            label3.Click += label3_Click;
            // 
            // btn_simpan
            // 
            btn_simpan.BackColor = System.Drawing.Color.Lime;
            btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_simpan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_simpan.Location = new System.Drawing.Point(945, 355);
            btn_simpan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_simpan.Name = "btn_simpan";
            btn_simpan.Size = new System.Drawing.Size(227, 34);
            btn_simpan.TabIndex = 19;
            btn_simpan.Text = "TAMBAH";
            btn_simpan.UseVisualStyleBackColor = false;
            btn_simpan.Click += btn_simpan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(30, 14);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(27, 21);
            label1.TabIndex = 10;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label.Location = new System.Drawing.Point(30, 68);
            label.Name = "label";
            label.Size = new System.Drawing.Size(99, 21);
            label.TabIndex = 18;
            label.Text = "Nama Obat";
            label.Click += label_Click;
            // 
            // tb_id
            // 
            tb_id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tb_id.Location = new System.Drawing.Point(30, 37);
            tb_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tb_id.Name = "tb_id";
            tb_id.Size = new System.Drawing.Size(188, 29);
            tb_id.TabIndex = 9;
            tb_id.TextChanged += tb_id_TextChanged;
            // 
            // nama_obat
            // 
            nama_obat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            nama_obat.Location = new System.Drawing.Point(30, 91);
            nama_obat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            nama_obat.Multiline = true;
            nama_obat.Name = "nama_obat";
            nama_obat.Size = new System.Drawing.Size(188, 30);
            nama_obat.TabIndex = 17;
            // 
            // btn_update
            // 
            btn_update.BackColor = System.Drawing.Color.Orange;
            btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_update.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_update.Location = new System.Drawing.Point(944, 479);
            btn_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_update.Name = "btn_update";
            btn_update.Size = new System.Drawing.Size(228, 34);
            btn_update.TabIndex = 20;
            btn_update.Text = "UPDATE";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(685, 75);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(61, 21);
            label8.TabIndex = 22;
            label8.Text = "search";
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox1.Location = new System.Drawing.Point(752, 72);
            textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(420, 29);
            textBox1.TabIndex = 21;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.White;
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBox1.Location = new System.Drawing.Point(21, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(191, 194);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(21, 13);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(72, 21);
            label9.TabIndex = 24;
            label9.Text = "Gambar";
            // 
            // main_panel
            // 
            main_panel.BackColor = System.Drawing.SystemColors.Control;
            main_panel.Controls.Add(label4);
            main_panel.Controls.Add(button2);
            main_panel.Controls.Add(btn_update);
            main_panel.Controls.Add(btn_clear);
            main_panel.Controls.Add(textBox1);
            main_panel.Controls.Add(label8);
            main_panel.Controls.Add(btn_simpan);
            main_panel.Controls.Add(dgv_obat);
            main_panel.Controls.Add(panel1);
            main_panel.Controls.Add(panel2);
            main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            main_panel.Location = new System.Drawing.Point(0, 0);
            main_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            main_panel.Name = "main_panel";
            main_panel.Size = new System.Drawing.Size(1195, 615);
            main_panel.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(685, 9);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(292, 47);
            label4.TabIndex = 29;
            label4.Text = "FARDHAN APOTEK";
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Red;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(945, 539);
            button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(227, 34);
            button2.TabIndex = 28;
            button2.Text = "DELETE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = System.Drawing.Color.Yellow;
            btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_clear.Location = new System.Drawing.Point(944, 416);
            btn_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new System.Drawing.Size(228, 34);
            btn_clear.TabIndex = 27;
            btn_clear.Text = "CLEAR";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Lime;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(kategori);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(harga_jual);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(jumlah);
            panel1.Controls.Add(nama_obat);
            panel1.Controls.Add(tb_id);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(harga_beli);
            panel1.Controls.Add(label);
            panel1.Location = new System.Drawing.Point(685, 106);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(489, 201);
            panel1.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(30, 131);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(76, 21);
            label6.TabIndex = 20;
            label6.Text = "Kategori";
            label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // kategori
            // 
            kategori.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            kategori.Location = new System.Drawing.Point(30, 154);
            kategori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            kategori.Multiline = true;
            kategori.Name = "kategori";
            kategori.Size = new System.Drawing.Size(188, 29);
            kategori.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.Lime;
            panel2.Controls.Add(btn_pilih);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new System.Drawing.Point(685, 332);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(238, 272);
            panel2.TabIndex = 26;
            // 
            // btn_pilih
            // 
            btn_pilih.Location = new System.Drawing.Point(23, 238);
            btn_pilih.Name = "btn_pilih";
            btn_pilih.Size = new System.Drawing.Size(189, 23);
            btn_pilih.TabIndex = 25;
            btn_pilih.Text = "Pilih Gambar";
            btn_pilih.UseVisualStyleBackColor = true;
            btn_pilih.Click += btn_pilih_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1195, 615);
            Controls.Add(main_panel);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Apotek Fardhan";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_obat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            main_panel.ResumeLayout(false);
            main_panel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_obat;
        private System.Windows.Forms.TextBox harga_jual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox jumlah;
        private System.Windows.Forms.TextBox harga_beli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox nama_obat;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_pilih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn Column7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kategori;
    }
}

