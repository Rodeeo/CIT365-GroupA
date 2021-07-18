using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Sacramento.Models
{
    public class Plan
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Meeting Date")]
        public DateTime MeetingDate { get; set; }

        public int PresidingLeaderID { get; set; }

        [Display(Name = "Presiding")]
        public Leader PresidingLeader { get; set; }

        public int ConductingLeaderID { get; set; }

        [Display(Name = "Conducting")]
        public Leader ConductingLeader { get; set; }

        public int OpeningSongID { get; set; }

        [Display(Name = "Opening Hymn")]
        public Hymn OpeningSong { get; set; }

        [StringLength(40, MinimumLength = 1)]
        [Required]

        [Display(Name = "Opening Prayer")]
        public string OpeningPrayer { get; set; }

        public int SacramentHymnID { get; set; }

        [Display(Name = "Sacrament Hymn")]
        public Hymn SacramentHymn { get; set; }

        public int? IntermediateSongID { get; set; }

        [Display(Name = "Intermidiate Hymn")]
        public Hymn IntermediateSong { get; set; }
        public ICollection<Speaker> Enrollments { get; set; }

        public int ClosingSongID { get; set; }

        [Display(Name = "Closing Song")]
        public Hymn ClosingSong { get; set; }

        [StringLength(40, MinimumLength = 1)]
        [Required]

        [Display(Name = "Closing Prayer")]
        public string ClosingPrayer { get; set; }

    }
}