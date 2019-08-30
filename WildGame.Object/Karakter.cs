namespace WildGame.Object
{
  using System;
  using System.Collections.Generic;

  public class Karakter
  {
    public Karakter()
    {
      SeviyeBelirle(0);
    }

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
      get; set;

    } = new Dictionary<Stat, StatYapi>()
    {
      [Stat.Seviye] = new StatYapi(),
      [Stat.HP] = new StatYapi(10),
      [Stat.MP] = new StatYapi(10),
      [Stat.SP] = new StatYapi(10),
      [Stat.Tecrube] = new StatYapi(),
      [Stat.DagitilanYetenekPuani] = new StatYapi(),
      [Stat.KalanYetenekPuani] = new StatYapi()

    };


    public bool SinifBelirle(Sinif sinif)
    {
      bool hata = false;

      var eskiSinifi = Sinifi;

      switch (sinif)
      {
        case Sinif.Savasci:
          Sinifi = sinif;
          this.Yetenekleri[Yetenek.HafifSilah] += 2;
          this.Yetenekleri[Yetenek.AgirSilah] += 1;
          break;
        case Sinif.Hirsiz:
          Sinifi = sinif;
          this.Yetenekleri[Yetenek.CiftSilah] += 2;
          this.Yetenekleri[Yetenek.UzunMenzilliSilah]++;
          break;
        case Sinif.Barbar:
          Sinifi = sinif;
          this.Yetenekleri[Yetenek.AgirSilah] += 2;
          this.Yetenekleri[Yetenek.HafifSilah]++;
          break;
        case Sinif.Avci:
          Sinifi = sinif;
          this.Yetenekleri[Yetenek.UzunMenzilliSilah] += 2;
          this.Yetenekleri[Yetenek.Buyu]++;
          break;
        case Sinif.Buyucu:
          Sinifi = sinif;
          this.Yetenekleri[Yetenek.Buyu] += 2;
          this.Yetenekleri[Yetenek.HafifSilah]++;
          break;
        case Sinif.Yok:
          Sinifi = Sinif.Yok;
          break;
        default:
          hata = true;
          break;
      }

      if (!hata)
      {
        switch (eskiSinifi)
        {
          case Sinif.Savasci:
            this.Yetenekleri[Yetenek.HafifSilah] -= 2;
            this.Yetenekleri[Yetenek.AgirSilah] -= 1;
            break;
          case Sinif.Hirsiz:
            this.Yetenekleri[Yetenek.CiftSilah] -= 2;
            this.Yetenekleri[Yetenek.UzunMenzilliSilah]--;
            break;
          case Sinif.Barbar:
            this.Yetenekleri[Yetenek.AgirSilah] -= 2;
            this.Yetenekleri[Yetenek.HafifSilah]--;
            break;
          case Sinif.Avci:
            this.Yetenekleri[Yetenek.UzunMenzilliSilah] -= 2;
            this.Yetenekleri[Yetenek.Buyu]--;
            break;
          case Sinif.Buyucu:
            this.Yetenekleri[Yetenek.Buyu] -= 2;
            this.Yetenekleri[Yetenek.HafifSilah]--;
            break;
          default:
            break;
        }
      }

      return hata;
    }

    public bool CinsiyetBelirle(Cinsiyet cinsiyet)
    {
      bool hata = false;
      switch (cinsiyet)
      {
        case Cinsiyet.Erkek:
          this.Cinsiyeti = Cinsiyet.Erkek;
          break;
        case Cinsiyet.Kadin:
          this.Cinsiyeti = Cinsiyet.Kadin;
          break;
        default:
          hata = true;
          break;
      }

      return hata;
    }

    public void TecrubeGelistir(int puan)
    {
      Statlari[Stat.Tecrube].Mevcut += puan;
      if (Statlari[Stat.Tecrube].Mevcut >= Statlari[Stat.Tecrube].Maksimum)
      {
        SeviyeBelirle(Statlari[Stat.Seviye].Mevcut + 1);
      }
    }

    public void SeviyeBelirle(int seviye)
    {
      Statlari[Stat.Seviye].Mevcut = seviye;
      Statlari[Stat.Seviye].Maksimum = seviye;
      Statlari[Stat.Tecrube].Maksimum = 1000 * (int)Math.Pow(2, seviye);
      Statlari[Stat.HP].Maksimum = 10 + seviye * 10;
      Statlari[Stat.MP].Maksimum = 10 + seviye * 10;
      Statlari[Stat.SP].Maksimum = 10 + seviye * 5;
    }

    public void IrkBelirle(Irk irk)
    {
      bool hata = false;
      var eskiIrki = Irki;

      switch (irk)
      {
        case Irk.Insan:
          Irki = Irk.Insan;
          this.Yetenekleri[Yetenek.HafifSilah] += 2;
          this.Yetenekleri[Yetenek.Buyu]++;
          break;
        case Irk.Elf:
          Irki = Irk.Elf;
          this.Yetenekleri[Yetenek.UzunMenzilliSilah] += 2;
          this.Yetenekleri[Yetenek.AgirSilah]++;
          break;
        case Irk.Ork:
          Irki = Irk.Ork;
          this.Yetenekleri[Yetenek.AgirSilah] += 2;
          this.Yetenekleri[Yetenek.UzunMenzilliSilah]++;
          break;
        case Irk.Cuce:
          Irki = Irk.Cuce;
          this.Yetenekleri[Yetenek.Buyu] += 2;
          this.Yetenekleri[Yetenek.CiftSilah]++;
          break;
        case Irk.Goblin:
          Irki = Irk.Goblin;
          this.Yetenekleri[Yetenek.CiftSilah] += 2;
          this.Yetenekleri[Yetenek.HafifSilah]++;
          break;
        case Irk.Yok:
          Irki = Irk.Yok;
          break;
        default:
          hata = true;
          break;
      }

      if (!hata)
      {

        switch (eskiIrki)
        {
          case Irk.Insan:
            this.Yetenekleri[Yetenek.HafifSilah] -= 2;
            this.Yetenekleri[Yetenek.Buyu]--;
            break;
          case Irk.Elf:
            this.Yetenekleri[Yetenek.UzunMenzilliSilah] -= 2;
            this.Yetenekleri[Yetenek.AgirSilah]--;
            break;
          case Irk.Ork:
            this.Yetenekleri[Yetenek.AgirSilah] -= 2;
            this.Yetenekleri[Yetenek.UzunMenzilliSilah]--;
            break;
          case Irk.Cuce:
            this.Yetenekleri[Yetenek.Buyu] -= 2;
            this.Yetenekleri[Yetenek.CiftSilah]--;
            break;
          case Irk.Goblin:
            this.Yetenekleri[Yetenek.CiftSilah] -= 2;
            this.Yetenekleri[Yetenek.HafifSilah]--;
            break;
          default:
            break;
        }
      }
    }
  }

  public struct Pos
  {
    public int X;

    public int Y;
  }
}