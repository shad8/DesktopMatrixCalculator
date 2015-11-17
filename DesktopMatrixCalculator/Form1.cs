using System;
using System.IO;
using System.Windows.Forms;
using Math;
using MatrixFileManager;
using System.Drawing;

namespace DesktopMatrixCalculator
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void loadMatrixAToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OpendialogFor(listView1);
    }

    private void CreateMyListView(Matrix matrix, ListView listView)
    {
      listView.HeaderStyle = ColumnHeaderStyle.None;
      listView.View = View.Details;
      listView.GridLines = true;

      for (int i = 0; i < matrix.Row; i++)
      {
        ListViewItem item = new ListViewItem(matrix.GetRow(i));
        listView.Items.Add(item);
      }
      for (int i = 0; i < matrix.Column; i++)
        listView.Columns.Add("Column");

      this.Controls.Add(listView);
    }

    private void OpendialogFor(ListView listView)
    {
      Stream myStream = null;
      OpenFileDialog openFileDialog1 = new OpenFileDialog();

      openFileDialog1.InitialDirectory = "c:\\";
      openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
      openFileDialog1.FilterIndex = 2;
      openFileDialog1.RestoreDirectory = true;

      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        try
        {
          if ((myStream = openFileDialog1.OpenFile()) != null)
          {
            using (myStream)
            {
              Loader loader = new Loader(openFileDialog1.FileName);
              Matrix matrix = loader.LoadMatrix();
              myStream.Close();
              CreateMyListView(matrix, listView);
            }
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
        }
      }
    }

    private void loadMatrixBToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OpendialogFor(listView2);
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Environment.Exit(0);
    }
  }
}
