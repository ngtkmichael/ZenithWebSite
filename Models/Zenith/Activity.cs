using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZenithWebSite.Models.Zenith
{
    public class Activity
    {
        [Key]
        [Required]
        [Display(Name = "Activity ID")]
        public int ActivityId { get; set; }

        [MaxLength(30)]
        [Required]
        [Display(Name = "Activity Code")]
        public string ActivityCode { get; set; }

        [Required]
        [Display(Name = "Activity Description")]
        [StringLength(40, ErrorMessage = "The {0} must be between {2} and {1} characters.", MinimumLength = 5)]
        public string ActivityDescription { get; set; }

        [Display(Name = "Creation Date")]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Events")]
        public List<Event> Events { get; set; }
    }
}
