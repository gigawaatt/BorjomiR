using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Borjomi.Data.Models
{
    public class Staff
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? birth_date { get; set; }
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime bdate { get; set; }
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? edate { get; set; }
        public bool is_active { get; set; }
        public DateTime create_date { get; set; }

        public Staff()
        {
            this.id = id;
            this.first_name = first_name;
            this.middle_name = middle_name;
            this.last_name = last_name;
            this.birth_date = birth_date;
            this.bdate = bdate;
            this.edate = edate;
            this.is_active = is_active;
            this.create_date = DateTime.UtcNow;
        }
    }




}
