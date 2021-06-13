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
    public partial class Form2 : Form
    {
        public enum Mode { Insert, Edit }

        Mode mode;
        Eventt eventtt = new Eventt();

        public Form2(DateTime tanggal)
        {
            InitializeComponent();
            mode = Mode.Insert;
            btnTambahEvent.Text = "Tambah";
            cbKategori.SelectedItem = "Kuliah";
            tbTanggal.Text = tanggal.ToString("dd-M-yyyy");
        }

        public Form2(string nama)
        {

            InitializeComponent();
            mode = Mode.Edit;
            btnTambahEvent.Text = "Edit";

            using (var db = new EventContexttt())
            {
                var query = from eventt in db.Events where eventt.namaEvent == nama select eventt;

                foreach (var item in query)
                {
                    tbNamaEvent.Text = item.namaEvent;
                    eventtt.namaEvent = item.namaEvent;
                    tbCatatan.Text = item.catatanEvent;
                    tbTanggal.Text = item.tanggalEvent.ToString("dd-M-yyyy");
                    cbKategori.SelectedItem = item.kategoriEvent;
                    dtpJam.Value = item.waktuEvent;
                }
            }
        }

        private void tambahData()
        {
            Random rd = new Random();
            try
            {
                if (tbNamaEvent.Text != "")
                {
                    using (var context = new EventContexttt())
                    {
                        var newEvent = new Eventt
                        {
                            ID = rd.Next(0, 10000),
                            tanggalEvent = Convert.ToDateTime(tbTanggal.Text),
                            waktuEvent = dtpJam.Value,
                            namaEvent = tbNamaEvent.Text,
                            catatanEvent = tbCatatan.Text,
                            kategoriEvent = cbKategori.GetItemText(cbKategori.SelectedItem)
                        };
                        context.Events.Add(newEvent);
                        context.SaveChanges();
                    }
                    MessageBox.Show("Event ditambahkan");
                    Close();
                }
                else
                {
                    MessageBox.Show("Nama Event harus ada");
                }

            }
            catch
            {
                MessageBox.Show("Event gagal ditambahkan");
                Close();
            }
        }

        public void editData()
        {
            using (var context = new EventContexttt())
            {
                var result = context.Events.SingleOrDefault(e => e.namaEvent == eventtt.namaEvent);
                if (result != null)
                {
                    if (tbNamaEvent.Text != "")
                    {
                        result.tanggalEvent = Convert.ToDateTime(tbTanggal.Text);
                        result.waktuEvent = dtpJam.Value;
                        result.namaEvent = tbNamaEvent.Text;
                        result.catatanEvent = tbCatatan.Text;
                        result.kategoriEvent = cbKategori.GetItemText(cbKategori.SelectedItem);
                        context.SaveChanges();
                        MessageBox.Show("Event diedit");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Nama Event harus ada");
                    }
                    //Form1.form1.mulaiTimer();
                }
            }
        }

        private void btnTambahEvent_Click(object sender, EventArgs e)
        {
            if (mode == Mode.Insert)
            {
                tambahData();
            }
            else if (mode == Mode.Edit)
            {
                editData();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbTanggal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
