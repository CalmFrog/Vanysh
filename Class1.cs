using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanysh
{
    class Class1
    {
        public void vvod(MainWindow MainW)
        {
            MainW.textbox1.Clear();
            int min;
            int max;
            int N;
            N = Convert.ToInt32(MainW.textbox0.Text);

            int[] a = new int[N];
            Random rand = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next(-10, 100);
                MainW.textbox1.Text += a[i] + " ";
            }

            max = a[0];
            min = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                    MainW.textbox2.Text = (i + 1).ToString();
                }

                if (a[i] > max)
                {
                    max = a[i];
                    MainW.textbox3.Text = (i + 1).ToString();
                }
            }
        }

    }
}

