class Program
{
    static void Main()
    {
        // Ziyaretçi isimleri için bir liste oluşturuyoruz.
        List<string> ziyaretciler = new List<string>();

        // Kullanıcıdan isim girmesini istiyoruz.
        Console.WriteLine("Ziyaretçi isimlerini girin (Çıkmak için boş bırakıp Enter'a basın):");

        while (true)
        {
            Console.Write("İsim: ");
            string isim = Console.ReadLine();

            
            if (string.IsNullOrWhiteSpace(isim))
                break;

            
            ziyaretciler.Add(isim);
        }

        // Ziyaretçi isimlerini foreach döngüsü ile yazdırıyoruz.
        Console.WriteLine("\nZiyaretçi Listesi (foreach ile):");
        foreach (string ziyaretci in ziyaretciler)
        {
            Console.WriteLine(ziyaretci);
        }

        // Ziyaretçi isimlerini for döngüsü ile yazdırıyoruz.
        Console.WriteLine("\nZiyaretçi Listesi (for ile):");
        for (int i = 0; i < ziyaretciler.Count; i++)
        {
            Console.WriteLine(ziyaretciler[i]);
        }
    }
}