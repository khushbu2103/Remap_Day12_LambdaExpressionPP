using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day12_LambdaExpressionPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>
            {
                new Student(){Id = 1, Name = "Khushi", MobileNumber = 8619532017, Address = "Gujrat", Age = 27, TotalMarks = 70},
                new Student(){Id = 2, Name = "Raj", MobileNumber = 8306161085, Address = "Rajasthan", Age = 18, TotalMarks = 90},
                new Student(){Id = 3, Name = "Twinke", MobileNumber = 9619532017, Address = "Mumbai", Age = 17, TotalMarks = 69},
                new Student(){Id = 4, Name = "Priya", MobileNumber = 730953209, Address = "Gujrat", Age = 15, TotalMarks = 55},
                new Student(){Id = 5, Name = "Ankit", MobileNumber = 786564554, Address = "Hariyana", Age = 70, TotalMarks = 85}
            };

            Console.WriteLine("Choose any program");
            Console.WriteLine("1.Displaying existing data\n" +
                "2.Retrieve all records for age between 12 to 18 by linq\n" +
                "3.Sorted student data based on total marks\n" +
                "4.Students record in each address\n" +
                "5.Retrieve first 3 records\n" +
                "6.Student record based on perticular name");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Console.WriteLine("Displaying existing data");
                    DisplayStudentSetails(list);
                    break;
                case 2:
                    Console.WriteLine("\nRetrieve all records for age between 12 to 18 by linq");
                    RetrieveRecord.RetrieveTopTwoRecordsByLinq(list);
                    break;
                case 3:
                    Console.WriteLine("\nSorted student data based on total marks");
                    RetrieveRecord.SortingDataByDescending(list);
                    break;
                case 4:
                    Console.WriteLine("\nStudents record in each address");
                    RetrieveRecord.StudentRecordInEachAddress(list, "Gujrat");
                    RetrieveRecord.StudentRecordInEachAddress(list, "Rajasthan");
                    RetrieveRecord.StudentRecordInEachAddress(list, "Hariyana");
                    RetrieveRecord.StudentRecordInEachAddress(list, "Mumbai");
                    break;
                case 5:
                    Console.WriteLine("Displaying existing data");
                    DisplayStudentSetails(list);
                    Console.WriteLine("\nRetrieve first 3 records");
                    RetrieveRecord.FirstThreeRecord(list);
                    break;
                case 6:
                    Console.WriteLine("\nStudent record based on perticular name");
                    RetrieveRecord.StudentRecordBasedOnName(list, "Khushi");
                    RetrieveRecord.StudentRecordBasedOnName(list, "Raj");
                    break;
            }
            Console.ReadLine();

        }
        public static void DisplayStudentSetails(List<Student> list)
        {
            
            foreach (Student student in list)
            {
                Console.WriteLine(student.ToString());
            }
           
        }

    }
}
