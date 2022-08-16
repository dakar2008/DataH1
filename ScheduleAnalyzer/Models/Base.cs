namespace ScheduleAnalyzer.Models
{
    public abstract class Base
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }

        public Base()
        {
            Created = DateTime.Now;
        }
    }
}