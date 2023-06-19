class Program
{
    public static void Main()
    {
        Console.Write("Input one line of words(S): ");
        string str = Console.ReadLine();
        str = str.Replace(" ", string.Empty);
        List<string> vowelList = new List<string>();
        List<string> consonanList = new List<string>();
        char[] vowelCharacter = { 'a', 'i', 'u', 'e', 'o' };

        var distinc = str.ToLower().Distinct().ToList();

        foreach (var item in distinc)
        {
            var vowel = vowelCharacter.Where(x => x == item).FirstOrDefault();
            var res = str.Where(x => x == vowel).ToList();
            if (res.Count > 0)
            {
                res.ForEach(x => vowelList.Add(x.ToString()));
            }
            else
            {
                consonanList.Add(item.ToString());
            }

        }

        Console.WriteLine("Vowel Character : ");
        vowelList.ForEach(x => Console.Write(x));
        Console.WriteLine();
        Console.WriteLine("Consonan Character :");
        consonanList.ForEach(x => Console.Write(x));
        Console.ReadLine();
    }
}
