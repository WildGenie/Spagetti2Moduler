namespace WildGame.WinFormUI
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.comboBox2 = new System.Windows.Forms.ComboBox();
      this.comboBox3 = new System.Windows.Forms.ComboBox();
      this.propertyGrid2 = new System.Windows.Forms.PropertyGrid();
      this.propertyGrid3 = new System.Windows.Forms.PropertyGrid();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // propertyGrid1
      // 
      this.propertyGrid1.Location = new System.Drawing.Point(641, 12);
      this.propertyGrid1.Name = "propertyGrid1";
      this.propertyGrid1.Size = new System.Drawing.Size(417, 294);
      this.propertyGrid1.TabIndex = 0;
      // 
      // comboBox1
      // 
      this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(90, 39);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(138, 24);
      this.comboBox1.TabIndex = 1;
      this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
      // 
      // comboBox2
      // 
      this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Location = new System.Drawing.Point(90, 69);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new System.Drawing.Size(138, 24);
      this.comboBox2.TabIndex = 2;
      this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
      // 
      // comboBox3
      // 
      this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox3.FormattingEnabled = true;
      this.comboBox3.Location = new System.Drawing.Point(90, 99);
      this.comboBox3.Name = "comboBox3";
      this.comboBox3.Size = new System.Drawing.Size(138, 24);
      this.comboBox3.TabIndex = 3;
      this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.ComboBox3_SelectedIndexChanged);
      // 
      // propertyGrid2
      // 
      this.propertyGrid2.Location = new System.Drawing.Point(641, 312);
      this.propertyGrid2.Name = "propertyGrid2";
      this.propertyGrid2.Size = new System.Drawing.Size(417, 248);
      this.propertyGrid2.TabIndex = 4;
      // 
      // propertyGrid3
      // 
      this.propertyGrid3.Location = new System.Drawing.Point(12, 312);
      this.propertyGrid3.Name = "propertyGrid3";
      this.propertyGrid3.Size = new System.Drawing.Size(417, 248);
      this.propertyGrid3.TabIndex = 5;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(335, 39);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 6;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.Button1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1070, 572);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.propertyGrid3);
      this.Controls.Add(this.propertyGrid2);
      this.Controls.Add(this.comboBox3);
      this.Controls.Add(this.comboBox2);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.propertyGrid1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PropertyGrid propertyGrid1;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.ComboBox comboBox2;
    private System.Windows.Forms.ComboBox comboBox3;
    private System.Windows.Forms.PropertyGrid propertyGrid2;
    private System.Windows.Forms.PropertyGrid propertyGrid3;
    private System.Windows.Forms.Button button1;
  }
}

