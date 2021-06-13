using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace NotificationReminder
{
    class EventContexttt : DbContext
    {
        public DbSet<Eventt> Events { get; set; }
    }
}
