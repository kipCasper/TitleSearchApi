namespace TitleSearchApi.Models
{
    public class TurnerDatabaseSettings : ITurnerDatabaseSettings
    {
        public string TitleCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface ITurnerDatabaseSettings
    {
        string TitleCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}