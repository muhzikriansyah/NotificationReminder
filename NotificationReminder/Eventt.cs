using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NotificationReminder
{
    class Eventt
    {
        [Key]
        public int ID { get; set; }
        public string kategoriEvent { get; set; }
        public string namaEvent { get; set; }
        public DateTime tanggalEvent { get; set; }
        public DateTime waktuEvent { get; set; }
        public string catatanEvent { get; set; }
    }
}
