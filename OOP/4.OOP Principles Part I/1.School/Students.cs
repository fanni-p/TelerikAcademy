using System;

namespace _1.School
{
    class Students :Human,ICommentable
    {
        private int classNumber;
        public int ClassNumber { get { return classNumber; } set { classNumber = value; } }

        public Students(string name, int classNumber)
            :base(name)
        {
            this.ClassNumber = classNumber;
        }

        public string Comment
        {
            get { return this.Comment; }
            set { Comment = value; }
        }
    }
}
