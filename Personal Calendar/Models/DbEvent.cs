using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Calendar.Models
{
    [Table("Events")]
    public class DbEvent
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Location { get; set; }
        public int Priority { get; set; }

        public override string ToString()
        {
            return $"{this.Title} : {this.StartTime.ToString("g")} - {this.EndTime.ToString("g")}";
        }
    }
}
