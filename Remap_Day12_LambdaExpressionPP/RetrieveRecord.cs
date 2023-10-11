using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_Day12_LambdaExpressionPP
{
    internal class RetrieveRecord
    {
        public static void RetrieveTopTwoRecordsByLinq(List<Student> list)
        {
            List<Student> Top3Records = list.Where(student => student.Age >= 12 && student.Age <= 18).ToList();
            Program.DisplayStudentSetails(Top3Records);
        }

        public static void SortingDataByDescending(List<Student> list)
        {
            List<Student> SortBasedOnTotalMarks = list.OrderByDescending(Student => Student.TotalMarks).ToList();
            Program.DisplayStudentSetails(SortBasedOnTotalMarks);
        }
        public static void StudentRecordInEachAddress(List<Student>list, string StudentAddress )
        {
            List<Student> StudentDataOnAddress = list.Where(student => student.Address == StudentAddress).ToList();
            Program.DisplayStudentSetails(StudentDataOnAddress);
        }
        public static void FirstThreeRecord(List<Student> list)
        {
            List<Student> FirstThreeRecords = list.Select(student => student).Take(3).ToList();
            Program.DisplayStudentSetails(FirstThreeRecords);
        }
        public static void StudentRecordBasedOnName(List<Student> list, string Studentname)
        {
            List<Student> RecordBasedOnName = list.Where(student => student.Name == Studentname).ToList();
            Program.DisplayStudentSetails(RecordBasedOnName);
        }
    }
}
