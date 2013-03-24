using System;
using System.Collections.Generic;

namespace _1.School
{
    class Classes:ICommentable
    {
        private string id;
        public string Id { get { return id; } set { id = value; } }

        List<Teachers> teachers = new List<Teachers>();
        List<Students> students = new List<Students>();

        public Classes(string id)
        {
            this.Id = id;
        }
        public Classes(string id, Teachers teacher)
        {
            this.Id = id;
            this.teachers.Add(teacher);
        }
        public Classes(string id, Students student)
        {
            this.Id = id;
            this.students.Add(student);
        }

        public string Comment
        {
            get { return this.Comment; }
            set { Comment = value; }
        }
    }
}
