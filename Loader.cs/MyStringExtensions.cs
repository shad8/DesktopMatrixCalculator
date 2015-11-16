using System;
using System.Globalization;
using System.Linq;

namespace MatrixFileManager
{
  public static class MyStringExtensions
  {
    public static double[] ConvertStringToDoubleArray(this string value, char sign)
    {
      //TODO set support . and , 
      string[] strings = value.Split(sign);
      double[] data = strings.Skip(1).Select(x => double.Parse(x, CultureInfo.CurrentCulture)).ToArray();
      return data;
    }

    public static int[] ConvertStringToIntArray(this string value, char sign)
    {
      string[] strings = value.Split(sign);
      int[] data = strings.Select(x => Int32.Parse(x, CultureInfo.CurrentCulture)).ToArray();
      return data;
    }
  }
}
