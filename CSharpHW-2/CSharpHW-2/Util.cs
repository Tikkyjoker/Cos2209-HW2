﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CSharpHW_2
{
    public class Util
    {
        //check string input is all number and have 13 character and verify ID is right
        internal static bool Checks(string IDtext)
        {
            try
            {
                if (IDtext.Length != 13)
                {
                    throw new IndexOutOfRangeException("Please input 13 number");
                }

                if (IDtext.All(Char.IsLetter))
                {
                    throw new FormatException("Please input Number Only");
                }

                return Verify(IDtext).ToString() == IDtext.Substring(12, 1);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please input Number Only");
            }
            catch (IndexOutOfRangeException err)
            {
                MessageBox.Show(err.Message);
            }

            return false;
        }


        // read file csv and compare string input have in data?
        internal static IEnumerable<string> ReadF(string s)
        {
            var lists = File.ReadAllLines(@"C:\Users\kanok\Documents\test.csv").Select(a => a.Split(','));
            var list = (from str in lists select (from col in str select col).ToArray()).Skip(1).ToArray();
            if (Checks(s))
            {
                foreach (var text in list)
                {
                    if (s.Substring(1, 4) == text[0])
                    {
                        yield return text[2];
                        yield return text[3];
                        yield break;
                    }
                }
            }
        }
        // function check verify last string is right
        private static int Verify(string text)
        {
            int ans = 0;
            for (int i = 0; i < 12; i++)
            {
                ans += (13-i)*int.Parse(text.Substring(i, 1))%11;
            }
            return ans%11<=1? 1-(ans%11):11-(ans%11);
        }
    }
}