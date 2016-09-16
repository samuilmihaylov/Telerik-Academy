namespace _01.StudentClass.Models
{
    using System;
    using System.Text;
    using _01.StudentClass.Enumerations;

    public class Student
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private long socialSecurityNumber;
        private string permanentAddress;
        private string mobilePhoneNumber;
        private string email;
        private int course;
        private UniversitiesType university;
        private FacultiesType faculty;
        private SpecialtiesType speciality;

        public Student(string firstName, string middleName, string lastName, long socialSecurityNumber, string permanentAddress,
             string mobilePhoneNumber, string email, int course, UniversitiesType university, FacultiesType faculty, SpecialtiesType speciality)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SocialSecurityNumber = socialSecurityNumber;
            this.Address = permanentAddress;
            this.MobilePhoneNumber = mobilePhoneNumber;
            this.Email = email;
            this.Course = course;
            this.University = university;
            this.Faculty = faculty;
            this.Speciality = speciality;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be null or empty.");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Middle name cannot be null or empty.");
                }
                else
                {
                    this.middleName = value;
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name cannot be null or empty.");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }

        public long SocialSecurityNumber
        {
            get
            {
                return this.socialSecurityNumber;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Social Security Number can not be a negative value or zero.");
                }
                else
                {
                    this.socialSecurityNumber = value;
                }
            }
        }

        public string Address
        {
            get
            {
                return this.permanentAddress;
            }
            private set
            {
                this.permanentAddress = value;
            }
        }

        public string MobilePhoneNumber
        {
            get
            {
                return this.mobilePhoneNumber;
            }
            private set
            {
                this.mobilePhoneNumber = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            private set
            {
                this.email = value;
            }
        }

        public int Course
        {
            get
            {
                return this.course;
            }
            private set
            {
                this.course = value;
            }
        }

        public UniversitiesType University
        {
            get
            {
                return this.university;
            }
            private set
            {
                this.university = value;
            }
        }

        public FacultiesType Faculty
        {
            get
            {
                return this.faculty;
            }
            private set
            {
                this.faculty = value;
            }
        }

        public SpecialtiesType Speciality
        {
            get
            {
                return this.speciality;
            }
            private set
            {
                this.speciality = value;
            }
        }

        // Methods

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendFormat("Student name: {0} {1} {2}\n", this.FirstName, this.MiddleName, this.LastName);
            result.AppendLine(new string('-', 40));
            result.AppendLine($"Social security number: {this.SocialSecurityNumber}");
            result.AppendLine(string.Format("Address: {0}", this.Address));
            result.AppendLine($"Mobile phone number: {this.MobilePhoneNumber}");
            result.AppendLine(string.Format("Email: {0}", this.Email));
            result.AppendLine($"Course: {this.Course}");
            result.AppendLine(string.Format("Speciality: ", this.Speciality));
            result.AppendLine($"University: {this.University}");
            result.AppendLine(string.Format("Faculty: {0}", this.Faculty));

            return result.ToString();
        }

        public override int GetHashCode()
        {
            return this.Address.GetHashCode() ^ this.SocialSecurityNumber.GetHashCode() * 22;
        }

        public override bool Equals(object obj)
        {
            var equalStudent = obj as Student;

            if (equalStudent == null)
            {
                return false;
            }
            if (this.FirstName != equalStudent.FirstName)
            {
                return false;
            }
            if (this.MiddleName != equalStudent.MiddleName)
            {
                return false;
            }
            if (this.LastName != equalStudent.LastName)
            {
                return false;
            }
            if (this.SocialSecurityNumber != equalStudent.SocialSecurityNumber)
            {
                return false;
            }
            if (this.Address != equalStudent.Address)
            {
                return false;
            }
            if (this.MobilePhoneNumber != equalStudent.MobilePhoneNumber)
            {
                return false;
            }
            if (this.Email != equalStudent.Email)
            {
                return false;
            }
            if (this.Course != equalStudent.Course)
            {
                return false;
            }
            if (this.University != equalStudent.University)
            {
                return false;
            }
            if (this.Faculty != equalStudent.Faculty)
            {
                return false;
            }
            if (this.Speciality != equalStudent.Speciality)
            {
                return false;
            }
            return true;
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !Student.Equals(firstStudent, secondStudent);
        }

        // Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.

        public object Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SocialSecurityNumber, this.Address, this.MobilePhoneNumber,
            this.Email, this.Course, this.University, this.Faculty, this.Speciality);
        }

        // Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).

        public int CompareTo(object obj)
        {
            var otherStudent = obj as Student;

            string studentFullName = this.FirstName + this.MiddleName + this.LastName;
            string otherFullName = otherStudent.FirstName + otherStudent.MiddleName + otherStudent.LastName;

            if (studentFullName.CompareTo(otherFullName) < 0)
            {
                return -1;
            }
            if (studentFullName.CompareTo(otherFullName) > 0)
            {
                return 1;
            }
            if (studentFullName.CompareTo(otherFullName) == 0)
            {
                if (this.SocialSecurityNumber < otherStudent.SocialSecurityNumber)
                {
                    return -1;
                }
                if (this.SocialSecurityNumber > otherStudent.SocialSecurityNumber)
                {
                    return 1;
                }
                if (this.SocialSecurityNumber == otherStudent.SocialSecurityNumber)
                {
                    return 0;
                }
            }
            return 0;
        }
    }
}
