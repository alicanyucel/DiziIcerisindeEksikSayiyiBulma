internal class Program
{
    private static void Main(string[] args)
    {
        // Numaraları listele
        int[] numaralar = new int[10000000];
        Random rnd = new Random();
        for (int i = 0; i < numaralar.Length; i++)
        {
            numaralar[i] = rnd.Next(1, 10000000);
            Console.WriteLine("rastgele gelen numaralar:" + numaralar[i]);
        }
           // Tüm numaralara yer verilecek diziyi oluştur
       int[] tamNumaralar = new int[numaralar.Length ];

        //    // Tüm numaraları ilgili dizeye aktar
          for (int i = 0; i < numaralar.Length; i++)
             tamNumaralar[i] = i + 1;
           IEnumerable<int> eksikSayi = tamNumaralar.Except(numaralar);

        // Eksik olan değişkeni yazdır
        foreach (int sayi in eksikSayi)
            Console.WriteLine("eksik sayilar:" + sayi);
        Console.ReadKey();
    }
}
