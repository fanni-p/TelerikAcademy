using System;

namespace _1.School
{
    class Subjects:Name,ICommentable
    {
        private int lessonCount;
        private int exerciseCount;

        public int LessonCount { get { return lessonCount; } set { lessonCount = value; } }
        public int ExerciseCount { get { return exerciseCount; } set { exerciseCount = value; } }

        public Subjects(string name, int lessonCount, int exerciseCount)
            :base(name)
        {
            this.LessonCount = lessonCount;
            this.exerciseCount = exerciseCount;
        }

        public string Comment
        {
            get { return this.Comment; }
            set { Comment = value; }
        }
    }
}
