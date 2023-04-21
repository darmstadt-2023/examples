namespace console_example3
{
    public class Student: Person, IPerson
    {
        public string Group { get; set; }

        public void SayAge(int value)
        {
            int age=2023-value;
            Console.WriteLine("I am "+age+" years old");
        }

        public void SayName(string value)
        {
            Console.WriteLine("I am a student: "+value);
        }
    }
}