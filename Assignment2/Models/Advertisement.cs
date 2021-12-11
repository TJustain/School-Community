using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class Advertisement
    {

        public int Id { get; set; }

        [Url]
        [Required]
        public string Url { get; set; }


        [Required]
        [DisplayName("File Name")]
        public string FileName { get; set; }


        public string CommunityId { get; set; }

        public Community Community { get; set; }

    }
}
