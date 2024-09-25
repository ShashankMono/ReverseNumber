using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber.Models
{
    internal class Reverse
    {
        public string NumberReverse(int number) {

            string result = "";
            while (number > 0) {
                int temp = number % 10;
                result += temp.ToString();
                number /= 10;
            }
            return result;
        }
    }
}
