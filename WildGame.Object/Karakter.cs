namespace WildGame.Object
{
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
        case Sinif.Savasci:
          this.Yetenekleri[Yetenek.HafifSilah] += 2;
          this.Yetenekleri[Yetenek.AgirSilah] += 1;
          break;
        case Sinif.Hirsiz:
          sinif = Sinif.Hirsiz;
          this.Yetenekleri[Yetenek.CiftSilah] += 2;
          this.Yetenekleri[Yetenek.UzunMenzilliSilah]++;
          break;
        case Sinif.Barbar:
          sinif = Sinif.Barbar;
          this.Yetenekleri[Yetenek.AgirSilah] += 2;
          this.Yetenekleri[Yetenek.HafifSilah]++;
          break;
        case Sinif.Avci:
          sinif = Sinif.Avci;
          this.Yetenekleri[Yetenek.UzunMenzilliSilah] += 2;
          this.Yetenekleri[Yetenek.Buyu]++;
          break;
        case Sinif.Buyucu:
          sinif = Sinif.Buyucu;
          this.Yetenekleri[Yetenek.Buyu] += 2;
          this.Yetenekleri[Yetenek.HafifSilah]++;
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

    public void IrkBelirle(Irk irk)
    {
      bool hata = false;
      switch (irk)
      {
        case Irk.Insan:
          irk = Irk.Insan;
          this.Yetenekleri[Yetenek.HafifSilah] += 2;
          this.Yetenekleri[Yetenek.Buyu]++;
          break;
        case Irk.Elf:
          irk = Irk.Elf;
          this.Yetenekleri[Yetenek.UzunMenzilliSilah] += 2;
          this.Yetenekleri[Yetenek.AgirSilah]++;
          break;
        case Irk.Ork:
          irk = Irk.Ork;
          this.Yetenekleri[Yetenek.AgirSilah] += 2;
          this.Yetenekleri[Yetenek.UzunMenzilliSilah]++;
          break;
        case Irk.Cuce:
          irk = Irk.Cuce;
          this.Yetenekleri[Yetenek.Buyu] += 2;
          this.Yetenekleri[Yetenek.CiftSilah]++;
          break;
        case Irk.Goblin:
          irk = Irk.Goblin;
          this.Yetenekleri[Yetenek.CiftSilah] += 2;
          this.Yetenekleri[Yetenek.HafifSilah]++;
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