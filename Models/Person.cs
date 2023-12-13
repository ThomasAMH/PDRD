using System.ComponentModel.DataAnnotations;

namespace PDRD.Models
{
    public enum Prefix
    {
        Brother,
        Sister,
        Bishop,
        Elder,
        President
    }
    public class Person
    {
        public int PersonID { get; set; }
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }
        [Display(Name = "Prefix / Title")]
        public Prefix PersonPrefix { get; set; }
        public List<Talk>? Talks { get; set;}

    }
}
