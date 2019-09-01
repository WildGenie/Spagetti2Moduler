using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WildGame.WinFormUI
{
  using WildGame.Object;

  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    Karakter karakter = new Karakter();
    private void Form1_Load(object sender, EventArgs e)
    {
      this.comboBox1.DataSource = Enum.GetValues(typeof(Cinsiyet));
      this.comboBox2.DataSource = Enum.GetValues(typeof(Irk));
      this.comboBox3.DataSource = Enum.GetValues(typeof(Sinif));
      this.propertyGrid1.SelectedObject = this.karakter;
      this.propertyGrid2.SelectedObject = new DictionaryPropertyGridAdapter(this.karakter.Yetenekleri);
      this.propertyGrid3.SelectedObject =
        this.karakter.Statlari; //new DictionaryPropertyGridAdapter(this.karakter.Statlari);
    }

    private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.karakter.CinsiyetBelirle(this.comboBox1.SelectedItem is Cinsiyet ? (Cinsiyet)this.comboBox1.SelectedItem : Cinsiyet.Yok);
      propertyGrid1.Refresh();
      this.propertyGrid2.Refresh();
    }

    private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.karakter.IrkBelirle(this.comboBox2.SelectedItem is Irk ? (Irk)this.comboBox2.SelectedItem : Irk.Yok);
      propertyGrid1.Refresh();
      this.propertyGrid2.Refresh();

    }

    private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.karakter.SinifBelirle(this.comboBox3.SelectedItem is Sinif ? (Sinif)this.comboBox3.SelectedItem : Sinif.Yok);
      propertyGrid1.Refresh();
      this.propertyGrid2.Refresh();
      }

    private void Button1_Click(object sender, EventArgs e)
    {
      this.karakter.TecrubeGelistir(100);
      this.propertyGrid3.Refresh();
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      this.karakter.Buff(10);
      this.propertyGrid3.Refresh();

    }

    private void Button3_Click(object sender, EventArgs e)
    {
      this.karakter.UnBuff(10);
      this.propertyGrid3.Refresh();

    }

    private void Button4_Click(object sender, EventArgs e)
    {
      int seviyesi = this.karakter.Statlari[StatName.Seviye];

      this.textBox1.Text = seviyesi.ToString();
    }

    private void Button5_Click(object sender, EventArgs e)
    {
      
      this.karakter.Konumu += new Pos(1, 0);      
      propertyGrid1.Refresh();

    }

    private void Button8_Click(object sender, EventArgs e)
    {
      this.karakter.Konumu += new Pos(-1, 0);
      propertyGrid1.Refresh();

    }

    private void Button7_Click(object sender, EventArgs e)
    {
      this.karakter.Konumu += new Pos(0, 1);
      propertyGrid1.Refresh();

    }

    private void Button6_Click(object sender, EventArgs e)
    {
      this.karakter.Konumu += new Pos(0, -1);
      propertyGrid1.Refresh();

    }
  }
}
