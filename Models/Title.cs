using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TitleSearchApi.Models
{
    [DataContract][Serializable]
    [BsonIgnoreExtraElements]
    public class Title
    {
        public string Id { get; set; }
        public int TitleId { get; set; }
        public string TitleName { get; set; }
        public string TitleNameSortable { get; set; }
        public int ReleaseYear { get; set; }
        public DateTime ProcessedDatetimeUTC { get; set; }

        public Award[] Awards { get; set; }

        public string[] Genres { get; set; }

        public Participant[] Participants { get; set; }

        public StoryLine[] Storylines { get; set; }
    }
}