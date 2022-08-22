using System.ComponentModel.DataAnnotations;

namespace ScheduleAnalyzer.Models.SA_Models
{
    public class Class : BaseModel
    {
        public string Name { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}