using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace One.Models
{
    public class Coffee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DisplayFormat(DataFormatString = "{0:C0}", ApplyFormatInEditMode = true)]
        public float? Price { get; set; }
        public string Weight { get; set; }
        public string Description { get; set; }
        public string RoastLevel { get; set; }
        public string Taste { get; set; }
        public string Img { get; set; }
        [DataType(DataType.Date)]
        public DateTime RoastDate { get; set; }
    }
}
