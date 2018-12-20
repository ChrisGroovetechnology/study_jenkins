using System;
using System.Collections.Generic;
using System.Text;

namespace study_jenkins.Models
{
    public class SimpleMath
    {
        public static int Add(int a, int b) => a + b; 
        public static int Subtract(int a, int b) => a - b;
        public static int Multiply(int a, int b) => a * b;
        public static int Divide(int a, int b) => a / b;
        public static int Remainder(int a, int b) => a % b;
    }
}
