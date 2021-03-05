using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;



namespace ReadCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter(@"C:\Users\wayan.eka\OneDrive - Volex\Documents\Desktop\Failure Analysis\s_para\zResult.csv");
            writer.WriteLine("SN" + ',' + "Freq" + ',' + "Line 1" + ',' + "Line 2" + ',' + "Line 3" + ',' + "Line 4" + ',' + "Line 5" + ',' + "Line 6" + ',' + "Line 7" + ',' + "Line 8");

            var filePaths = Directory.GetFiles(@"C:\Users\wayan.eka\OneDrive - Volex\Documents\Desktop\Failure Analysis\s_para\P9\", "*.csv");
            foreach (string s in filePaths)
            {

                StreamReader reader = new StreamReader(s);
                string stringBeforeChar = s.Substring(s.Length-19,19);
                string SN = stringBeforeChar.Substring(0,15);

                int i = 0;
                var line = reader.ReadLine();
                var values = line.Split(',');

                while (i != 1289)
                {
                    line = reader.ReadLine();
                    values = line.Split(',');
                    i++;

                }


                writer.WriteLine(SN + ',' + values[0] + ',' + values[1] + ',' + values[3] + ',' + values[4] + ',' + values[5] + ',' + values[6] + ',' + values[7] + ',' + values[8] + ',' + values[9]);

                reader.Close();

            }
            writer.Close();

        }
    }

}
