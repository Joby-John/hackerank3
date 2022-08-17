using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        string time = s;
        int hrind = s.IndexOf(":");
        string ampm = s.Substring((s.LastIndexOf("M") - 1));
        int hr = Convert.ToInt32(s.Substring(0, 2));
        int mm = Convert.ToInt32(s.Substring(3, 2));
        int ss = Convert.ToInt32(s.Substring(6, 2));
        if (ampm == "PM" && hr < 12)
        {
            hr = 12 + hr;
            return (hr.ToString("D2") + ":" + mm.ToString("D2") + ":" + ss.ToString("D2"));
            // the D2 makes the 1 digit number as a 2 digit nummber eg; 1 as 01
            //eg code: ("{0:D2}:{1:D2}:{2:D2}",hour, minute, second)
        }
        else if (ampm == "AM" && hr == 12)
        {
            hr = 00;
            return (hr.ToString("D2") + ":" + mm.ToString("D2") + ":" + ss.ToString("D2"));
        }
        else
        {
            return (hr.ToString("D2") + ":" + mm.ToString("D2") + ":" + ss.ToString("D2"));
        }


    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

