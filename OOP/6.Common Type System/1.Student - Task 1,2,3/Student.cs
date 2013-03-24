using System;


namespace _1.Student___Task_1_2_3
{
    class Student:ICloneable,IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int ssn;
        private string address;
        private string mobile;
        private string eMail;
        private int? course;
        public Specialties speciality;
        public Universities university;
        public Faculties faculty;

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string MiddleName { get { return middleName; } set { middleName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public int SSN { get { return ssn; } set { ssn = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string Mobile { get { return mobile; } set { mobile = value; } }
        public string EMail { get { return eMail; } set { eMail = value; } }
        public int? Course { get { return course; } set { course = value; } }
        

        public Student(string firstName, string middleName, string lastName, int ssn, string address, string mobile, string eMail, int? course, Specialties speciality, Universities university, Faculties faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.Mobile = mobile;
            this.EMail = eMail;
            this.Course = course;
            this.speciality = speciality;
            this.university = university;
            this.faculty = faculty;
        }
        public Student(string firstName, string middleName, string lastName, int ssn)
            : this(firstName, middleName, lastName, ssn, null, null, null, null, Specialties.Undefined, Universities.Undefined, Faculties.Undefined)
        {
        }


        public override bool Equals(object obj)
        {
            Student student = obj as Student;

            if (student == null)
            {
                return false;
            }

            if ((this.FirstName != student.FirstName)||
                (this.MiddleName != student.MiddleName)||
                (this.LastName != student.LastName)||
                (this.SSN != student.SSN))
            {
                return false;
            }

            return true;
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ MiddleName.GetHashCode() ^ LastName.GetHashCode() ^ SSN.GetHashCode();
        }


        public override string ToString()
        {
            return string.Format("Name: {0} {1} {2}\nSSN: {3},\nAddress: {4}\nMobile phone: {5}\nE-mail: {6}\nCourse: {7}\nSpecialty: {8}\nUniversity: {9}\nFaculty: {10}",
                FirstName, MiddleName, LastName, SSN, Address, Mobile, EMail, Course, speciality, university, faculty);
        }


        public Student Clone()
        {
            Student original = this;
            Student result = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address,
                this.Mobile, this.EMail, this.Course, this.speciality, this.university, this.faculty);

            return result;
        }
        Object ICloneable.Clone()
        {
            return this.Clone();
        }

        public int CompareTo(Student student)
        {
            if (this.FirstName != student.FirstName)
            {
                return (this.FirstName.CompareTo(student.FirstName));
            }
            if (this.MiddleName != student.MiddleName)
            {
                return (this.MiddleName.CompareTo(student.MiddleName));
            }
            if (this.LastName != student.LastName)
            {
                return (this.LastName.CompareTo(student.LastName));
            }
            if (this.SSN != student.SSN)
            {
                return (this.SSN - student.SSN);
            }
            return 0;
        }
    }
}
