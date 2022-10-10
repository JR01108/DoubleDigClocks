using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDigClocks
{
    internal class Time
    {
        public int h;
        public int m;
        public int s;
        public int format;

        public Time()
        {
            format = 24;
        }

        public void ChangeFormat()
        {
            if (format == 24)
                format = 12;
            else
                format = 24;
        }

        public string getDecTime()
        {
            string time = "";
            if (format == 24)
            {
                h = DateTime.Now.Hour;
                m = DateTime.Now.Minute;
                s = DateTime.Now.Second;

                if (h < 10)
                {
                    time += "0" + h;
                }
                else
                {
                    time += h;
                }

                time += ":";

                if (m < 10)
                {
                    time += "0" + m;
                }
                else
                {
                    time += m;
                }

                time += ":";

                if (s < 10)
                {
                    time += "0" + s;
                }
                else
                {
                    time += s;
                }
            }
            else
            {
                h = DateTime.Now.Hour;
                m = DateTime.Now.Minute;
                s = DateTime.Now.Second;
                if (h < 13)
                {
                    time += "AM ";
                }
                else
                {
                    time += "PM ";
                }

                if ((h == 0)||(h == 12))
                {
                    h = 12;
                }
                else
                {
                    h = (h + 1) % 13;
                }
                if (h < 10)
                {
                    time += "0" + h;
                }
                else
                {
                    time += h;
                }

                time += ":";

                if (m < 10)
                {
                    time += "0" + m;
                }
                else
                {
                    time += m;
                }

                time += ":";

                if (s < 10)
                {
                    time += "0" + s;
                }
                else
                {
                    time += s;
                }
            }

            return time;
        }

        private string getBinaryNumber(int length, int number)
        {
            return Convert.ToString(number, 2).PadLeft(length, '0');
        }

        public string getBinTime()
        {
            string time = "";
            time = getBinaryNumber(5, DateTime.Now.Hour) + ':'
                + getBinaryNumber(6, DateTime.Now.Minute) + ':'
                + getBinaryNumber(6, DateTime.Now.Second);
            return time;
        }
    }
}
