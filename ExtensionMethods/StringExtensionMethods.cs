using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods {
    
    public static class StringExtensionMethods {

        public static void Debug(this string str) {
            Console.WriteLine(str);
        }

        public static void Ucase(this string str) {
            Console.WriteLine(str.ToUpper());
        }

    }
}
