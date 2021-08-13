﻿using System;
using System.Globalization;

public static class ValidUtl
{
   public static bool CheckIfEmpty(params string[] list)
   {
      foreach (string o in list)
      {
         if (o == null || o.Trim().Equals(""))
         {
            return true;
         }
      }
      return false;
   }

   // Extension Method to check whether the contents of a string is an integer
   public static bool IsInteger(this String x)
   {
      return Int32.TryParse(x, out int i);
   }

    public static bool IsNumeric(this String x)
    {
        return Double.TryParse(x, out double i);
    }

}
