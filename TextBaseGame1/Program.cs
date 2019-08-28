namespace TextBaseGame1
{
  using System;

  public class Program
  {
    public static void Main(string[] args)
    {
      int[] yetenekler = new int[6];
      string[] yetenekIsim = new string[] {
       "Yok", "Kalkan Silah", "Çift Silah", "Çift El Silah", "Uzak Mesafe Silah", "Büyü"
      };

      string sinif = "";
      string cinsiyet = "";
      string irk = "";
      string cikti;
      string girdi;
      bool hata;

      do
      {
        hata = false;
        cikti = "Oyuna hos geldin yabanci.\nCinsiyetini seçin:\n1. Erkek\n2. Kadın";
        Console.WriteLine(cikti);
        girdi = Console.ReadLine();
        if (girdi == "1")
        {
          cinsiyet = "Erkek";
        }
        else
        {
          if (girdi == "2")
          {
            cinsiyet = "Kadın";
          }
          else
          {
            hata = true;
          }
        }
      }
      while (hata == true);
      Console.WriteLine("Cinsiyetiniz " + cinsiyet);

      do
      {
        hata = false;
        cikti = "Sinifini Seç!\n1. Savaşçı\n2. Hırsız\n3. Barbar\n4. Avcı\n5. Büyücü";
        Console.WriteLine(cikti);
        girdi = Console.ReadLine();
        if (girdi == "1")
        {
          sinif = "Savaşçı";
          yetenekler[1] += 2;
          yetenekler[3] += 1;


        }
        else
        {
          if (girdi == "2")
          {
            sinif = "Hırsız";
            yetenekler[2] += 2;
            yetenekler[4]++;

          }
          else
          {
            if (girdi == "3")
            {
              sinif = "Barbar";
              yetenekler[3] += 2;
              yetenekler[1]++;

            }
            else
            {
              if (girdi == "4")
              {
                sinif = "Avcı";
                yetenekler[4] += 2;
                yetenekler[5]++;

              }
              else
              {
                if (girdi == "5")
                {
                  sinif = "Büyücü";
                  yetenekler[5] += 2;
                  yetenekler[1]++;

                }
                else
                {
                  hata = true;
                }
              }
            }
          }
        }
      }
      while (hata == true);
      Console.WriteLine("Sinifiniz " + sinif);


      do
      {
        hata = false;
        cikti = "Irkını Seç!\n1. İnsan\n2. Elf\n3. Ork\n4. Cüce\n5. Goblin";
        Console.WriteLine(cikti);
        girdi = Console.ReadLine();
        if (girdi == "1")
        {
          irk = "İnsan";
          yetenekler[1] += 2;
          yetenekler[5]++;

        }
        else
        {
          if (girdi == "2")
          {
            irk = "Elf";
            yetenekler[4] += 2;
            yetenekler[3]++;

          }
          else
          {
            if (girdi == "3")
            {
              irk = "Ork";
              yetenekler[3] += 2;
              yetenekler[4]++;

            }
            else
            {
              if (girdi == "4")
              {
                irk = "Cüce";
                yetenekler[1] += 2;
                yetenekler[2]++;

              }
              else
              {
                if (girdi == "5")
                {
                  irk = "Goblin";
                  yetenekler[2] += 2;
                  yetenekler[1]++;

                }
                else
                {
                  hata = true;
                }
              }
            }
          }
        }
      }
      while (hata == true);

      Console.WriteLine("irkiniz " + irk);


      for (int i = 1; i <= 5; i++)
      {
        Console.WriteLine("{0}: {1}", yetenekIsim[i], yetenekler[i]);
      }



      Console.WriteLine("Bir Tuşa Basınız.");
      Console.ReadLine();


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
