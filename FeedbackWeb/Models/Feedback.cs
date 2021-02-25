using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackWeb.Models
{
    public class Feedback
    {
        public int Id { get; set; }

        public DateTime Time { get; set; }

        public string NickName { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        // Constructor
        public Feedback()
        {

        }
    }
}
