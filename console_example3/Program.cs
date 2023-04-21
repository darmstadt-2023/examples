// See https://aka.ms/new-console-template for more information
using console_example3;

Console.WriteLine("Hello, World!");

Student objectStudent=new Student();
//objectStudent.BirthYear=1999;
//objectStudent.Fname="Jim";
Console.WriteLine("Give the firstname of student");
objectStudent.Fname= Console.ReadLine();
Console.WriteLine("Give the birthyear of student");
//objectStudent.BirthYear= int.Parse(Console.ReadLine());

/*string byear=Console.ReadLine();
int a;
int.TryParse(byear, out a);
objectStudent.BirthYear=a;*/

try
{
    objectStudent.BirthYear= int.Parse(Console.ReadLine());
}
catch (System.Exception ex)
{
    
    Console.WriteLine(ex.Message);
}

objectStudent.Lname="Smith";

Teacher objectTeacher=new Teacher();
objectTeacher.BirthYear=1975;

objectStudent.SayAge(objectStudent.BirthYear);
objectStudent.SayName(objectStudent.Fname+" "+objectStudent.Lname);