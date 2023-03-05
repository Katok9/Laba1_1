namespace Laba1_1
{
    class Program
    {
        static void Main()
        {
            string path = "files/file1.txt";
            List<Char> symbols = ReadFile(path);
            Find(symbols);
        }

        static List<Char> ReadFile(string path)
        {
            string line;
            using (StreamReader reader = new StreamReader(path))
            {
                line = reader.ReadToEnd();
            }

            char[] symbols = line.ToCharArray();
            List<Char> list = new List<Char>(symbols);

            return list;
        }

        static void Find(List<Char> symbols)
        {
            char[] golosni = { 'а', 'о', 'у', 'е', 'и' };

            int countGolosni = 0;
            int countPrugolosni = 0;

            foreach (char letter in symbols)
            {
                bool isLetter = Char.IsLetter(letter);

                if (isLetter == false)
                {
                    continue;
                }

                char lowerLetter = Char.ToLower(letter);


                if (golosni.Contains(lowerLetter))
                {
                    countGolosni++;
                }
                else
                {
                    countPrugolosni++;
                }
            }
            Console.WriteLine("Кількість голосних: " + countGolosni + "\n" + "Кількість приголосних: " + countPrugolosni);
        }
    }
}