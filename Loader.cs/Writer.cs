using Math;
using System.IO;

namespace MatrixFileManager
{
  public class Writer
  {
    private string fileName;
    private Matrix matrix;

    public Writer(string fileName, Matrix matrix)
    {
      this.fileName = fileName;
      this.matrix = matrix;
    }

    public void WriterToFile()
    {
      StreamWriter streamWriter = new StreamWriter(fileName);
      string row;

      streamWriter.WriteLine(matrix.Dimension());
      for (int i = 0; i < matrix.Row; i++)
      {
        row = string.Join("\t", matrix.GetRows(i));
        streamWriter.WriteLine("\t" + row);
      }

      streamWriter.Close();
    }
  }
}
