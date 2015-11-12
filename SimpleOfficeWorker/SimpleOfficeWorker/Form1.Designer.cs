namespace SimpleOfficeWorker
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
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.nameBox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.surnameBox = new System.Windows.Forms.TextBox();
      this.fathersNameBox = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
      this.label5 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.excelBox = new System.Windows.Forms.CheckBox();
      this.reportNameBox = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Location = new System.Drawing.Point(111, 104);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(201, 20);
      this.dateTimePicker1.TabIndex = 0;
      // 
      // nameBox
      // 
      this.nameBox.Location = new System.Drawing.Point(111, 28);
      this.nameBox.Name = "nameBox";
      this.nameBox.Size = new System.Drawing.Size(201, 20);
      this.nameBox.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 31);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(29, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Имя";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 57);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(56, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Фамилия";
      // 
      // surnameBox
      // 
      this.surnameBox.Location = new System.Drawing.Point(111, 54);
      this.surnameBox.Name = "surnameBox";
      this.surnameBox.Size = new System.Drawing.Size(201, 20);
      this.surnameBox.TabIndex = 4;
      // 
      // fathersNameBox
      // 
      this.fathersNameBox.Location = new System.Drawing.Point(111, 80);
      this.fathersNameBox.Name = "fathersNameBox";
      this.fathersNameBox.Size = new System.Drawing.Size(201, 20);
      this.fathersNameBox.TabIndex = 8;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 83);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(54, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Отчество";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 110);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(33, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "Дата";
      // 
      // checkedListBox1
      // 
      this.checkedListBox1.FormattingEnabled = true;
      this.checkedListBox1.Items.AddRange(new object[] {
            "Описательные статистики",
            "T-тест",
            "Тест Манна-Уитни",
            "Хи-квадрат",
            "ANOVA",
            "Корреляционный анализ",
            "Корреляционная плеяда",
            "Регрессионный анализ",
            "Кластеризация"});
      this.checkedListBox1.Location = new System.Drawing.Point(111, 130);
      this.checkedListBox1.Name = "checkedListBox1";
      this.checkedListBox1.Size = new System.Drawing.Size(201, 94);
      this.checkedListBox1.TabIndex = 10;
      this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
      this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(12, 175);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(79, 13);
      this.label5.TabIndex = 11;
      this.label5.Text = "Виды анализа";
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(237, 230);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 13;
      this.button2.Text = "Создать";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // excelBox
      // 
      this.excelBox.AutoSize = true;
      this.excelBox.Location = new System.Drawing.Point(179, 234);
      this.excelBox.Name = "excelBox";
      this.excelBox.Size = new System.Drawing.Size(52, 17);
      this.excelBox.TabIndex = 14;
      this.excelBox.Text = "Excel";
      this.excelBox.UseVisualStyleBackColor = true;
      this.excelBox.Visible = false;
      // 
      // reportNameBox
      // 
      this.reportNameBox.Location = new System.Drawing.Point(111, 2);
      this.reportNameBox.Name = "reportNameBox";
      this.reportNameBox.Size = new System.Drawing.Size(201, 20);
      this.reportNameBox.TabIndex = 16;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(12, 5);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(93, 13);
      this.label6.TabIndex = 15;
      this.label6.Text = "Название отчета";
      this.label6.Click += new System.EventHandler(this.label6_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(327, 266);
      this.Controls.Add(this.reportNameBox);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.excelBox);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.checkedListBox1);
      this.Controls.Add(this.fathersNameBox);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.surnameBox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.nameBox);
      this.Controls.Add(this.dateTimePicker1);
      this.Name = "Form1";
      this.Text = "Data Analysis";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.TextBox nameBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox surnameBox;
    private System.Windows.Forms.TextBox fathersNameBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.CheckedListBox checkedListBox1;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.CheckBox excelBox;
    private System.Windows.Forms.TextBox reportNameBox;
    private System.Windows.Forms.Label label6;
  }
}

