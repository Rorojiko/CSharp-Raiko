namespace _053501_Raiko_Lab10.Main
{
    public class Employee
    {
        public string Name;
        public int Age;
        public bool HigherEducation;

        public Employee(string name, int age, bool higherEducation)
        {
            this.Name = name;
            this.Age = age;
            this.HigherEducation = higherEducation;
        }

        public string Info()
        {
            string info = $"\nName: {this.Name}\nAge: {this.Age}\nHigher Education): ";
            if (this.HigherEducation)
                info += "Yes\n";
            else
                info += "No\n";
            info += "-----------------------------------";
            return info;
        }
    }
}