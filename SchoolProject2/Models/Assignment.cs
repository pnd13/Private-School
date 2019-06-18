using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject2.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubmissionDateAndTime { get; set; }
        public int OralMark { get; set; }
        public int TotalMark { get; set; }

        //public virtual Course Course { get; set; }

        //public virtual ICollection<Student> Students { get; set; }
        //public virtual ICollection<Trainer> Trainers { get; set; }
        public virtual ICollection<Course> Courses { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Title}, {Description},  {SubmissionDateAndTime} , {OralMark} , {TotalMark} ";
        }
    }
}
