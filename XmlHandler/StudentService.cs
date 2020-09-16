using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace XmlHandler
{
    public class StudentService
    {
        int minimunGrade = 0;
        int maximunGrade = 10;
        int averageGrade = 7;

        public StudentService() { }

        public String highestGrade(String xmlString) {
            int highest = minimunGrade;
            Student studentWithHighestNote = null;
            List<Student> studentsList = convertToList(xmlString);
            foreach (Student student in studentsList) {
                if (student.Grade > highest) {
                    highest = student.Grade;
                    studentWithHighestNote = student;
                }
                
            }
            return studentWithHighestNote.ToString();
        }

        public String lowestGrade(String xmlString) {
            int lowest = maximunGrade;
            Student studentWithLowestNote = null;
            List<Student> studentsList = convertToList(xmlString);
            foreach (Student student in studentsList)
            {
                if (student.Grade < lowest)
                {
                    lowest = student.Grade;
                    studentWithLowestNote = student;
                }

            }
            return studentWithLowestNote.ToString();
        }

        public String approvedStudents(String xmlString) {
            List<String> approvedStudents = new List<String>();
            List<Student> studentsList = convertToList(xmlString);

            foreach (Student student in studentsList)
            {
                if (student.Grade >= averageGrade)
                {
                    approvedStudents.Add(student.Name);
                }

            }

            return String.Join(", ", approvedStudents);
        }

        public String failedStudents(String xmlString)
        {
            List<String> failedStudents = new List<String>();
            List<Student> studentsList = convertToList(xmlString);

            foreach (Student student in studentsList)
            {
                if (student.Grade < averageGrade)
                {
                    failedStudents.Add(student.Name);
                }

            }

            return String.Join(", ", failedStudents);

        }

        public List<Student> convertToList(String xmlString) {
            var doc = XDocument.Load(xmlString);
            List<Student> studentsList = doc.Root
                .Descendants("student")
                .Select(node => new Student
                {
                    Name = node.Element("name").Value,
                    Grade = int.Parse(node.Element("grade").Value)
                })
                .ToList();

            return studentsList;
        }
    }
}