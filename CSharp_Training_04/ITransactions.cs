using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training_04
{
    public interface ITransactions
    {
        void DisplayData();

        string GetCode();
        int GetCount();
    }

    public class Transactions : ITransactions
    {
        private string code;
        private int count;

        public Transactions()
        {
            code = "";
            count = 0;
        }

        public Transactions(string code, int count)
        {
            this.code = code;
            this.count = count;
        }

        public void DisplayData()
        {
            Console.WriteLine("Code = " + code + ", count = " + count);
        }

        public string GetCode()
        {
            return code;
        }

        public int GetCount()
        {
            return count;
        }
    }
}
