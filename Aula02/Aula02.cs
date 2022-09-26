namespace Csharp_Course.Aula02
{
    class Aula02
    {
        static void Aula2()
        {
            Console.WriteLine("Are you enjoying your work?");
            var employeeAnswer = Console.ReadLine();

            if (employeeAnswer!.ToLower() == "yes")
            {
                Console.WriteLine("That's nice, it's great to know that you enjoy working here.");
                Console.WriteLine("Your answer is: " + employeeAnswer);
            }
            else if(employeeAnswer.ToLower() == "no")
            {
                Console.WriteLine("But why don't you like working here?");
                Console.WriteLine("Your answer is: " + employeeAnswer);
            }

            Console.ReadKey();
        }
    }
}
