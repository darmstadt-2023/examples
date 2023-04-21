namespace console_example3
{
    public class Teacher:Person, IPerson
    {
        public string Subject { get; set; }

        public void SayName(string value)
        {
            Console.WriteLine("I am a teacher: "+value);
        }
             public void SayAge(int value)
        {
            int age=2023-value;
            Console.WriteLine("I am "+age+" years old");
        }
    }
}