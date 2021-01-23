using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati =15;
            string aciklama ="Amasya elması";

            string[] meyveler = new string[] { };


            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyatı =15;
            urun1.Aciklama ="Amasya elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyatı = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Product[] urunler = new Product[] { urun1, urun2 };

            // type safe- tip güvenli
            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi+"\n"+urun.Fiyatı+"\n"+urun.Aciklama);
                Console.WriteLine("------------");
            }


            Console.WriteLine("-------- metotlar-----------");


            SepetManager sepetManager = new SepetManager();
            // encapsulation
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yesil armut", 12,10);
            sepetManager.Ekle2("Elma", "yesil elma", 12,9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12,8);
            Console.ReadLine();
        }
    }
}
// Dont repeat yourself - DRY - Clean Code- Best Practice