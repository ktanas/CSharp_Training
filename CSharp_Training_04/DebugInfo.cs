

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training_04
{
    public class DebugInfo : Attribute
    {
        private int codeNumber;
        private string developerName;
        private string lastReviewData;
        public string? message;
        public DebugInfo(int code, string dev, string d)
        {
            this.codeNumber = code;
            this.developerName = dev;
            this.lastReviewData = d;
        }
        public int CodeNumber
        {
            get
            {
                return codeNumber;
            }
        }
        public string DeveloperName
        {
            get
            {
                return developerName;
            }
        }
        public string LastReviewData
        {
            get
            {
                return lastReviewData;
            }
        }
    }
}
