using System;
using System.Collections.Generic;
using System.Dynamic;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Text;
//using System.Threading.Tasks;
using Utility;

namespace Practise
{

    class Program
    {

        static void Main()
        {
            //for extend method
            //MainFunction _mainfunc = new MainFunction();
            //_mainfunc.NewMethod();
            //List<long> test = new List<long>();
            //test.Add(3);
            //test.Add(4);
            //test.toCsv();

            IPractise _objpractise = new ParamTest();
            _objpractise.Test();

            //C obj = new C();
            //obj.abc();

            //Test.write();
            //Test t = new Test();
            //Test.write();


        }

    }    
}
