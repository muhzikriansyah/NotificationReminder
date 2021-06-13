using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotificationReminder
{
    public partial class Form1 : Form
    {
        System.Timers.Timer timer;
        internal static Form1 form1;
        internal static Form2 form2;
        
        public Form1()
        {
            InitializeComponent();
            panelBeranda.Visible = false;
            panelKalender.Visible = false;
            panelNoteManager.Visible = false;
            var jamSekarang = DateTime.Now.Hour;
            if (jamSekarang < 10 && jamSekarang > 0)
            {
                lblSalam.Text = "Selamat Pagi!";
            }
            else if(jamSekarang < 14 && jamSekarang > 10)
            {
                lblSalam.Text = "Selamat Siang!";
            }
            else if (jamSekarang < 18 && jamSekarang > 14)
            {
                lblSalam.Text = "Selamat Sore!";
            }
            else
            {
                lblSalam.Text = "Selamat Malam!";
            }
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            panelSelamatDatang.Visible = false;
            panelKalender.Visible = false;
            panelNoteManager.Visible = false;
            panelBeranda.Visible = true;
            btnNoteManager.BackColor = Color.FromArgb(41, 44, 51);
            btnKalender.BackColor = Color.FromArgb(41, 44, 51);
            btnBeranda.BackColor = Color.FromArgb(62, 120, 138);
            cariEventAkanDatang();
        }

        private void btnKalender_Click(object sender, EventArgs e)
        {
            panelSelamatDatang.Visible = false;
            panelBeranda.Visible = false;
            panelNoteManager.Visible = false;
            panelKalender.Visible = true;
            btnNoteManager.BackColor = Color.FromArgb(41, 44, 51);
            btnBeranda.BackColor = Color.FromArgb(41, 44, 51);
            btnKalender.BackColor = Color.FromArgb(62, 120, 138);
            cariEvent();
            tbCatatanEventAkanDatang.Text = "";
        }

        private void btnNoteManager_Click(object sender, EventArgs e)
        {
            panelSelamatDatang.Visible = false;
            panelBeranda.Visible = false;
            panelKalender.Visible = false;
            panelNoteManager.Visible = true;
            btnBeranda.BackColor = Color.FromArgb(41, 44, 51);
            btnKalender.BackColor = Color.FromArgb(41, 44, 51);
            btnNoteManager.BackColor = Color.FromArgb(62, 120, 138);
            cbKategori.SelectedItem = "Semua";
            cariSemuaCatatan();
        }

        public void cariEvent()
        {
            eventBox.Items.Clear();
            using (var context = new EventContexttt())
            {
                var eventList = (from eventt in context.Events where eventt.tanggalEvent == kalender.SelectionStart select eventt).ToList<Eventt>();
                foreach (var item in eventList)
                {
                    eventBox.Items.Add(item.namaEvent);
                }
            }
            if (eventBox.Items.Count == 0)
            {
                eventBox.Items.Add("Tidak ada event pada " + kalender.SelectionStart.ToString("dd-M-yyyy"));
            }
        }

        public void cariEventAkanDatang()
        {
            upComingEvent.Items.Clear();
            using (var context = new EventContexttt())
            {
                DateTime besok = DateTime.Today.AddDays(1);
                var eventList = (from eventt in context.Events where eventt.tanggalEvent == besok select eventt).ToList<Eventt>();
                foreach (var item in eventList)
                {
                    upComingEvent.Items.Add(item.namaEvent);
                }
            }
            if (upComingEvent.Items.Count == 0)
            {
                upComingEvent.Items.Add("Tidak ada event yang akan datang");
            }
        }

        private void kalender_DateChanged(object sender, DateRangeEventArgs e)
        {
            cariEvent();
            if (kalender.SelectionStart <= DateTime.Today)
            {
                btnEditEvent.Enabled = false;
                btnTambah.Enabled = false;
            }
            else
            {
                btnEditEvent.Enabled = true;
                btnTambah.Enabled = true;
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            form2 = new Form2(kalender.SelectionStart);
            form2.FormClosing += new FormClosingEventHandler(this.Form2_FormClosing);
            form2.ShowDialog();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            cariEvent();
        }

        private void btnEditEvent_Click(object sender, EventArgs e)
        {
            string selected = eventBox.GetItemText(eventBox.SelectedItem);
            if (eventBox.SelectedItem == null || selected.Contains("Tidak ada event") == true)
            {
                MessageBox.Show("Tidak ada event valid yang dipilih");
            }
            else
            {
                Form2 form2 = new Form2(eventBox.GetItemText(eventBox.SelectedItem));
                form2.FormClosing += new FormClosingEventHandler(this.Form2_FormClosing);
                form2.ShowDialog();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string selected = eventBox.GetItemText(eventBox.SelectedItem);
            if (eventBox.SelectedItem == null || selected.Contains("Tidak ada event") == true)
            {
                MessageBox.Show("Tidak ada event valid yang dipilih");
            }
            else
            {
                using (var context = new EventContexttt())
                {
                    string nama = eventBox.GetItemText(eventBox.SelectedItem);
                    context.Events.RemoveRange(context.Events.Where(item => item.namaEvent == nama));
                    context.SaveChanges();
                    cariEvent();
                }
            }
        }

        private void cariCatatan()
        {
            string kategori = cbKategori.GetItemText(cbKategori.SelectedItem);
            noteList.Items.Clear();
            using (var context = new EventContexttt())
            {

                var eventList = (from eventt in context.Events where eventt.kategoriEvent == kategori select eventt).ToList<Eventt>();
                foreach (var item in eventList)
                {
                    noteList.Items.Add(item.catatanEvent + " -- (dari event\'" + item.namaEvent + "\')");
                }
            }
            if (noteList.Items.Count == 0)
            {
                noteList.Items.Add("Tidak ada catatan pada kategori \"" + kategori + "\"");
            }
        }

        private void cariSemuaCatatan()
        {
            noteList.Items.Clear();
            using (var context = new EventContexttt())
            {

                var eventList = (from eventt in context.Events select eventt).ToList<Eventt>();
                foreach (var item in eventList)
                {
                    noteList.Items.Add(item.catatanEvent + " -- (dari event \'" + item.namaEvent + "\')");
                }
            }
            if (noteList.Items.Count == 0)
            {
                noteList.Items.Add("Tidak ada catatan");
            }
        }

        private void cbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKategori.GetItemText(cbKategori.SelectedItem) == "Semua")
            {
                cariSemuaCatatan();
            }
            else
            {
                cariCatatan();
            }
        }

        private void upComingEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            cariEventAkanDatang();
        }

        private void cariCatatanAkanDatang()
        {
            string terpilih = upComingEvent.GetItemText(upComingEvent.SelectedItem);
            using (var context = new EventContexttt())
            {
                
                var eventList = (from eventt in context.Events where eventt.namaEvent == terpilih select eventt).ToList<Eventt>();
                foreach (var item in eventList)
                {
                    tbCatatanEventAkanDatang.Text = item.catatanEvent;
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbCatatanEventAkanDatang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
