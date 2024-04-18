namespace AlıisverisHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] urunler ={"karpuz", "üzüm", "elma", "armut", "çilek", "erik", "ananas", "portakal", "mandalina",
            "muz"};
            int[] fiyatlar = {30,15,20,15,25,40,45,15,10,35 };

            Console.WriteLine("Ürünler: ");
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {urunler[i]} - {fiyatlar[i]}");
            }

            Console.Write("Kaç Ürün Almak İstersiniz: ");
            int adet = int.Parse(Console.ReadLine());

            int toplamFiyat = 0;
            string urunler1 = " ";


            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine("Almak İstediğiniz Ürün: ");
                string secilenUrun = Console.ReadLine();

                for (int j = 0; j < urunler.Length; j++)
                {
                    if (urunler[j] == secilenUrun)
                    {
                        toplamFiyat += fiyatlar[i];
                        urunler1 += secilenUrun + " ";
                        break;
                    }
                }
            }

            Console.WriteLine($"Toplam tutar: {toplamFiyat}");
            Console.WriteLine($"Satın Alınanlar:{urunler1}");

            Console.WriteLine("Ödenen Tutar: ");
            int odenenTutar = int.Parse(Console.ReadLine());
            Console.WriteLine("Para Üstü: " + (odenenTutar - toplamFiyat));

            Console.ReadLine();

        }
    }
    
}
