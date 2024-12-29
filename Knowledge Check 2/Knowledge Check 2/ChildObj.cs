using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowledge_Check_2
{
    public class ChildObj : MyClass
    {
    
        public string? Data { get;set; }
        public override string ToString()
        {
            return $"{Data} - Data {ID} - ID";
        }
    }
}
