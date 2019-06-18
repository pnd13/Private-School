using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject2.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Stream { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Trainer> Trainers { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Title} , {Stream},  {Type} , {StartDate}, {EndDate}";
        }
    }
}
