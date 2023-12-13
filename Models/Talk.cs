using System.ComponentModel.DataAnnotations.Schema;
namespace PDRD.Models
{
    public class Talk
    {
        public int TalkID { get; set; }
        public int? AgendaID { get; set; }
        public Agenda? Agenda { get; set; }
        public int? PersonID { get; set; }
        public string? Topic { get; set; }
        public Person? Person { get; set; }  
    }
}
