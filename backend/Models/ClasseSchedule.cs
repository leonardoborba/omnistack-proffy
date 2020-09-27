using System;
namespace backend.Models
{
    public class ClasseSchedule
    {
        public int id { get; set; }
        public string week_day { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string class_id { get; set; }
    }
}
