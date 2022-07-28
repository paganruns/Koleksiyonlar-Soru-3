class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir Cümle Giriniz.");
        var cumle = Console.ReadLine();

        int a = 0;

        string[] sesli = new string[cumle.Length];

        for (int i = 0; i < cumle.Length; i++)
        {
            if ("aeiouöüıAEIOUÖÜİ".IndexOf(cumle[i]) >= 0)
            {
                sesli[a] = new string(cumle[i], 1);
                a++; // sesli harf sayısı
            }

        }

        Array.Resize(ref sesli, a); // sesli harf sayısının düzeltilmesi

        foreach (var item in sesli)
        {
            System.Console.WriteLine(item);
        }
        


    }
}
