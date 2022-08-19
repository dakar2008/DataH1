namespace ScheduleAnalyzer.Models.SA_Models
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? LastUpdated { get; set; }

        public BaseModel()
        {
            Created = DateTime.Now;
        }
    }
}