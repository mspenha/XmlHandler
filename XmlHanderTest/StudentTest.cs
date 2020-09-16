using NUnit.Framework;
using System;


namespace NUnitTestProject1
{
    [TestFixture]
    public class Tests
    {
        XmlHandler.StudentService studentService = new XmlHandler.StudentService();
        String xmlFilePath = "C:\\Users\\Marcos Penha\\Documents\\Curso .Net\\XmlHandler\\XmlHandler\\students.xml";

        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void highestGrade()
        {
            Assert.AreEqual("Mateus, 10", studentService.highestGrade(xmlFilePath));
        }


        [Test]
        public void lowestGrade()
        {
            Assert.AreEqual("Carla, 3", studentService.lowestGrade(xmlFilePath));
        }

        [Test]
        public void approvedStudents()
        {
            Assert.AreEqual("Mateus, Marcos, Carlos", studentService.approvedStudents(xmlFilePath));
        }

        [Test]
        public void failedStudents()
        {
            Assert.AreEqual("Felipe, Cris, Lucas, Carla", studentService.failedStudents(xmlFilePath));
        }
    }
}