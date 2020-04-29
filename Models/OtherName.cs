using MongoDB.Bson.Serialization.Attributes;

namespace TitleSearchApi.Models
{
    public class OtherName
    {
        public int Id;
        public int TitleId;
        
        public string TitleNameLanguage;
        public string TitleNameType;
        public string TitleNameSortable;
        public string TitleName;
    }
}