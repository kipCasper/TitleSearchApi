using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TitleSearchApi.Models
{
    // [DataContract][Serializable]
    // [BsonIgnoreExtraElements]
    public class Participant
    {
        public bool IsKey { get; set; }
        public Int32 ParticipantId { get; set;}
        public string RoleType { get; set; }
        public bool IsOnScreen { get; set; }
        public string ParticipantType { get; set; }
        public string Name { get; set;}

        public int SortOrder { get; set; }
    }
}