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
    private Matrix A;
    private Matrix B;

    public Form1()
    {
      InitializeComponent();
    }

    private void loadMatrixAToolStripMenuItem_Click(object sender, EventArgs e)
    {
      A = OpendialogFor(listViewMatrixA);
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

    private Matrix OpendialogFor(ListView listView)
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
              return matrix;
            }
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
        }
      }
      return new Matrix();
    }

    private void loadMatrixBToolStripMenuItem_Click(object sender, EventArgs e)
    {
      B = OpendialogFor(listViewMatrixB);
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Environment.Exit(0);
    }

    private void aboutMatrixCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Matrix calculator for simple matrix operations.\nAuthor: Urszula Hołodniak");
    }

    private void calculateSumeCABToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Matrix C = A + B;
      listViewMatrixC.Clear();
      CreateMyListView(C, listViewMatrixC);
    }

    private void calculateDifferenceCABToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Matrix C = A - B;
      listViewMatrixC.Clear();
      CreateMyListView(C, listViewMatrixC);
    }

    private void calculateDifferenceCBAToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Matrix C = B - A;
      listViewMatrixC.Clear();
      CreateMyListView(C, listViewMatrixC);
    }

    private void calculateProductCABToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Matrix C = A * B;
      listViewMatrixC.Clear();
      CreateMyListView(C, listViewMatrixC);
    }

    private void calculateProductCBAToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Matrix C = B * A;
      listViewMatrixC.Clear();
      CreateMyListView(C, listViewMatrixC);
    }
  }
}
