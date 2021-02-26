using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackWeb.Models
{
    public class DemoIdentityUser : IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }
        
        [PersonalData]
        public string LastName { get; set; }
        
        [PersonalData]
        public DateTime? DateOfBirth { get; set; }
    }
}
