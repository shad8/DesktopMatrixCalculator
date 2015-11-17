using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
  public class Matrix
  {
    private double[,] body;
    private int row, column;

    public Matrix(double[] body, int row, int column)
    {
      this.row = row;
      this.column = column;
      this.body = new double[row, column];
      int columnSize = body.Length;
      int index = 0;

      for (int i = 0; i < row; i++)
      {
        for (int j = 0; j < column; j++)
        {
          IndexOf(i, j, body[index]);
          index++;
        }
      }
    }

    public Matrix(int row, int column)
    {
      this.row = row;
      this.column = column;
      this.body = new double[row, column];
    }

    public int Row { get { return row; } }
    public int Column { get { return column; } }

    public double IndexOf(int row, int column, double? newValue = null)
    {
      if (newValue.HasValue)
        this.body[row, column] = newValue.Value;
      return this.body[row, column];
    }


    public static Matrix operator +(Matrix matrixA, Matrix matrixB)
    {
      int row = matrixA.row;
      int column = matrixA.column;

      if (matrixA.row != matrixB.row || matrixA.column != matrixB.column)
        throw new Exception("Diension of matrix A and B must be equal");

      Matrix sumMatrix = new Matrix(row, column);

      for (int i = 0; i < row; i++)
      {
        for (int j = 0; j < column; j++)
        {
          double value = matrixA.IndexOf(i, j) + matrixB.IndexOf(i, j);
          sumMatrix.IndexOf(i, j, value);
        }
      }
      return sumMatrix;
    }

    public static Matrix operator -(Matrix matrixA, Matrix matrixB)
    {
      int row = matrixA.row;
      int column = matrixA.column;

      if (matrixA.row != matrixB.row || matrixA.column != matrixB.column)
        throw new Exception("Diension of matrix A and B must be equal");

      Matrix differenceMatrix = new Matrix(row, column);

      for (int i = 0; i < row; i++)
      {
        for (int j = 0; j < column; j++)
        {
          double value = matrixA.IndexOf(i, j) - matrixB.IndexOf(i, j);
          differenceMatrix.IndexOf(i, j, value);
        }
      }
      return differenceMatrix;
    }

    public static Matrix operator *(Matrix matrixA, Matrix matrixB)
    {
      int row = matrixA.row;
      int column = matrixB.column;

      if (row != column)
        throw new Exception("Row of matrix A and column of matrix B must be equal");

      Matrix productMatrix = new Matrix(row, column);

      for (int i = 0; i < row; i++)
      {
        for (int j = 0; j < column; j++)
        {
          for (int k = 0; k < matrixA.column; k++)
          {
            double value = productMatrix.IndexOf(i, j) + matrixA.IndexOf(i, k) * matrixB.IndexOf(k, j);
            productMatrix.IndexOf(i, j, value);
          }
        }
      }
      return productMatrix;
    }

    public double ElementCount()
    {
      double sum = 0;

      foreach (double value in this.body)
      {
        sum += value;
      }
      return sum;
    }

    public void Print()
    {
      Console.WriteLine("" + row + " " + column + "\n");
      for (int i = 0; i < row; i++)
      {
        for (int j = 0; j < column; j++)
        {
          Console.Write("\t" + IndexOf(i, j));
        }
        Console.Write(Environment.NewLine + Environment.NewLine);
      }
    }

    public void SaveToFile(string path)
    {
      try
      {
        System.IO.StreamWriter file = new System.IO.StreamWriter(path);
        string dimension = row + " " + column;
        file.WriteLine(dimension);
        for (int i = 0; i < row; i++)
        {
          for (int j = 0; j < column; j++)
          {
            file.Write("\t" + IndexOf(i, j));
          }
          file.WriteLine(Environment.NewLine);
        }
        file.Close();
        Console.WriteLine("The operation completed successfully");
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
    }

    //TODO retutn double[] not string[]
    public string[] GetRow(int nuberOfRow)
    {
      List<string> row = new List<string>();
      for (int columnNum = 0; columnNum < column; columnNum++)
        row.Add(IndexOf(nuberOfRow, columnNum).ToString());
      return row.ToArray();
    }
  }
}