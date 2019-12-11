using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    delegate bool IsPromatable(Employee emp);
    class del:IPractise
    {
        

        public void Test()
        {
            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee { Id=1, Name="Srinivasa",Exp=3,Sal=2000});
            empList.Add(new Employee { Id=2, Name="Srinivasa2",Exp=2,Sal=4000});
            empList.Add(new Employee { Id=3, Name="Srinivasa3",Exp=5,Sal=1500});
            empList.Add(new Employee { Id=4, Name="Srinivasa4",Exp=6,Sal=5000});

            Employee.PromoteEmployee(empList, emp => emp.Exp < 3);
        }
    }

    class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Exp { get; set; }

        public decimal Sal { get; set; }

        public static void PromoteEmployee(List<Employee> empList,IsPromatable isEligibleforPromotion)
        {
            foreach(var emp in empList)
            {
                if(isEligibleforPromotion(emp))
                    Console.WriteLine(emp.Name+" Promoted");
            }
        }
    }
}
