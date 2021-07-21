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

        [Display(Name = "Presiding")]
        public int PresidingLeaderID { get; set; }
        public Leader PresidingLeader { get; set; }

        [Display(Name = "Conducting")]
        public int ConductingLeaderID { get; set; }
        public Leader ConductingLeader { get; set; }

        [Display(Name = "Opening Hymn")]
        public int OpeningSongID { get; set; }
        public Hymn OpeningSong { get; set; }

        [StringLength(40, MinimumLength = 1)]
        [Required]

        [Display(Name = "Opening Prayer")]
        public string OpeningPrayer { get; set; }

        [Display(Name = "Sacrament Hymn")]
        public int SacramentHymnID { get; set; }
        public Hymn SacramentHymn { get; set; }

        [Display(Name = "Intermidiate Hymn")]
        public int? IntermediateSongID { get; set; }
        public Hymn IntermediateSong { get; set; }
        public List<Speaker> Speakers { get; set; }

        [Display(Name = "Closing Song")]
        public int ClosingSongID { get; set; }
        public Hymn ClosingSong { get; set; }

        [StringLength(40, MinimumLength = 1)]
        [Required]

        [Display(Name = "Closing Prayer")]
        public string ClosingPrayer { get; set; }

    }
}