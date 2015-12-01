using System;
using System.IO;
using System.Windows.Forms;
using Math;
using MatrixFileManager;

namespace DesktopMatrixCalculator
{
  public partial class DesktopMatrixCalculator : Form
  {
    private Matrix A;
    private Matrix B;
    private Matrix C;

    public DesktopMatrixCalculator()
    {
      InitializeComponent();
    }

    private void loadMatrixAToolStripMenuItem_Click(object sender, EventArgs e)
    {
      A = OpenDialogFor(listViewMatrixA);
    }

    private void CreateMyListView(Matrix matrix, ListView listView)
    {
      listView.Clear();
      listView.HeaderStyle = ColumnHeaderStyle.None;
      listView.View = View.Details;
      listView.GridLines = true;

      for (int i = 0; i < matrix.Row; i++)
      {
        ListViewItem item = new ListViewItem(matrix.GetRows(i));
        listView.Items.Add(item);
      }
      for (int i = 0; i < matrix.Column; i++)
        listView.Columns.Add("Column");

      this.Controls.Add(listView);
    }

    private Matrix OpenDialogFor(ListView listView)
    {
      Stream myStream = null;
      OpenFileDialog openFileDialog1 = new OpenFileDialog();

      openFileDialog1.InitialDirectory = @"c:\\";
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
              
              toolStripStatusLabel1.Text = "Matrix has been loaded...";
              statusStripOperations.Refresh();
              return matrix;
            }
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
          toolStripStatusLabel1.Text = "Error: Could not read file from disk.";
          statusStripOperations.Refresh();
        }
      }
      return new Matrix();
    }

    private void loadMatrixBToolStripMenuItem_Click(object sender, EventArgs e)
    {
      B = OpenDialogFor(listViewMatrixB);
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Environment.Exit(0);
    }

    private void aboutMatrixCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Matrix calculator for simple matrix operations.\nAuthor: Urszula Hołodniak", "About Matrx Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void calculateSumeCABToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Addition(A, B);
    }

    private void calculateDifferenceCABToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Subtraction(A, B);
    }

    private void calculateDifferenceCBAToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Subtraction(B, A);      
    }

    private void calculateProductCABToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Multiplication(A, B);
    }

    private void calculateProductCBAToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Multiplication(B, A);
    }

    private void saveMatrixCToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Stream myStream;
      SaveFileDialog saveFileDialogMatrix = new SaveFileDialog();

      saveFileDialogMatrix.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
      saveFileDialogMatrix.DefaultExt = "txt";
      saveFileDialogMatrix.FilterIndex = 2;
      saveFileDialogMatrix.RestoreDirectory = true;

      if (saveFileDialogMatrix.ShowDialog() == DialogResult.OK)
      {
        if ((myStream = saveFileDialogMatrix.OpenFile()) != null)
        {
          try
          {
            myStream.Close();
            new Writer(saveFileDialogMatrix.FileName, C).WriterToFile();
            MessageBox.Show("File was save successfuly");
            toolStripStatusLabel1.Text = "File was save successfuly";
            statusStripOperations.Refresh();
          }
          catch (Exception ex)
          {
            MessageBox.Show("Error: Could not save file on disk. Original error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            toolStripStatusLabel1.Text = "Error: Could not save file on disk.";
            statusStripOperations.Refresh();
          }
        }
      }
    }

    private void buttonMultiplicationAB(object sender, EventArgs e)
    {
      Multiplication(A, B);
    }
    private void buttonMultiplicationBA(object sender, EventArgs e)
    {
      Multiplication(B, A);
    }
    private void buttonAddAB_Click(object sender, EventArgs e)
    {
      Addition(A, B);
    }
    private void buttonSubtractionAB_Click(object sender, EventArgs e)
    {
      Subtraction(A, B);
    }
    private void buttonSubtractionBA_Click(object sender, EventArgs e)
    {
      Subtraction(B, A);
    }

    private void Addition(Matrix A, Matrix B)
    {
      try
      {
        C = A + B;
        CreateMyListView(C, listViewMatrixC);
        toolStripStatusLabel1.Text = "Adding successful";
        statusStripOperations.Refresh();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Adding Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        toolStripStatusLabel1.Text = "Adding Error";
        statusStripOperations.Refresh();
      }
    }

    private void Subtraction(Matrix firstElement, Matrix secondElement)
    {
      try
      {
        C = firstElement - secondElement;
        CreateMyListView(C, listViewMatrixC);
        toolStripStatusLabel1.Text = "Subtraction successful";
        statusStripOperations.Refresh();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Operation Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        toolStripStatusLabel1.Text = "Operation Error";
        statusStripOperations.Refresh();
      }
    }

    private void Multiplication(Matrix firstElement, Matrix secondElement)
    {
      try
      {
        C = firstElement * secondElement;
        CreateMyListView(C, listViewMatrixC);
        toolStripStatusLabel1.Text = "Multiplication successful";
        statusStripOperations.Refresh();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Multiplication Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        toolStripStatusLabel1.Text = "Multiplication Error";
        statusStripOperations.Refresh();
      }
    }
  }
}
