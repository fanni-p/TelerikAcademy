using System;
using System.Collections.Generic;

namespace _1.School
{
    class Teachers:Human,ICommentable
    {
        List<Subjects> subjects = new List<Subjects>();

        public Teachers(string name) : base(name) { }
        public Teachers(string name,Subjects subject)
            : base(name)
        {
            this.subjects.Add(subject);
        }

        public string Comment
        {
            get { return this.Comment; }
            set { Comment = value; }
        }
    }
}
