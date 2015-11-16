using System;
using System.IO;
using Math;

namespace MatrixFileManager
{

  public class Loader
  {
    string fileName;

    public Loader(string fileName)
    {
      this.fileName = fileName;
    }

    public Matrix LoadMatrix()
    {
      StreamReader streamReader = new StreamReader(fileName);
      string body = " ";

      string[] line = streamReader.ReadLine().Split(' ');
      int column = Int32.Parse(line[0]);
      int row = Int32.Parse(line[1]);
      while (streamReader.Peek() >= 1)
      {
        body = body + streamReader.ReadLine();
      }
      double[] marixBody = body.ConvertStringToDoubleArray('\t');
      return new Matrix(marixBody, row, column);
    }
  }
}
