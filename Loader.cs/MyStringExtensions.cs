using System;
using System.Globalization;
using System.Linq;

namespace MatrixFileManager
{
  public static class MyStringExtensions
  {
    public static double[] ConvertStringToDoubleArray(this string value, string sign)
    {
      //TODO set support . and , 
      string[] strings = value.Split(new string[] { sign }, StringSplitOptions.RemoveEmptyEntries);
      double[] data = strings.Skip(1).Select(x => double.Parse(x, CultureInfo.CurrentCulture)).ToArray();
      return data;
    }
  }
}
