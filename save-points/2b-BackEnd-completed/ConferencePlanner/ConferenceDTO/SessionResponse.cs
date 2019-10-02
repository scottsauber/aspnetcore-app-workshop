using System;
using System.Collections.Generic;
using System.Text;

namespace ConferenceDTO
{
    public class SessionResponse : SessionDto
    {
        public TrackDto Track { get; set; }

        public ICollection<SpeakerDto> Speakers { get; set; } = new List<SpeakerDto>();

        public ICollection<TagDto> Tags { get; set; } = new List<TagDto>();
    }
}
