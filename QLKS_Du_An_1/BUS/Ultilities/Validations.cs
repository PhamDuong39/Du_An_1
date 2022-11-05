using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BUS.Ultilities
{
    internal class Validations
    {
        public bool CheckCCCD(string obj)
        {
            return Regex.IsMatch(obj, @"^(0)+[0-9]{11}$");// Trả về true thì đúng(Chưa test)
        }
        public bool CheckSDT(string obj)
        {
            return Regex.IsMatch(obj, @"^((\+|)84)|0(3|5|7|8|9)+([0-9]{8})");// Số điện thoại có đầu +84 or 03 05 07 08 09 + 8 số phía sau tổng là 10 trả về true thì đúng(Test Sơ qua đã đúng)
        }
    }
}
