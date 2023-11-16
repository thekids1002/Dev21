using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication2
{
    public class Function
    {
        public static bool isNumber(string s)
        {
            try
            {
                double a = double.Parse(s);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static double Calculateam(double mMax, double gb, double rb, double b, double ho)
        {
            try
            {
                return (double)(mMax * Math.Pow(10, 6) / (gb * rb / b * Math.Pow(ho, 2)));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Sai kiểu dữ liệu");
                return 0;
            }
        }


        public static double CalculateHo(double h, double a)
        {
            return h - a;
        }

        public static double CalculateX(double Am)
        {
            return 1 - Math.Pow((1 - 2 * Am), 0.5);
        }

        public static double CalculateAs(double x, double gb, double rb, double b, double h0, double Rs)
        {
            return x * gb * rb * b * h0 / Rs;
        }


        public static double CalculateN(double As, double phi)
        {
            double numerator = Math.PI * Math.Pow(phi, 2) / 4;
            return As / numerator;
        }

        public static double CalculateA(double b, double n)
        {
            return (double)b / n;
        }
    }
}
