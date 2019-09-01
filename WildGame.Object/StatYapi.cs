namespace WildGame.Object
{
  using System;

  [PropertyObject]
  public class StatYapi
  {
    public int Mevcut;
    public int Maksimum;

    public StatYapi()
    {
      this.Mevcut = 0;
      this.Maksimum = 0;
    }

    public StatYapi(int mevcut)
    {
      this.Mevcut = mevcut;
      this.Maksimum = mevcut;
    }

    public StatYapi(int mevcut, int maksimum)
    {
      this.Mevcut = mevcut;
      this.Maksimum = maksimum;
    }

    public static StatYapi operator +(StatYapi stat, int artis)
    {
      stat.Mevcut += artis;
      stat.Maksimum += artis;
      return stat;
    }

    public static StatYapi operator -(StatYapi stat, int artis)
    {
      stat.Mevcut -= artis;
      stat.Maksimum -= artis;
      return stat;
    }

    public static implicit operator int(StatYapi stat)
    {
      return stat.Mevcut;
    }

    public override string ToString()
    {
      return $"{this.Mevcut}/{this.Maksimum}";
      //return string.Format("{0},{1}", this.Mevcut, this.Maksimum);
      //return this.Mevcut + "/" +this.Maksimum;


    }
  }
}