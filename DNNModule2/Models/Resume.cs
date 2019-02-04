using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chris.Modules.DNNModule2.Models
{
    public class Resume
    {
        public int ResumeId { get; set; } = -1;

        public string ResumeName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int Zip { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }



    }
}