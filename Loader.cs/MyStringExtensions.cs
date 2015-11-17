using System;
using System.Globalization;
using System.Linq;

namespace MatrixFileManager
{
  public static class MyStringExtensions
  {
    public static double[] ConvertStringToDoubleArray(this string value, string separator)
    {
      if (value.Contains(".") || value.Contains(",")) {
        if (CultureInfo.CurrentCulture.Name == "pl-PL" || CultureInfo.CurrentCulture.Name == "pl")
          value = value.Replace(".", ",");
        else
          value = value.Replace(",", ".");
      }
      
      string[] strings = value.Split(new string[] { separator }, StringSplitOptions.RemoveEmptyEntries);
      double[] data = strings.Skip(1).Select(x => double.Parse(x, CultureInfo.CurrentCulture)).ToArray();
      return data;
    }
  }
}
