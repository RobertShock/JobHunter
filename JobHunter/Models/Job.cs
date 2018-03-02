
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobHunter.Models
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }

        [Required]
        public int BusinessId { get; set; }
        public Business Business { get; set; }

        [Required]
        public int ApiId { get; set; }

        [Required]
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }

        [Required]
        [Display(Name = "Job Location")]
        public string JobLocation { get; set; }

        [Required]
        [Display(Name = "Type")]
        public string Type { get; set; }

        [Required]
        [Display(Name = "Job Post")]
        public string JobUrl { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        public bool Applied { get; set; }

        public Job()
        {
            this.Applied = false;
        }
    }
}