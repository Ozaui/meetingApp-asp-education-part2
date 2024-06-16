using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace meetingApp_asp_education_part2.Models
{
    public class MeetingInfo
    {
        public int Id { get; set; }
        public string? Location { get; set; }
        public DateTime DateTime { get; set; }
        public int NumberofPeople { get; set; }
    }
}