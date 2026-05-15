namespace ToDoList
{
    internal class Program
    {
        static void ShowMenu()
        {
            Console.WriteLine("What do you want to do?\n" 
                            + "[S]ee all TODOs\n"
                            + "[A]dd a TODO\n"
                            + "[R]emove a TODO\n"
                            + "[Exit]");
        }

        static void PrintToDoList(List<string> list)
        {


        }
         
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            ConsoleKeyInfo userChoice;
            do
            {
                ShowMenu();
                userChoice = Console.ReadKey(true);
                Console.WriteLine(userChoice.KeyChar);

            } while (userChoice.KeyChar != 'E' && userChoice.KeyChar != 'e');

            
            
        }
    }
}
