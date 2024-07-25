using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task4MVC.Models
{
    public class ContactUsViewModel
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Message { get; set; }

        public List<ContactUsViewModel> Submissions { get; set; }
    }

}