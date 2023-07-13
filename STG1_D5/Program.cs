namespace STG1_D5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student information");
            Student2 student = new Student2();
           
           
            Console.WriteLine(student.PrintAsString());

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Enter number of students");
            int size = int.Parse(Console.ReadLine());
            Student2[] students = new Student2[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter student{i + 1} information");
                students[i] = new Student2();
               

            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Student{i + 1}");
                Console.WriteLine(students[i].PrintAsString());
            }

        }
        
    }
}