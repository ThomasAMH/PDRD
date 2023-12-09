using System.ComponentModel.DataAnnotations;

namespace PDRD.Models
{
    public class Hymn
    {

        public int HymnID { get; set; }
        [Display(Name = "Hymn Number")]
        public int HymnNumber { get; set; }
        [Display(Name = "Hymn Name")]
        public string HymnName { get; set;}
    }
}
