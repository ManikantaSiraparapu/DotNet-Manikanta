using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinQ
{
    internal class demo4
    {
        static void Main()
        {
            List<Employee> l = new List<Employee>()
            {
                new Employee(){Id=1,Name="Mani",JoinDate=new DateTime(2021,12,23),Salary=30000,Designation="Sr Developer"},
                new Employee(){Id=2,Name="Murali",JoinDate=new DateTime(2022,11,21),Salary=40000,Designation="Developer"},
                new Employee(){Id=3,Name="Karthikeya",JoinDate=new DateTime(2020,03,13),Salary=25000,Designation="Sr Tester"},
                new Employee(){Id=4,Name="Charan",JoinDate=new DateTime(2000,08,03),Salary=22000,Designation="Developer"},
                new Employee(){Id=5,Name="Bharat",JoinDate=new DateTime(2012,05,20),Salary=43000,Designation="Sr Manager"},
                new Employee(){Id=6,Name="Nanaji",JoinDate=new DateTime(2019,06,17),Salary=20000,Designation="manager"},
                new Employee(){Id=7,Name="Srinu",JoinDate=new DateTime(2018,11,08),Salary=32000,Designation="Pewn"},
                new Employee(){Id=8,Name="Ranga",JoinDate=new DateTime(2019,09,14),Salary=19000,Designation="Cloud engineer"},
                new Employee(){Id=9,Name="Dinesh",JoinDate=new DateTime(2016,10,11),Salary=9000,Designation="Salesman"},
                new Employee(){Id=10,Name="deepak",JoinDate=new DateTime(2002,08,15),Salary=80000,Designation="Business Analyst"},
                new Employee(){Id=11,Name="Lokesh",JoinDate=new DateTime(2023,12,13),Salary=10000,Designation="Scrum master"}
            };
            var r1=from i in l
                   where i.Designation=="Developer"
                   select i;
            // r1 = l.Where(i => i.Designation == "Developer");

            foreach (var item in r1)
            {
                Console.WriteLine($"Id : {item.Id} Name : {item.Name}");
            }
            var r2=from i in l
                   where i.JoinDate.Year==2019
                   select new {i.Id,i.Name};
            r2 = l.Where(i => i.JoinDate.Year == 2019).Select(i => new { i.Id, i.Name });
            foreach (var item in r2)
            {
                Console.WriteLine($"Id : {item.Id} Name : {item.Name}");
            }
            List<Employee> l1=(from i in l
                               where i.Designation=="Developer"
                               select i).ToList();
            l1 = l.Where(e => e.Designation == "programmer").ToList();
            Employee[] l2 = l.Where(e => e.Designation == "programmer").ToArray();
            //using single or singleordefault to written single record
            Employee e1 = l.Where(e => e.Id == 2).Single();//throw exception when id is invalid
            e1 = l.Where(e => e.Id == 2).SingleOrDefault();//return null if id is invalid
            e1 = l.First(e => e.Designation == "programmer");//return first record
            e1 = l.Last(e => e.Designation == "programmer");//return last record
            e1 = l.Where(e => e.Designation == "programmer").FirstOrDefault();//return null if designation not found
            e1 = l.Where(e => e.Designation == "programmer").LastOrDefault();//return null if designation not found
            e1 = l.Where(e => e.Designation == "programmer").ElementAt(0);//return element at given index
            var r3 = l.Skip(2).ToList();//skip first two employees
            var r4 = l.Take(3).ToArray();//take first three employeess
            //grouping ahe data
            var g1 = from e in l
                     group e by e.Designation;
            foreach(var items in g1)
            {
                Console.WriteLine($"Designation: {items.Key} Count: {items.Count()}");
            }
            Console.WriteLine();
            foreach(var items in g1)
            {
                Console.WriteLine($"Employees Working as {items.Key}");
                foreach(var item in items)
                {
                    Console.WriteLine($"Id: {item.Id} Name={item.Name}");
                }
            }
        }
    }
}
