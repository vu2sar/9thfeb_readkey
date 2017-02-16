using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9thfeb_readkey
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNum1=0;
            Console.Write("Enter one number: ");
            iNum1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The entered key is: {0}",iNum1);
            StringBuilder sc = new StringBuilder();
            sc.Append("Hello Sarang! \n");
            sc.AppendLine("The Format is wrong");
            Console.WriteLine(sc);
        }
    }
}
