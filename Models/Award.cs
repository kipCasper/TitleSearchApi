using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TitleSearchApi.Models
{
    [DataContract][Serializable]
    [BsonIgnoreExtraElements]
    public class Award
    {
        public int AwardYear { get; set;}
        public string AwardCompany { get; set;}
        public bool AwardWon { get; set; }
    }
}