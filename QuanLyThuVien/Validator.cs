using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    internal class Validator
    {
        public static bool isEmptyText(string text)
        {
            if (text.Trim() == "")
                return true;
            return false;
        }
    }
}
