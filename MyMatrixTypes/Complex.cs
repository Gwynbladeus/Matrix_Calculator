using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MyMatrixTypes
{
    public class Complex : Ring
    {
        double real;
        double imag;
        public Complex(String str) : base(str) {}
        public Complex() { }
        public override string GetName()
        {
            return "Complex";
        }
        public override void Add(Ring obj)
        {
            if (CheckEquality(obj))
            {
                String[] param = obj.GetParameters();
                real += Double.Parse(param[0]);
                imag += Double.Parse(param[1]);
            }
            else {
                throw new Exception(message: "Objects are different");
            }
        }
        public override void Multiply(Ring obj)
        {
            if (CheckEquality(obj))
            {
                String[] param = obj.GetParameters();
                double pReal = Double.Parse(param[0]);
                double pImag = Double.Parse(param[1]);
                double newReal = (real * pReal - imag * pImag);
                double newImag = (real * pImag + pReal * imag);
                real = newReal;
                imag = newImag;
            }
            else
            {
                throw new Exception(message: "Objects are different");
            }
        }
        public override String AsString()
        {
            String realStr = "";
            String imagStr = "";
            if (real != 0) {           
                realStr = real.ToString();
            }
            if (imag != 0) {
                imagStr = imag.ToString();   
            }
            if (imag > 0)
            {
                if (real == 0)
                {
                    return imagStr + "i";
                }
                else
                {
                    return realStr + "+" + imagStr + "i";
                }
            }
            else
            {
                if (real == 0) {
                    return "0";
                }
                return realStr;
            }
        }

        public override void ConvertToRing(String number)
        {
            if (Regex.IsMatch(number, @"^[-]?[0-9]+([,][0-9]+)?i?$|^[-]?[0-9]+([,][0-9]+)?[+-][0-9]+([,][0-9]+)?i$|^i$|^[-]?[0-9]+([,][0-9]+)?[+-]i$")) {
                MatchCollection matchList = Regex.Matches(number, @"[0-9]+|-|,|i|[+]");
                int count = matchList.Count-1;
                //had to be split into two different functions, because they are composited differnetly
                String imagStr = InterpretImagExpression(ref count, matchList);
                imag = Convert.ToDouble(imagStr);
                String realStr = InterpretRealExpression(ref count, matchList);
                real = Convert.ToDouble(realStr);
            }
        }
        private String InterpretImagExpression(ref int count, MatchCollection groups)
        {
            String imagStr = "";
            if (groups[count].Value.Equals("i"))
            {
                count--;
                if (count == -1)
                {
                    imagStr = "1,0";
                    count--;
                }
                else if (groups[count].Value.Equals("+"))
                {
                    imagStr = "1,0";
                    count--;
                }
                else if (groups[count].Value.Equals("-"))
                {
                    imagStr = "-1,0";
                    count--;
                }
                else if (count == 0) {
                    imagStr = (groups[count].Value + ",0");
                    count -= 1;
                }
                else if (groups[count - 1].Value.Equals(","))
                {
                    
                    imagStr = (groups[count - 2].Value + "," + groups[count].Value);
                    count -= 3;
                    if (count > 0) {
                        imagStr = (groups[count].Value) + imagStr;                        
                    }
                    count--;
                }
                else
                {
                    imagStr = (groups[count].Value + ",0");
                    count--;
                    if (count > 0)
                    {
                        imagStr = (groups[count].Value) + imagStr;
                    }
                    count--;
                }
            }
            else
            {
                imagStr = "0,0";
            }
            return imagStr;
        }
        private String InterpretRealExpression(ref int count, MatchCollection groups)
        {
            switch (count) {
                case 0:
                    return groups[count].Value + ",0";
                case 1:
                    return "-" + groups[count].Value + ",0";
                case 2:
                    return groups[count - 2].Value + "," + groups[count].Value;
                case 3:
                    return "-" + groups[count - 2].Value + "," + groups[count].Value;
                default:
                    return "0.0";
            }
        }

        public override string[] GetParameters()
        {
            String[] param = new string[2];
            param[1] = imag.ToString();
            param[0] = real.ToString();
            return param;
        }
        public override Ring GetRandomElem(Random rand) {
            double newReal = rand.Next(100);
            double newImag = rand.Next(100);
            if (rand.Next(10) > 5) {
                newReal *= (-1);
            }
            if (rand.Next(10) > 5)
            {
                newImag *= (-1);
            }
            if (rand.Next(10) > 5)
            {
                newImag *= rand.NextDouble();
            }
            if (rand.Next(10) > 5)
            {
                newReal *= rand.NextDouble();
            }
            return new Complex(createComplexString(newReal,newImag));
        }
        private String createComplexString(double newReal, double newImag) {
            String complex;
            String newRealStr = newReal.ToString();
            String newImagStr = newImag.ToString();
            if (newImag == 0)
            {
                complex = "" + newRealStr;
            }
            else if (newImag == 1)
            {
                if (newReal != 0)
                {
                    complex = newRealStr + "+i";
                }
                else
                {
                    complex = "i";
                }
            }
            else if (newImag == -1)
            {
                if (newReal != 0)
                {
                    complex = newRealStr + "-i";
                }
                else
                {
                    complex = "-i";
                }
            }
            else
            { 
                if (newImag >= 0) {
                    complex = newRealStr + "+" + newImagStr + "i";
                }
                else
                {
                    complex = newRealStr + newImagStr + "i";
                }

            }
            return complex;
        }
    }
}
