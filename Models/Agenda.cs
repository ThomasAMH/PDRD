using System.ComponentModel.DataAnnotations;

namespace PDRD.Models
{
    public class Agenda
    {
        public int AgendaID { get; set; }
        [Display(Name = "Meeting Date")]
        [DataType(DataType.Date)]
        public DateTime MeetingDate { get; set; }
        public int? OpeningHymnID { get; set; }
        [Display(Name = "Opening Hymn")]
        public Hymn? OpeningHymn { get; set; }

        [Display(Name = "Sacrament Hymn")]
        public int? SacramentHymnID { get; set; }
        public Hymn? SacramentHymn { get; set; }

        public int? IntermediateHymnID { get; set; }
        [Display(Name = "Intermediate Hymn")]
        public Hymn? IntermediateHymn { get; set; }

        [Display(Name = "Special Musical Number Details")]
        public string? SpecialMusicalNumber { get; set; }

        public int? ClosingHymnID { get; set; }
        [Display(Name = "Closing Hymn")]
        public Hymn? ClosingHymn { get; set; }
        public Person? PresidingPerson { get; set; }
        [Display(Name = "Presiding Authority")]
        public int? PresidingPersonID { get; set; }
        public Person? ConductingPerson { get; set; }
        [Display(Name = "Conducting")]
        public int? ConductingPersonID { get; set; }
        public Person? OpeningPrayerPerson { get; set; }
        [Display(Name = "Opening Prayer Person")]
        public int? OpeningPrayerPersonID { get; set; }
        public Person? ClosingPrayerPerson { get; set; }
        [Display(Name = "Closing Prayer Person")]
        public int? ClosingPrayerPersonID { get; set; }
        [Display(Name = "Talks")]
        public List<Talk>? Talks { get; set; }
        [Display(Name = "Non-Speaker Program Item")]
        public string? NonSpeakerProgram { get; set; }
    }

}


