using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SchoolWebProject.Domain.Models
{
    class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }

    }
}
