namespace WildGame.Object
{
  using System;
  using System.Collections;
  using System.Collections.Generic;
  using System.Linq;

  public class Stats : IEnumerable<StatYapi>
  {

    private readonly StatYapi[] _stats;

    public readonly Karakter _owner;

    public Stats(Karakter karakter)
    {
      this._owner = karakter;
      var statlar = Enum.GetValues(typeof(StatName));
      _stats = new StatYapi[statlar.Length];

      this[StatName.Seviye] = new StatYapi();
      this[StatName.HP] = new StatYapi(10);
      this[StatName.MP] = new StatYapi(10);
      this[StatName.SP] = new StatYapi(10);
      this[StatName.Tecrube] = new StatYapi();
      this[StatName.DagitilanYetenekPuani] = new StatYapi();
      this[StatName.KalanYetenekPuani] = new StatYapi();

    }


    public IEnumerator<StatYapi> GetEnumerator()
    {
      return this._stats.Where(s => s != null).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return this._stats.Where(s => s != null).GetEnumerator();
    }

    public StatYapi this[StatName tecrube]
    {
      get
      {
        return this._stats[(int)tecrube];
      }
      set
      {
        this._stats[(int)tecrube] = value;
      }
    }

    public StatYapi HP
    {
      get
      {
        return this[StatName.HP];
      }

      set
      {
        this[StatName.HP] = value;
      }
    }

    public StatYapi MP
    {
      get
      {
        return this[StatName.MP];
      }

      set
      {
        this[StatName.MP] = value;
      }
    }

    public StatYapi SP
    {
      get
      {
        return this[StatName.SP];
      }

      set
      {
        this[StatName.SP] = value;
      }
    }

    public StatYapi Seviye
    {
      get
      {
        return this[StatName.Seviye];
      }

      set
      {
        this[StatName.Seviye] = value;
      }
    }


    public StatYapi KalanYetenekPuani
    {
      get
      {
        return this[StatName.KalanYetenekPuani];
      }

      set
      {
        this[StatName.KalanYetenekPuani] = value;
      }
    }

    public StatYapi Tecrube
    {
      get
      {
        return this[StatName.Tecrube];
      }

      set
      {
        this[StatName.Tecrube] = value;
      }
    }

    public StatYapi DagitilanYetenekPuani
    {
      get
      {
        return this[StatName.DagitilanYetenekPuani];
      }

      set
      {
        this[StatName.DagitilanYetenekPuani] = value;
      }
    }
  }
}