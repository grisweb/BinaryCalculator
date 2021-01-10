using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryCalculator
{
    class BinaryXor : BinaryElement
    {
        public override string Operation(string firstStr, string secondStr)
        {
            string result = "";

            if (!CorrectionCheck(firstStr) || !CorrectionCheck(secondStr))
            {
                throw new Exception("Некорректное значение!");
            }

            EqualizeLength(ref firstStr, ref secondStr);

            for (int i = 0; i < firstStr.Length; i++)
            {
                result += firstStr[i] ^ secondStr[i];
            }

            return result;
        }
    }
}
