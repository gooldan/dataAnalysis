using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace SimpleOfficeWorker
{
  public partial class Form1 : Form
  {
    private Word.Application wordapp;
    private Word.Document worddoc;
    private Excel.Application exapp;
    private Excel.Workbook exbook;
    public List<string> texts = new List<string>();
    enum reportTypes
    {
      DataSummary,
      DataStat,
      Ttest,
      MWtest,
      Chisq,
      ANV,
      corrAN,
      corrPl,
      regAn,
      clust
    }
    public Form1()
    {
      InitializeComponent();
      for (int i = 0; i < 10; ++i)
      {
        texts.Add("");
      }
      

    }

    private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (nameBox.Text == "" || surnameBox.Text == "" || fathersNameBox.Text == "")
      {
        MessageBox.Show("Введите ваше имя, фамилию и отчество.", "Ошибка");
        return;
      }

      try
      {
        Object begin = 0;
        Object end = 0;
        wordapp = new Word.Application();
        worddoc = wordapp.Documents.Add();
        Word.Range wrange= worddoc.Paragraphs.Last.Range;
        wrange.Text = reportNameBox.Text + "\n" + nameBox.Text + " " + fathersNameBox.Text + " " + surnameBox.Text+"\n" +dateTimePicker1.Value.ToShortDateString()+"\f";
        worddoc.Paragraphs.Add();
        wrange = worddoc.Paragraphs.Last.Range;
        wrange.Text = "Описание данных\n Здесь есть текст. Здесь есть текст...\nЗдесь есть текст. Здесь есть текст...Здесь есть текст. Здесь есть текст...\f";
        for (int i = 0; i < 9;++i )
        {
          if(texts[i]!="")
          {
            worddoc.Paragraphs.Add();
            wrange = worddoc.Paragraphs.Last.Range;
            wrange.Text = texts[i] + "\n Здесь есть текст. Здесь есть текст...\nЗдесь есть текст. Здесь есть текст...Здесь есть текст. Здесь есть текст...";
            if(i==5)
            {
              worddoc.Paragraphs.Add();
              wrange = worddoc.Paragraphs.Last.Range;
              Word.Table table = worddoc.Tables.Add(wrange, 2, 3);
              for (int r = 1; r <= table.Rows.Count; r++)
                for (int c = 1; c <= table.Columns.Count; c++)
                  table.Cell(r, c).Range.Text = String.Format("Ячейка {0} в строке {1}", c,r);
              table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
              table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleDashSmallGap;

            } 
            worddoc.Paragraphs.Add();
            wrange = worddoc.Paragraphs.Last.Range;
            wrange.Text = "\f";
          }
        }
        worddoc.Paragraphs.Add();
        wrange = worddoc.Paragraphs.Last.Range;
        wrange.Text = "КОНЕЦ!";
        wordapp.Visible = true;
        if(excelBox.Checked)
        {
          exapp = new Excel.Application();
          exbook = exapp.Workbooks.Add();
          Excel.Worksheet excelws = exbook.Worksheets[1];
          excelws.Name = "Корр. анализ";
           for (int r = 1; r <= 2; r++)
                for (int c = 1; c <= 3; c++)
                  excelws.Cells[r, c] = String.Format("Яч {0} в стр {1}", c, r);
           excelws = exbook.Worksheets[2];
           excelws.Name = "регр. анализ";
           excelws.Cells[1, 1] = "Коэффициент";
           excelws.Cells[1, 2] = "Значение ";
           excelws.Cells[1, 3] = "P-value";
           for (int r = 2; r <= 5;++r )
             excelws.Cells[r, 1] = "Var #"+r;

           exapp.Visible = true;
          
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Упс..");
        wordapp.Quit();
        worddoc = null;
        wordapp = null;

      }
    }

    private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
    {

      int selected = e.Index;
      
      switch (selected)
      {
        case 0:
          texts[0] = texts[0] == "" ? "Описательные статистики" : "";
          break;
        case 1:
          texts[1] = texts[1] == "" ? "T-test" : "";
          break;
        case 2:
          texts[2] = texts[2] == "" ? "Тест Манна-Уитни" : "";
          break;
        case 3:
          texts[3] = texts[3] == "" ? "Хи-квадрат" : "";
          break;
        case 4:
          texts[4] = texts[4] == "" ? "ANOVA" : "";
          break;
        case 5:
          if (texts[5] == "")
          {
            texts[5] = "Корреляционный анализ";
            excelBox.Visible = true;
          }
          else
          {
            texts[5] = "";
            if (texts[7] == "")
            {
              excelBox.Checked = false;
              excelBox.Visible = false;
            }

            checkedListBox1.SetItemChecked(selected + 1, false);
          }
          break;
        case 6:
          if (texts[6] == "")
          {
            texts[6] = "Корреляционная плеяда";
            checkedListBox1.SetItemChecked(selected - 1, true);
          }
          else
          {
            texts[6] = "";
          }
          break;
        case 7:
          if (texts[7] == "")
          {
            texts[7] = "Регрессионный анализ";
            excelBox.Visible = true;
          }
          else
          {
            if (texts[5] == "")
            {
              excelBox.Checked = false;
              excelBox.Visible = false;
            }
            texts[7] = "";
          }
          break;
        case 8:
          texts[8] = texts[8] == "" ? "Кластеризация" : "";
          break;
      }
    }

    private void label6_Click(object sender, EventArgs e)
    {

    }
  }
}
