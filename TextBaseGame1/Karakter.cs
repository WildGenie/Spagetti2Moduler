namespace TextBaseGame1
{
  using System.Collections.Generic;

  public class Karakter
  {
    public Cinsiyet Cinsiyeti
    {
      get;
      set;
    }

    public Sinif Sinifi
    {
      get;
      set;
    }

    public Irk Irki
    {
      get;
      set;
    }

    public Dictionary<Yetenek, int> Yetenekleri
    {
      get;
      set;
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
  }

  public struct Pos
  {
    public int X;

    public int Y;
  }
}