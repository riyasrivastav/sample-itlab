using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace call_by_value
{
    class Program
    {
       
        public void Show(int val)
        {
            val *= val;  
            Console.WriteLine("Value inside the show function " + val);
             
        }
        
        static void Main(string[] args)
        {
            int x = 50;
            Program program = new Program();   
            Console.WriteLine("Value before calling the function " + x);
            program.Show(x);            
            Console.WriteLine("Value after calling the function " + x);
            Console.ReadLine();
        }
    }
}
