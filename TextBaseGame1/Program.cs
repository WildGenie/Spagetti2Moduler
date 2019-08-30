namespace TextBaseGame1
{
  using System;
  using System.Collections.Generic;

  public class Program
  {
    public static void Main(string[] args)
    {

      var karakter = new Karakter();


      CinsiyetSec(karakter);

      Console.WriteLine("Cinsiyetiniz " + karakter.Cinsiyeti);

      SinifSec(karakter);

      Console.WriteLine("Sinifiniz " + karakter.Sinifi);

      IrkSec(karakter);

      Console.WriteLine("irkiniz " + karakter.Irki);

      foreach (KeyValuePair<Yetenek, int> pair in karakter.Yetenekleri)
      {
        Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
      }

      Console.WriteLine("Bir Tuşa Basınız.");
      Console.ReadLine();
    }

    private static void IrkSec(Karakter karakter)
    {
      bool hata;
      Irk irk = TextBaseGame1.Irk.Yok;
      var yetenekler = karakter.Yetenekleri;
      do
      {
        hata = false;
        var cikti = "Irkını Seç!\n1. İnsan\n2. Elf\n3. Ork\n4. Cüce\n5. Goblin";
        Console.WriteLine(cikti);
        var girdi = Console.ReadLine();
        switch (girdi)
        {
          case "1":
            karakter.IrkBelirle(TextBaseGame1.Irk.Insan);
            break;
          case "2":
            karakter.IrkBelirle(TextBaseGame1.Irk.Elf);
            break;
          case "3":
            karakter.IrkBelirle(TextBaseGame1.Irk.Ork);
            break;
          case "4":
            karakter.IrkBelirle(TextBaseGame1.Irk.Cuce);
            break;
          case "5":
            karakter.IrkBelirle(TextBaseGame1.Irk.Goblin);
            break;
          default:
            hata = true;
            break;
        }
      }
      while (hata);

      return;
    }

    private static void SinifSec(Karakter karakter)
    {
      bool hata;
      string girdi;
      Sinif sinif = TextBaseGame1.Sinif.Yok;
      var yetenekler = karakter.Yetenekleri;
      do
      {
        hata = false;
        var cikti = "Sinifini Seç!\n1. Savaşçı\n2. Hırsız\n3. Barbar\n4. Avcı\n5. Büyücü";
        Console.WriteLine(cikti);
        girdi = Console.ReadLine();
        switch (girdi)
        {
          case "1":
            karakter.SinifBelirle(TextBaseGame1.Sinif.Savasci);
            break;
          case "2":
            karakter.SinifBelirle(TextBaseGame1.Sinif.Hirsiz);
            break;
          case "3":
            karakter.SinifBelirle(TextBaseGame1.Sinif.Barbar);
            break;
          case "4":
            karakter.SinifBelirle(TextBaseGame1.Sinif.Avci);
            break;
          case "5":
            karakter.SinifBelirle(TextBaseGame1.Sinif.Buyucu);
            break;
          default:
            hata = true;
            break;
        }
      }
      while (hata);

      return;
    }

    private static void CinsiyetSec(Karakter karakter)
    {
      bool hata;
      string girdi;
      Cinsiyet cinsiyet = TextBaseGame1.Cinsiyet.Yok;
      do
      {
        hata = false;
        var cikti = "Oyuna hos geldin yabanci.\nCinsiyetini seçin:\n1. Erkek\n2. Kadın";
        Console.WriteLine(cikti);
        girdi = Console.ReadLine();
        switch (girdi)
        {
          case "1":
            karakter.CinsiyetBelirle(TextBaseGame1.Cinsiyet.Erkek);
            break;
          case "2":
            karakter.CinsiyetBelirle(TextBaseGame1.Cinsiyet.Kadin);
            break;
          default:
            hata = true;
            break;
        }
      }
      while (hata);

      return;
    }

    // .NET can only read single characters or entire lines from the console.
    // The following function safely reads a double value.
    private static double readValue()
    {
      double result;
      while (!double.TryParse(Console.ReadLine(), out result)) ;
      return result;
    }
  }
}