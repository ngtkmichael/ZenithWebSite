using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ZenithWebSite.Models.Zenith
{
    public class Event
    {
        [Key]
        [Required]
        [Display(Name = "Event ID")]
        public int EventId { get; set; }

        [Required]
        [Display(Name = "Event Date & Event Start Time")]
        [BeforeEndDate(startDatePropertyName = "EventFromDatetime", endDatePropertyName = "EventToDatetime")]
        public DateTime EventFromDatetime { get; set; }

        [Required]
        [Display(Name = "Event Date & Event End Time")]
        public DateTime EventToDatetime { get; set; }

        [MaxLength(256)]
        [Display(Name = "Creation Username")]
        public string CreationUsername { get; set; }

        [Display(Name = "Creation Date")]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Is Active")]
        public Boolean IsActive { get; set; }

        [Required]
        [Display(Name = "Activity Description")]
        public int ActivityId { get; set; }

        [Display(Name = "Activity Name")]
        public Activity Activity { get; set; }

      
    }
}
