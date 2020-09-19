using System;
using System.Xml;

namespace XmlHandler
{
	class Program
	{
		static void Main(string[] args)
		{
			StudentService studentService = new StudentService();

			switch (args[1]) {
				case "highest-grade":
					Console.WriteLine(studentService.highestGrade(args[0]));
					break;
				case "lowest-grade":
					Console.WriteLine(studentService.lowestGrade(args[0]));
					break;
				case "approved-students":
					Console.WriteLine(studentService.approvedStudents(args[0]));
					break;
				case "failed-students":
					Console.WriteLine(studentService.failedStudents(args[0]));
					break;
				default:
					Console.WriteLine("Nothing");
					break;
			}
			
		}
	}
}
