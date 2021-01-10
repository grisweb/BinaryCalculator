using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryCalculator
{
    abstract class BinaryElement
    {
        public abstract string Operation(string firstStr, string secondStr);

        public bool CorrectionCheck(string str)
        {
            foreach (char symbol in str)
            {
                if (symbol != '1' && symbol != '0')
                {
                    return false;
                }
            }

            return true;
        }

        protected void ExpandOperand(ref string str, int length)
        {
            length -= str.Length;

            while (length-- != 0)
            {
                str = str.Insert(0, "0");
            }
        }

        protected void EqualizeLength(ref string firstStr, ref string secondStr)
        {
            if (firstStr.Length != secondStr.Length)
            {
                if (firstStr.Length > secondStr.Length)
                {
                    ExpandOperand(ref secondStr, firstStr.Length);
                }
                else
                {
                    ExpandOperand(ref firstStr, secondStr.Length);
                }
            }
        }
    }
}
