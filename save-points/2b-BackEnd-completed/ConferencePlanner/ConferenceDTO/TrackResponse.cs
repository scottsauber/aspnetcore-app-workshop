using System;
using System.Collections.Generic;
using System.Text;

namespace ConferenceDTO
{
    public class TrackResponse : TrackDto
    {
        public ConferenceDto Conference { get; set; }

        public ICollection<SessionDto> Sessions { get; set; } = new List<SessionDto>();
    }
}
