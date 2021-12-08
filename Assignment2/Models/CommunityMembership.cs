using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class CommunityMembership
    {
        public int StudentId { get; set; }

        public Student Student { get; set; }

        public string CommunityId { get; set; }

        public Community Community { get; set; }

    }
}
