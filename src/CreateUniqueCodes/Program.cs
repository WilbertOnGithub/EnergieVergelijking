using Sqids;

namespace CreateUniqueCodes;

class Program
{
    static void Main(string[] args)
    {
        var sqids = new SqidsEncoder<int>(new SqidsOptions
        {
            Alphabet = "xakyd4ejhmv5l1uf9gzo2qicp07n3wr86stb",
            MinLength = 6
        });

        using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"C:\temp", "MailMergeCodes.txt")))
        {
            for (int i = 0; i < 400; i++)
            {
                var id = sqids.Encode(i);
                outputFile.WriteLine($"{i};{id}");
            }
        }

        Console.WriteLine("Done");
    }
}