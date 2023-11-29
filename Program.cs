using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinqOperations
{
    public class Program
    {
      
        public static void Main(string[] args)
        {
            string[] stringArray = { 
                "ABCDEFGHIJKLMNOPQQRSTUVWXYZ","0123456789"
            };
            List<int> numbers = new List<int> {1,2,3,4,5,6,7,8,9,10};
            //func<int, bool> predicate = x = x % 2 == 0;
            int[] Numbers = {2, 3, 4, 5};
            string[] countries = {"India","USA","UK","Canada","Australia"};
            Console.WriteLine("Enter the Number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            switch (y)
            {
                case 1:
                int result1 = Numbers.Where(x => x % 2 == 0).Min();
                Console.WriteLine(result1);
                 break;
                    case 2:
                    int result2 = Numbers.Where(x => x % 2 == 0).Max();
                    Console.WriteLine(result2);
                    break;
                case 3:
                    int result3 = Numbers.Where(x => x % 2 == 1).Sum();
                    Console.WriteLine(result3);
                    break;
                case 4:
                    int result4 = Numbers.Where(x => x % 2 == 0).Count();
                    Console.WriteLine(result4);
                    break;
                case 5:
                    double result5 = Numbers.Where(x => x % 2 == 0).Average();
                    Console.WriteLine(result5);
                    break;
                case 6:
                    
                    Console.WriteLine("{0}",countries.Max(country => country.Length));
                    break;
                case 7:
                    string result7 = countries.Aggregate((a,b) => a + " , " + b);
                    Console.WriteLine(result7);
                    break;
                case 8:
                    double prod = Numbers.Aggregate(10,(a, b) => a * b);
                    Console.WriteLine(prod);
                    break;
                case 9:
                   IEnumerable<int> evenNumbers = from num in numbers
                                                  where num % 2 == 0
                                                  select num;
                    foreach (var item in evenNumbers)
                    {
                        Console.Write(item+" ");
                    }
                break;
                case 10:
                    var evenNumbers1 = numbers.Select((num, index) => new { Number = num, Index = index })
                                       .Where(x => x.Number % 2 == 0)
                                        .Select(x => x.Index);
                    foreach (var item in evenNumbers1)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case 11:
                    // IEnumerable<int> result = Employee.GetAllEmployees().Select(emp => emp.EmployeeID);
                    // var result = Employee.GetAllEmployees().Select(emp => new {firstName = emp.FirstName,Gender = emp.Gender });
                    //var result = Employee.GetAllEmployees().Select(emp => new { fullName = emp.FirstName +" " + emp.LastName, monthleySalary = emp.AnnualSalary / 12 });
                    var result = Employee.GetAllEmployees().Where(x => x.AnnualSalary > 5000 )
                        .Select(emp => new {Name = emp.FirstName, AnnualSalary = emp.AnnualSalary,Bonus = emp.AnnualSalary * .1});
                    foreach (var id in result)
                    {
                        Console.WriteLine(id.Name+" : " +id.AnnualSalary +" : " + id.Bonus);

                    }
                    break;
                case 12:
                    //  IEnumerable<string> res = Student.GetAllStudents().SelectMany(s => s.subjects);
                    IEnumerable<string> res = from student in Student.GetAllStudents()
                                              from subject in student.subjects
                                              select subject;

                    foreach (var subjects in res)
                    {
                        Console.WriteLine(subjects);
                    }
                    break;
                case 13:
                     IEnumerable<char> re1 = stringArray.SelectMany(s => s).Distinct();
                   // IEnumerable<char> re1 = from s in stringArray
                                           // from c in s
                                            //select c;

                    foreach (var c in re1)
                    {
                        Console.WriteLine(c);
                    }
                    break;
                    default: Console.WriteLine("case don't match");
                    break;
            }
          
            Console.ReadLine();
        }
        private static bool IsEven(int num)
        {
            return num % 2 == 0;    
        }
    }
}
