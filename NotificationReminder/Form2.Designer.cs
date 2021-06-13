
namespace NotificationReminder
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTanggal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpJam = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNamaEvent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCatatan = new System.Windows.Forms.TextBox();
            this.btnTambahEvent = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tanggal:";
            // 
            // tbTanggal
            // 
            this.tbTanggal.Location = new System.Drawing.Point(209, 105);
            this.tbTanggal.Name = "tbTanggal";
            this.tbTanggal.ReadOnly = true;
            this.tbTanggal.Size = new System.Drawing.Size(396, 37);
            this.tbTanggal.TabIndex = 2;
            this.tbTanggal.TextChanged += new System.EventHandler(this.tbTanggal_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Waktu:";
            // 
            // dtpJam
            // 
            this.dtpJam.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpJam.Location = new System.Drawing.Point(209, 148);
            this.dtpJam.Name = "dtpJam";
            this.dtpJam.ShowUpDown = true;
            this.dtpJam.Size = new System.Drawing.Size(396, 37);
            this.dtpJam.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kategori:";
            // 
            // cbKategori
            // 
            this.cbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Items.AddRange(new object[] {
            "Kuliah",
            "Tugas",
            "Kegiatan Organisasi",
            "Kerja Kelompok",
            "Kegiatan lainnya"});
            this.cbKategori.Location = new System.Drawing.Point(209, 234);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(396, 38);
            this.cbKategori.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 30);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nama Event:";
            // 
            // tbNamaEvent
            // 
            this.tbNamaEvent.Location = new System.Drawing.Point(209, 191);
            this.tbNamaEvent.Name = "tbNamaEvent";
            this.tbNamaEvent.Size = new System.Drawing.Size(396, 37);
            this.tbNamaEvent.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 30);
            this.label6.TabIndex = 9;
            this.label6.Text = "Catatan:";
            // 
            // tbCatatan
            // 
            this.tbCatatan.Location = new System.Drawing.Point(209, 278);
            this.tbCatatan.Multiline = true;
            this.tbCatatan.Name = "tbCatatan";
            this.tbCatatan.Size = new System.Drawing.Size(396, 207);
            this.tbCatatan.TabIndex = 10;
            // 
            // btnTambahEvent
            // 
            this.btnTambahEvent.Location = new System.Drawing.Point(209, 501);
            this.btnTambahEvent.Name = "btnTambahEvent";
            this.btnTambahEvent.Size = new System.Drawing.Size(149, 49);
            this.btnTambahEvent.TabIndex = 11;
            this.btnTambahEvent.Text = "Tambah";
            this.btnTambahEvent.UseVisualStyleBackColor = true;
            this.btnTambahEvent.Click += new System.EventHandler(this.btnTambahEvent_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(456, 501);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(149, 49);
            this.btnBatal.TabIndex = 12;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(645, 575);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnTambahEvent);
            this.Controls.Add(this.tbCatatan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNamaEvent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpJam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTanggal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTanggal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpJam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNamaEvent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCatatan;
        private System.Windows.Forms.Button btnTambahEvent;
        private System.Windows.Forms.Button btnBatal;
    }
}