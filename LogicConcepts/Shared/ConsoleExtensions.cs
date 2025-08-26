

namespace Shared
{
    public class ConsoleExtensions
    {

        public static int getInt(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();

            if (int.TryParse(input, out int result))
            {
                return result;
            }
            else
            {
                return 0;
            }

        }
    }
}
