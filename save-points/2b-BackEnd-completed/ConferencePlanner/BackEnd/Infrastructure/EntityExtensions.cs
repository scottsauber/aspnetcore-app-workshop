using BackEnd.Data;
using ConferenceDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BackEnd.Data
{
    public static class EntityExtensions
    {
        public static SessionResponse MapSessionResponse(this Session session) =>
            new SessionResponse
            {
                ID = session.ID,
                Title = session.Title,
                StartTime = session.StartTime,
                EndTime = session.EndTime,
                Tags = session.SessionTags?
                              .Select(st => new TagDto
                              {
                                  ID = st.TagID,
                                  Name = st.Tag.Name
                              })
                               .ToList(),
                Speakers = session.SessionSpeakers?
                                  .Select(ss => new SpeakerDto
                                  {
                                      ID = ss.SpeakerId,
                                      Name = ss.Speaker.Name
                                  })
                                   .ToList(),
                TrackId = session.TrackId,
                Track = new TrackDto
                {
                    TrackID = session?.TrackId ?? 0,
                    Name = session.Track?.Name
                },
                ConferenceID = session.ConferenceID,
                Abstract = session.Abstract
            };

        public static SpeakerResponse MapSpeakerResponse(this Speaker speaker) =>
            new SpeakerResponse
            {
                ID = speaker.ID,
                Name = speaker.Name,
                Bio = speaker.Bio,
                WebSite = speaker.WebSite,
                Sessions = speaker.SessionSpeakers?
                    .Select(ss =>
                        new SessionDto
                        {
                            ID = ss.SessionId,
                            Title = ss.Session.Title
                        })
                    .ToList()
            };

        public static AttendeeResponse MapAttendeeResponse(this Attendee attendee) =>
            new AttendeeResponse
            {
                ID = attendee.ID,
                FirstName = attendee.FirstName,
                LastName = attendee.LastName,
                UserName = attendee.UserName,
                Sessions = attendee.SessionsAttendees?
                    .Select(s =>
                        new SessionDto
                        {
                            ID = s.SessionID,
                            Title = s.Session.Title,
                            StartTime = s.Session.StartTime,
                            EndTime = s.Session.EndTime
                        })
                    .ToList(),
                Conferences = attendee.ConferenceAttendees?
                    .Select(ca =>
                        new ConferenceDto
                        {
                            ID = ca.ConferenceID,
                            Name = ca.Conference.Name
                        })
                    .ToList(),
            };
    }
}