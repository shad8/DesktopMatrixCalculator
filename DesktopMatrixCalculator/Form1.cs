using System;
using System.IO;
using System.Windows.Forms;
using Math;
using MatrixFileManager;

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


            }
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
        }
      }
    }
  }
}
