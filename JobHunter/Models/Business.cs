using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobHunter.Models
{
    public class Business
    {
        [Key]
        public int BusinessId { get; set; }

        [Required]
        [Display(Name = "Business")]
        public string BusinessName { get; set; }

        [Required]
        public int ApiId { get; set; }

        [Required]
        public string BusinessLogoUrl { get; set; }

        [Required]
        public string BusinessUrl { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }
    }
}