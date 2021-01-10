using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryCalculator
{
    class BinaryFactory
    {
        public BinaryFactory()
        {
            _binaryAnd = new BinaryAnd();
            _binaryOr = new BinaryOr();
            _binaryXor = new BinaryXor();
        }
        public BinaryElement CreateElement(string operation)
        {
            if (operation == "&")
            {
                return _binaryAnd;
            }
            else if (operation == "|")
            {
                return _binaryOr;
            }
            else if (operation == "^")
            {
                return _binaryXor;
            }
            else
            {
                throw new Exception("Несуществующий тип операции!");
            }
        }
        public bool CheckOperation(string operation)
        {
            if (operation != "^" && operation != "&" && operation != "|")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private BinaryAnd _binaryAnd;
        private BinaryOr _binaryOr;
        private BinaryXor _binaryXor;
    }
}