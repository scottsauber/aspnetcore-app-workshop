using System;
using System.Collections.Generic;
using System.Text;

namespace ConferenceDTO
{
    public class AttendeeResponse : AttendeeDto
    {
        public ICollection<Conference> Conferences { get; set; } = new List<Conference>();

        public ICollection<Session> Sessions { get; set; } = new List<Session>();
    }
}
