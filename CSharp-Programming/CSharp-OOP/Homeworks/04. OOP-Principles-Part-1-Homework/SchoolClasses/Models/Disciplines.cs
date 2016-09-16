using SchoolClasses.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses.Models
{
    public class Disciplines
    {
        //Disciplines have a name, number of lectures and number of exercises. 

        private DisciplinesType disciplineName;
        private int numberOfLectures;
        private int numberOfExercices;

        public Disciplines(DisciplinesType disciplineName, int numberOfLectures, int numberOfExercices)
        {
            this.DisciplineName = disciplineName;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercices = numberOfExercices;
        }

        public DisciplinesType DisciplineName
        {
            get
            {
                return this.disciplineName;
            }
            set
            {
                this.disciplineName = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercices
        {
            get
            {
                return this.numberOfExercices;
            }
            set
            {
                this.numberOfExercices = value;
            }
        }

        public override string ToString()
        {
            return $"{ this.disciplineName + " " + this.NumberOfLectures + " " + this.NumberOfExercices}";
        }
    }
}
