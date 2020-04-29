using MongoDB.Bson.Serialization.Attributes;

namespace TitleSearchApi.Models
{
    public class StoryLine
    {
        public string Description { get; set; }
        public string Type { get; set; }
        public string Language { get; set; }
    }
}