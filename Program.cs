namespace TextFiles
{
    /*internal class Program
    {
        static void Main(string[] args)
        {
            var array = File.ReadAllLines("text.txt");
            array = array.Select(e => e.FirstSymbolsToUpper()).ToArray();
        }


    }
    public static class StringExtensions
    {
        public static string FirstSymbolsToUpper(this string input) =>
            input switch
            {
                "" => throw new Exception("String cannot be empty"),
                _ => string.Concat(input[0].ToString().ToUpper(), input.AsSpan(1))
            };
    }*/

    /*public class AdditionalTask1
    {
        static void Main(string[] args)
        {
            Console.Write("Введите путь к папке: ");
            string path = Console.ReadLine()!;

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            foreach (FileInfo file in directoryInfo.GetFiles()) { Console.WriteLine($"File: {file.Name}"); }
            foreach (DirectoryInfo directory in directoryInfo.GetDirectories()) { Console.WriteLine($"Directory: {directory.Name}"); }
        }
    }*/

    /*public class AdditionalTask2
    {
        static void Main(string[] args)
        {
            Console.Write("Введите путь к папке: ");
            string path = Console.ReadLine()!;

            Console.Write("Введите ключевое слово: ");
            string keyWord = Console.ReadLine()!;

            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                if (file.FullName.Contains(keyWord))
                {
                    { Console.WriteLine($"File: {file.Name}"); }
                }
            }
        }
    }*/

    /*public class AdditionalTask3
    {
        static void Main(string[] args)
        {
            Console.Write("Введите путь к папке: ");
            string path = Console.ReadLine()!;

            Console.Write("Введите новый адрес: ");
            string newPath = Console.ReadLine()!;

            Directory.Move(path, newPath);
        }
    }*/


}
