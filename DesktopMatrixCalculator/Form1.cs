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
              Matrix A = loader.LoadMatrix();
              myStream.Close();
              CreateMyListView(A);
            }
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
        }
      }
    }

    private void CreateMyListView(Matrix matrix)
    {
      //ListView listView1 = new ListView();
      //listView1.Bounds = new Rectangle(new Point(15, 30), new Size(matrix.Row * 40, matrix.Column * 40));
      listView1.HeaderStyle = ColumnHeaderStyle.None;
      listView1.View = View.Details;
      listView1.GridLines = true;

      for (int i = 0; i < matrix.Row; i++)
      {
        ListViewItem item = new ListViewItem(matrix.GetRow(i));
        listView1.Items.Add(item);
      }
      for (int i = 0; i < matrix.Column; i++)
        listView1.Columns.Add("Column");

      this.Controls.Add(listView1);
    }
  }
}
