namespace Students
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Students> student = new List<Students>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);

                Students students = new Students()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Grade = grade
                };

                student.Add(students);
            }

            foreach (Students students in student.OrderByDescending(student => student.Grade))
            {
                Console.WriteLine($"{students.FirstName} {students.LastName}: {students.Grade:F2}");
            }
        }
    }
}
