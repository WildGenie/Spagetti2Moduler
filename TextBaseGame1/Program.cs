namespace TextBaseGame1
{
  using System;
  using System.Collections.Generic;

  public class Program
  {
    public static void Main(string[] args)
    {

      var karakter = new Karakter();


      karakter.Cinsiyeti = CinsiyetSec();

      Console.WriteLine("Cinsiyetiniz " + karakter.Cinsiyeti);

      karakter.Sinifi = SinifSec(karakter);

      Console.WriteLine("Sinifiniz " + karakter.Sinifi);

      karakter.Irki = IrkSec(karakter);

      Console.WriteLine("irkiniz " + karakter.Irki);

      foreach (KeyValuePair<Yetenek, int> pair in karakter.Yetenekleri)
      {
        Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
      }

      Console.WriteLine("Bir Tuşa Basınız.");
      Console.ReadLine();
    }

    private static Irk IrkSec(Karakter karakter)
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
            irk = TextBaseGame1.Irk.Insan;
            yetenekler[Yetenek.HafifSilah] += 2;
            yetenekler[Yetenek.Buyu]++;
            break;
          case "2":
            irk = TextBaseGame1.Irk.Elf;
            yetenekler[Yetenek.UzunMenzilliSilah] += 2;
            yetenekler[Yetenek.AgirSilah]++;
            break;
          case "3":
            irk = TextBaseGame1.Irk.Ork;
            yetenekler[Yetenek.AgirSilah] += 2;
            yetenekler[Yetenek.UzunMenzilliSilah]++;
            break;
          case "4":
            irk = TextBaseGame1.Irk.Cuce;
            yetenekler[Yetenek.Buyu] += 2;
            yetenekler[Yetenek.CiftSilah]++;
            break;
          case "5":
            irk = TextBaseGame1.Irk.Goblin;
            yetenekler[Yetenek.CiftSilah] += 2;
            yetenekler[Yetenek.HafifSilah]++;
            break;
          default:
            hata = true;
            break;
        }
      }
      while (hata);

      return irk;
    }

    private static Sinif SinifSec(Karakter karakter)
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
            sinif = TextBaseGame1.Sinif.Savasci;
            yetenekler[Yetenek.HafifSilah] += 2;
            yetenekler[Yetenek.AgirSilah] += 1;
            break;
          case "2":
            sinif = TextBaseGame1.Sinif.Hirsiz;
            yetenekler[Yetenek.CiftSilah] += 2;
            yetenekler[Yetenek.UzunMenzilliSilah]++;
            break;
          case "3":
            sinif = TextBaseGame1.Sinif.Barbar;
            yetenekler[Yetenek.AgirSilah] += 2;
            yetenekler[Yetenek.HafifSilah]++;
            break;
          case "4":
            sinif = TextBaseGame1.Sinif.Avci;
            yetenekler[Yetenek.UzunMenzilliSilah] += 2;
            yetenekler[Yetenek.Buyu]++;
            break;
          case "5":
            sinif = TextBaseGame1.Sinif.Buyucu;
            yetenekler[Yetenek.Buyu] += 2;
            yetenekler[Yetenek.HafifSilah]++;
            break;
          default:
            hata = true;
            break;
        }
      }
      while (hata);

      return sinif;
    }

    private static Cinsiyet CinsiyetSec()
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
            cinsiyet = TextBaseGame1.Cinsiyet.Erkek;
            break;
          case "2":
            cinsiyet = TextBaseGame1.Cinsiyet.Kadin;
            break;
          default:
            hata = true;
            break;
        }
      }
      while (hata);

      return cinsiyet;
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