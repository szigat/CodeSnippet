using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CodeSnippet
{
    class Program
    {
        [DataMember]
        public string MyProperty { get; set; }

        static void Main(string[] args)
        {
        }
    }
}
