
namespace NotificationReminder
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNoteManager = new System.Windows.Forms.Button();
            this.btnKalender = new System.Windows.Forms.Button();
            this.btnBeranda = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSalam = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelSelamatDatang = new System.Windows.Forms.Panel();
            this.panelKalender = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnEditEvent = new System.Windows.Forms.Button();
            this.eventBox = new System.Windows.Forms.ListBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.kalender = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.panelBeranda = new System.Windows.Forms.Panel();
            this.tbCatatanEventAkanDatang = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.upComingEvent = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelNoteManager = new System.Windows.Forms.Panel();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.noteList = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelSelamatDatang.SuspendLayout();
            this.panelKalender.SuspendLayout();
            this.panelBeranda.SuspendLayout();
            this.panelNoteManager.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnNoteManager);
            this.panel1.Controls.Add(this.btnKalender);
            this.panel1.Controls.Add(this.btnBeranda);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 573);
            this.panel1.TabIndex = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Blue;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(3, 490);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(222, 42);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.Text = "Minimize";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(3, 531);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(222, 42);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNoteManager
            // 
            this.btnNoteManager.FlatAppearance.BorderSize = 0;
            this.btnNoteManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoteManager.ForeColor = System.Drawing.Color.White;
            this.btnNoteManager.Location = new System.Drawing.Point(3, 342);
            this.btnNoteManager.Name = "btnNoteManager";
            this.btnNoteManager.Size = new System.Drawing.Size(222, 92);
            this.btnNoteManager.TabIndex = 3;
            this.btnNoteManager.Text = "Note Manager";
            this.btnNoteManager.UseVisualStyleBackColor = true;
            this.btnNoteManager.Click += new System.EventHandler(this.btnNoteManager_Click);
            // 
            // btnKalender
            // 
            this.btnKalender.FlatAppearance.BorderSize = 0;
            this.btnKalender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKalender.ForeColor = System.Drawing.Color.White;
            this.btnKalender.Location = new System.Drawing.Point(3, 244);
            this.btnKalender.Name = "btnKalender";
            this.btnKalender.Size = new System.Drawing.Size(222, 92);
            this.btnKalender.TabIndex = 2;
            this.btnKalender.Text = "Kalender";
            this.btnKalender.UseVisualStyleBackColor = true;
            this.btnKalender.Click += new System.EventHandler(this.btnKalender_Click);
            // 
            // btnBeranda
            // 
            this.btnBeranda.FlatAppearance.BorderSize = 0;
            this.btnBeranda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeranda.ForeColor = System.Drawing.Color.White;
            this.btnBeranda.Location = new System.Drawing.Point(3, 143);
            this.btnBeranda.Name = "btnBeranda";
            this.btnBeranda.Size = new System.Drawing.Size(222, 92);
            this.btnBeranda.TabIndex = 1;
            this.btnBeranda.Text = "Beranda";
            this.btnBeranda.UseVisualStyleBackColor = true;
            this.btnBeranda.Click += new System.EventHandler(this.btnBeranda_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 100);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remind\r\nand Note It!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 30);
            this.label2.TabIndex = 1;
            // 
            // lblSalam
            // 
            this.lblSalam.AutoSize = true;
            this.lblSalam.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalam.Location = new System.Drawing.Point(18, 19);
            this.lblSalam.Name = "lblSalam";
            this.lblSalam.Size = new System.Drawing.Size(602, 85);
            this.lblSalam.TabIndex = 4;
            this.lblSalam.Text = "Selamat Datang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(636, 240);
            this.label3.TabIndex = 5;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // panelSelamatDatang
            // 
            this.panelSelamatDatang.Controls.Add(this.label3);
            this.panelSelamatDatang.Controls.Add(this.lblSalam);
            this.panelSelamatDatang.Location = new System.Drawing.Point(292, 25);
            this.panelSelamatDatang.Name = "panelSelamatDatang";
            this.panelSelamatDatang.Size = new System.Drawing.Size(668, 409);
            this.panelSelamatDatang.TabIndex = 2;
            // 
            // panelKalender
            // 
            this.panelKalender.Controls.Add(this.label5);
            this.panelKalender.Controls.Add(this.btnHapus);
            this.panelKalender.Controls.Add(this.btnEditEvent);
            this.panelKalender.Controls.Add(this.eventBox);
            this.panelKalender.Controls.Add(this.btnTambah);
            this.panelKalender.Controls.Add(this.kalender);
            this.panelKalender.Controls.Add(this.label4);
            this.panelKalender.Location = new System.Drawing.Point(251, 16);
            this.panelKalender.Name = "panelKalender";
            this.panelKalender.Size = new System.Drawing.Size(750, 536);
            this.panelKalender.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(513, 161);
            this.label5.TabIndex = 7;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // btnHapus
            // 
            this.btnHapus.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.Location = new System.Drawing.Point(597, 465);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(111, 51);
            this.btnHapus.TabIndex = 6;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnEditEvent
            // 
            this.btnEditEvent.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEvent.Location = new System.Drawing.Point(480, 465);
            this.btnEditEvent.Name = "btnEditEvent";
            this.btnEditEvent.Size = new System.Drawing.Size(111, 51);
            this.btnEditEvent.TabIndex = 5;
            this.btnEditEvent.Text = "Edit";
            this.btnEditEvent.UseVisualStyleBackColor = true;
            this.btnEditEvent.Click += new System.EventHandler(this.btnEditEvent_Click);
            // 
            // eventBox
            // 
            this.eventBox.FormattingEnabled = true;
            this.eventBox.ItemHeight = 30;
            this.eventBox.Location = new System.Drawing.Point(363, 263);
            this.eventBox.Name = "eventBox";
            this.eventBox.Size = new System.Drawing.Size(345, 184);
            this.eventBox.TabIndex = 4;
            // 
            // btnTambah
            // 
            this.btnTambah.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Location = new System.Drawing.Point(363, 465);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(111, 51);
            this.btnTambah.TabIndex = 3;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // kalender
            // 
            this.kalender.Location = new System.Drawing.Point(29, 263);
            this.kalender.Name = "kalender";
            this.kalender.TabIndex = 2;
            this.kalender.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.kalender_DateChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 56);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kalender";
            // 
            // panelBeranda
            // 
            this.panelBeranda.Controls.Add(this.tbCatatanEventAkanDatang);
            this.panelBeranda.Controls.Add(this.label10);
            this.panelBeranda.Controls.Add(this.label6);
            this.panelBeranda.Controls.Add(this.upComingEvent);
            this.panelBeranda.Controls.Add(this.label7);
            this.panelBeranda.Location = new System.Drawing.Point(250, 16);
            this.panelBeranda.Name = "panelBeranda";
            this.panelBeranda.Size = new System.Drawing.Size(750, 536);
            this.panelBeranda.TabIndex = 5;
            // 
            // tbCatatanEventAkanDatang
            // 
            this.tbCatatanEventAkanDatang.Location = new System.Drawing.Point(395, 212);
            this.tbCatatanEventAkanDatang.Multiline = true;
            this.tbCatatanEventAkanDatang.Name = "tbCatatanEventAkanDatang";
            this.tbCatatanEventAkanDatang.Size = new System.Drawing.Size(267, 216);
            this.tbCatatanEventAkanDatang.TabIndex = 9;
            this.tbCatatanEventAkanDatang.TextChanged += new System.EventHandler(this.tbCatatanEventAkanDatang_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 28);
            this.label10.TabIndex = 8;
            this.label10.Text = "Event akan datang:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(527, 69);
            this.label6.TabIndex = 7;
            this.label6.Text = "- Event mendatang berisi event terdekat.\r\n- Pilih satu tanggal dari kalender untu" +
    "k melihat event\r\n  tanggal tersebut.\r\n";
            // 
            // upComingEvent
            // 
            this.upComingEvent.FormattingEnabled = true;
            this.upComingEvent.ItemHeight = 30;
            this.upComingEvent.Location = new System.Drawing.Point(28, 214);
            this.upComingEvent.Name = "upComingEvent";
            this.upComingEvent.Size = new System.Drawing.Size(344, 214);
            this.upComingEvent.TabIndex = 4;
            this.upComingEvent.SelectedIndexChanged += new System.EventHandler(this.upComingEvent_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 56);
            this.label7.TabIndex = 0;
            this.label7.Text = "Beranda";
            // 
            // panelNoteManager
            // 
            this.panelNoteManager.Controls.Add(this.cbKategori);
            this.panelNoteManager.Controls.Add(this.label8);
            this.panelNoteManager.Controls.Add(this.noteList);
            this.panelNoteManager.Controls.Add(this.label9);
            this.panelNoteManager.Location = new System.Drawing.Point(249, 14);
            this.panelNoteManager.Name = "panelNoteManager";
            this.panelNoteManager.Size = new System.Drawing.Size(750, 536);
            this.panelNoteManager.TabIndex = 6;
            // 
            // cbKategori
            // 
            this.cbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Items.AddRange(new object[] {
            "Semua",
            "Kuliah",
            "Tugas",
            "Kegiatan Organisasi",
            "Kerja Kelompok",
            "Kegiatan lainnya"});
            this.cbKategori.Location = new System.Drawing.Point(396, 149);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(308, 38);
            this.cbKategori.TabIndex = 8;
            this.cbKategori.SelectedIndexChanged += new System.EventHandler(this.cbKategori_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(519, 46);
            this.label8.TabIndex = 7;
            this.label8.Text = "- Pilih kategori untuk melihat catatan yang terdapat\r\n  di kategori tersebut\r\n";
            // 
            // noteList
            // 
            this.noteList.FormattingEnabled = true;
            this.noteList.HorizontalScrollbar = true;
            this.noteList.ItemHeight = 30;
            this.noteList.Location = new System.Drawing.Point(28, 150);
            this.noteList.Name = "noteList";
            this.noteList.Size = new System.Drawing.Size(345, 334);
            this.noteList.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(363, 56);
            this.label9.TabIndex = 0;
            this.label9.Text = "Note Manager";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 68);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(128, 32);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 32);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Remind and Note It!";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1026, 573);
            this.Controls.Add(this.panelBeranda);
            this.Controls.Add(this.panelNoteManager);
            this.Controls.Add(this.panelKalender);
            this.Controls.Add(this.panelSelamatDatang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Move += new System.EventHandler(this.Form1_Move);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelSelamatDatang.ResumeLayout(false);
            this.panelSelamatDatang.PerformLayout();
            this.panelKalender.ResumeLayout(false);
            this.panelKalender.PerformLayout();
            this.panelBeranda.ResumeLayout(false);
            this.panelBeranda.PerformLayout();
            this.panelNoteManager.ResumeLayout(false);
            this.panelNoteManager.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNoteManager;
        private System.Windows.Forms.Button btnKalender;
        private System.Windows.Forms.Button btnBeranda;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSalam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelSelamatDatang;
        private System.Windows.Forms.Panel panelKalender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.MonthCalendar kalender;
        private System.Windows.Forms.ListBox eventBox;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEditEvent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelBeranda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox upComingEvent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelNoteManager;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox noteList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCatatanEventAkanDatang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
    }
}

