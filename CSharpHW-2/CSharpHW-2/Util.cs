using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharpHW_2
{
    public class Util
    {
        //check string input is all number and have 13 character and verify ID is right
        internal static bool Checks(string idText)
        {
            try
            {
                if (idText.Length != 13)
                {
                    throw new IndexOutOfRangeException("Please input 13 number");
                }

                if (!idText.All(char.IsNumber))
                {
                    throw new FormatException("Please input Number Only");
                }

                return Verify(idText).ToString() == idText.Substring(12, 1);
            }
            catch (FormatException err) 
            {
                MessageBox.Show(err.Message);
            }
            catch (IndexOutOfRangeException err)
            {
                MessageBox.Show(err.Message);
            }

            return false;
        }


        // read file csv and compare string input have in data?
        internal static IEnumerable<string> ReadF(string ID)
        {
            var lists = File.ReadAllLines(@"C:\Users\kanok\Documents\listname.csv", Encoding.GetEncoding(874)).Select(a => a.Split(','));
            var list = (from str in lists select (from col in str select col).ToArray()).Skip(1).ToArray();
            if (!Checks(ID)) yield break;
            foreach (var text in list)
            {
                if (ID.Substring(1, 4) != text[0]) continue;
                yield return text[1];
                yield return text[3];
                break;
            }
        }
        // function check verify last string is right
        private static int Verify(string text)
        {
            var ans = 0;
            for (var i = 0; i < 12; i++)
            {
                ans += (13-i)*int.Parse(text.Substring(i, 1))%11;
            }
            return ans%11<=1? 1-(ans%11):11-(ans%11);
        }
    }
}