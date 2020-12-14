using System;
using System.Collections.Generic;
using System.Text;

namespace Mess_around.ExtensionMethods
{
    public static class IntExtensions
    {
        public static int Square(this int num)
        {
            return num * num;
        }
    }
}