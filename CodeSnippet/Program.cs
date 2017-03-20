using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            using (SqlConnection connection = new SqlConnection(""))
            {
                //
            }
            
        }
    }
}
