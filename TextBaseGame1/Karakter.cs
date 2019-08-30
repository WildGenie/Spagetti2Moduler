namespace TextBaseGame1
{
  using System;
  using System.Collections.Generic;

  public class Karakter
  {
    public Cinsiyet Cinsiyeti
    {
      get;
      private set;
    }

    public Sinif Sinifi
    {
      get;
      private set;
    }

    public Irk Irki
    {
      get;
      private set;
    }

    public Dictionary<Yetenek, int> Yetenekleri
    {
      get;
      private set;
    } = new Dictionary<Yetenek, int>()
          {
            [Yetenek.Yok] = 0,
            [Yetenek.HafifSilah] = 0,
            [Yetenek.AgirSilah] = 0,
            [Yetenek.CiftSilah] = 0,
            [Yetenek.UzunMenzilliSilah] = 0,
            [Yetenek.Buyu] = 0,

    };

    public List<Esya> Esyalari
    {
      get;
      set;
    } = new List<Esya>();

    public Pos Konumu
    {
      get;
      set;
    }

    public Dictionary<Stat, StatYapi> Statlari
    {
      get;
      set;
    } = new Dictionary<Stat, StatYapi>();


    public bool SinifBelirle(Sinif sinif)
    {
      bool hata = false;
      switch (sinif)
      {
        case TextBaseGame1.Sinif.Savasci:
          Yetenekleri[Yetenek.HafifSilah] += 2;
          Yetenekleri[Yetenek.AgirSilah] += 1;
          break;
        case TextBaseGame1.Sinif.Hirsiz:
          sinif = TextBaseGame1.Sinif.Hirsiz;
          Yetenekleri[Yetenek.CiftSilah] += 2;
          Yetenekleri[Yetenek.UzunMenzilliSilah]++;
          break;
        case TextBaseGame1.Sinif.Barbar:
          sinif = TextBaseGame1.Sinif.Barbar;
          Yetenekleri[Yetenek.AgirSilah] += 2;
          Yetenekleri[Yetenek.HafifSilah]++;
          break;
        case TextBaseGame1.Sinif.Avci:
          sinif = TextBaseGame1.Sinif.Avci;
          Yetenekleri[Yetenek.UzunMenzilliSilah] += 2;
          Yetenekleri[Yetenek.Buyu]++;
          break;
        case TextBaseGame1.Sinif.Buyucu:
          sinif = TextBaseGame1.Sinif.Buyucu;
          Yetenekleri[Yetenek.Buyu] += 2;
          Yetenekleri[Yetenek.HafifSilah]++;
          break;
        default:
          hata = true;
          break;
      }

      return hata;
    }

    public bool CinsiyetBelirle(Cinsiyet cinsiyet)
    {
      bool hata = false;
      switch (cinsiyet)
      {
        case Cinsiyet.Erkek:
          Cinsiyeti = Cinsiyet.Erkek;
          break;
        case Cinsiyet.Kadin:
          Cinsiyeti = Cinsiyet.Kadin;
          break;
        default:
          hata = true;
          break;
      }

      return hata;
    }

    public void IrkBelirle(Irk irk)
    {
      bool hata = false;
      switch (irk)
      {
        case TextBaseGame1.Irk.Insan:
          irk = TextBaseGame1.Irk.Insan;
          Yetenekleri[Yetenek.HafifSilah] += 2;
          Yetenekleri[Yetenek.Buyu]++;
          break;
        case TextBaseGame1.Irk.Elf:
          irk = TextBaseGame1.Irk.Elf;
          Yetenekleri[Yetenek.UzunMenzilliSilah] += 2;
          Yetenekleri[Yetenek.AgirSilah]++;
          break;
        case TextBaseGame1.Irk.Ork:
          irk = TextBaseGame1.Irk.Ork;
          Yetenekleri[Yetenek.AgirSilah] += 2;
          Yetenekleri[Yetenek.UzunMenzilliSilah]++;
          break;
        case TextBaseGame1.Irk.Cuce:
          irk = TextBaseGame1.Irk.Cuce;
          Yetenekleri[Yetenek.Buyu] += 2;
          Yetenekleri[Yetenek.CiftSilah]++;
          break;
        case TextBaseGame1.Irk.Goblin:
          irk = TextBaseGame1.Irk.Goblin;
          Yetenekleri[Yetenek.CiftSilah] += 2;
          Yetenekleri[Yetenek.HafifSilah]++;
          break;
        default:
          hata = true;
          break;
      }
    }
  }

  public struct Pos
  {
    public int X;

    public int Y;
  }
}