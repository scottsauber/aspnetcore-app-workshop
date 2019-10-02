using System;
using System.Collections.Generic;
using System.Text;

namespace ConferenceDTO
{
    public class AttendeeResponse : AttendeeDto
    {
        public ICollection<ConferenceDto> Conferences { get; set; } = new List<ConferenceDto>();

        public ICollection<SessionDto> Sessions { get; set; } = new List<SessionDto>();
    }
}
