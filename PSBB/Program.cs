class Program
{
    public static void Main()
    {
        int totalBus = 0;
        int busLimit = 4;

        Console.Write("Input the number of families :");
        int totalFamily = int.Parse(Console.ReadLine());
        Console.Write("Input the number of members in the family (separated by a space) :");
        List<int> familymember = Console.ReadLine().Split().Select(int.Parse).ToList();
        if (familymember.Count != totalFamily)
        {
            Console.WriteLine($"Input must be equal with count of family");
            return;
        }

        double member = (double)familymember.Sum() / busLimit;
        totalBus = (int)Math.Ceiling(member);
        Console.WriteLine($"Minimun Bus Required : {totalBus}");
        Console.ReadLine();
    }
}