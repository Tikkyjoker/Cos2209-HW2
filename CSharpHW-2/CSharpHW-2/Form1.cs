using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharpHW_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //click button for check ID in text-box is create in city?
            Check.Click += (sender, args) =>
            {
                IEnumerable<string> list = Util.ReadF(ID.Text);
                try
                {
                    var enumerable = list as string[] ?? list.ToArray();
                    if (enumerable.Any())
                    {
                        //await ExampleDelayAsync();
                        MessageBox.Show($@"your are born in '{enumerable.ElementAt(0)} ,{enumerable.ElementAt(1)}'");
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException($"ID card verification error.");
                    }
                }
                catch (ArgumentOutOfRangeException err)
                {
                    MessageBox.Show(err.ParamName);
                }
            };
        }
        //test async
        //async Task ExampleDelayAsync()
        //{
        //    await Task.Delay(1000);
        //}

        //static int[] num =  {1, 2, 3, 4, 5, 6, 7, 8, 9};
        //private static string a = "123456789";
        //private int odd = a.Count(a => a == '2' || a == '3');

        //private void Check_Click(object sender, EventArgs e)
        //{
        //    IEnumerable<string> list = Util.ReadF(ID.Text);
        //    try
        //    {
        //        if (list.Any())
        //        {
        //            MessageBox.Show($@"your are born in '{list.ElementAt(0)} ,{list.ElementAt(1)}'");
        //        }
        //        else
        //        {
        //            throw new ArgumentOutOfRangeException(@"ID card verification error.");
        //        }
        //    }
        //    catch (ArgumentOutOfRangeException err)
        //    {
        //        MessageBox.Show(err.ParamName);
        //    }
        //}
    }
}
