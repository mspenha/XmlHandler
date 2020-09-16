namespace XmlHandler
{
    public class Student
    {
        private string name;
        private int grade;

        public Student(string name, int grade)
        {
            this.name = name;
            this.grade = grade;
        }

        public Student()
        {
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public override string ToString()
        {
            // String representation.
            return this.name + ", " + this.grade;
        }
    }
}
