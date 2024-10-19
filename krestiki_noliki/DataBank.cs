using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krestiki_noliki
{
    static class DataBank
    {
        public static string[,] Field = { 
            { "", "", "" }, 
            { "", "", "" }, 
            { "", "", "" } };
        public static int Move = 0;
        public static string[] Figure = { "O", "X" };
    }
}
