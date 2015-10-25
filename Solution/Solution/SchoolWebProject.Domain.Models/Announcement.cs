using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolWebProject.Domain.Models
{
    class Announcement
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Message { get; set; }
        public string MessageDetails { get; set; }
                
        public int UserId { get; set; }
        public User User { get; set; }

        public int SchoolId { get; set; }
        public School School { get; set; }
    }
}
