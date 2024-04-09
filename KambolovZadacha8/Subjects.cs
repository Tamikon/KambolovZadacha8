using System.Collections.Generic;

namespace KambolovZadacha8.Models
{
    public class SubjectViewModel
    {
        public List<Subject> Subjects { get; set; }
        public SubjectViewModel()
        {
            Subjects = new List<Subject>();
        }
    }
}
