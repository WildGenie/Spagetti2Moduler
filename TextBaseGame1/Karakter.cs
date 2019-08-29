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
    }
  }
}