using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods {
    public static class MathExtensions {

        public static int Fn1(this int i) {
            return i * i + 5;
        }
    }
}
