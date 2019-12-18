using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        public static bool IsDetermined(double a, double b)
        {
            if (a != 0 && b != 0)
                return true;
            else
                return false;
        }
        public static bool IsInconsisted(double a)
        {
            if (a == 0)
                return true;
            else
                return false;
        }
        public static bool IsDegree2(double a)
        {
            if (a != 0 )
                return true;
            else
                return false;
        }
        public static double Delta(double a, double b, double c)
        {
            double delta;
            if (a == 0)
                return delta = double.NaN;
            else
            {
                delta = (b * b) - (4 * a * c);
                return delta;
            }  
        }
        public static string EquationDegree1(double a, double b)
        {
            if (a == 0 && b != 0)
            {
                return "Impossible";
            }
            else if (a == 0 && b == 0)
            {
                return "Indeterminated";
            }
            string y;
            y = ((-b) / a).ToString();
            return y;
        }
        public static string EquationDegree2(double a, double b, double c)
        {
            string e;
            string f;
            double delta = Equazioni.Delta(a, b, c);
            if (b == 0 && c != 0)
            {
                e = ((Math.Sqrt(-c))/a).ToString();
                f = (-(Math.Sqrt(-c)) / a).ToString();
                return ($"e è {e} e f è {f}");
            }
            else if (b != 0 && c == 0)
            {
                e = 0.ToString();
                f = (-b / a).ToString();
                return($"e è {e} e f è {f}");
            }
            else if (a != 0 && b != 0 && c != 0)
            {
                if (delta > 0)
                {
                    e = (-b - Math.Sqrt(delta) / (2 * a)).ToString();
                    f = (-b + Math.Sqrt(delta) / (2 * a)).ToString();
                    return ($"e è {e} e f è {f}");
                }
                else if (delta == 0)
                {
                    f = e = (-b / (2 * a)).ToString();
                    return ($"e è {e} e f è {f}");
                }
                else if (delta < 0)
                {
                    return "Impossible";
                }
            }
            return "";
        }
    }
}