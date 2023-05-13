namespace music.c
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            music m = new music("Pantera", 57.38, "Cowboys from Hell");
            music m1 = new music("Korn", 53.20, "Issues");
            music m2 = new music("Slayer", 41.56, "Repentless");

            Console.WriteLine("The length of the albums is: ");
            Console.WriteLine(Math.Round(m.length + m1.length + m2.length, 2));
        }
    }
}