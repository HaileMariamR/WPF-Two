using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWD.Models
{
    public class MeetingModel
    {
        public int Id { get; set; }
        public string? Room { get; set; }
        public string? Doctor {  get; set; }
        public string? MeetingTime { get; set; }
    }
}
