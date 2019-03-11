using System;

namespace Mankind
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string[] studenInfo = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string studentFirstName = studenInfo[0];
                string studentLastName = studenInfo[1];
                string facNum = studenInfo[2];

                Student student = new Student(studentFirstName, studentLastName, facNum);
                Console.WriteLine(student);

                string[] workerInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string workerFirstName = workerInfo[0];
                string workerLastName = workerInfo[1];
                decimal salary = decimal.Parse(workerInfo[2]);
                double workingHours = double.Parse(workerInfo[3]);

                Worker worker = new Worker(workerFirstName, workerLastName, salary, workingHours);
                Console.WriteLine(worker);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
