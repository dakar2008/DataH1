using System.ComponentModel.DataAnnotations;

namespace ScheduleAnalyzer.Models.SA_Models
{
    public class Subject : BaseModel
    {
        public string Name { get; set; }
        public string OutlookName { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
    }
}