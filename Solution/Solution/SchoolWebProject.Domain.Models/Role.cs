using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolWebProject.Domain.Models
{
    class Role
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
