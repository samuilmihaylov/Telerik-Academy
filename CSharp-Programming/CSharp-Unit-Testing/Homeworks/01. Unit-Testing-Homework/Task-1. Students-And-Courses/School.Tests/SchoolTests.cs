namespace School.Tests
{
    using Contracts;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Models;
    using System;

    [TestClass]
    public class SchoolTests
    {
        private string schoolName;
        private int courseMaximumCapacity;

        [TestInitialize]
        public void InitializeTest()
        {
            schoolName = "testSchool";
            courseMaximumCapacity = 3;
        }

        [TestMethod]
        public void AddStudent_shouldThrow_ifPassedNullArgument()
        {
            var name = "testStudent";
            IStudent testInputStudent = new Student(name);
            testInputStudent = null;

            ISchool testInputSchool = new School(schoolName);

            Assert.ThrowsException<ArgumentNullException>(() => testInputSchool.AddStudent(testInputStudent));
        }

        [TestMethod]
        public void AddStudent_shouldThrow_ifPassedIfDublicateStudent()
        {
            var name = "testStudent";
            IStudent testInputStudent = new Student(name);

            ISchool testInputSchool = new School(schoolName);

            testInputSchool.AddStudent(testInputStudent);

            Assert.ThrowsException<ArgumentException>(() => testInputSchool.AddStudent(testInputStudent));
        }

        [TestMethod]
        public void RemoveStudent_shouldThrow_ifPassedStudentIsNotFound()
        {
            var name = "testStudent";
            IStudent testInputStudent = new Student(name);

            ISchool testInputSchool = new School(schoolName);

            Assert.ThrowsException<ArgumentException>(() => testInputSchool.RemoveStudent(testInputStudent));
        }

        [TestMethod]
        public void AddCourse_shouldThrow_ifPassedNullArgument()
        {
            var name = "testCourse";
            ICourse testInputCourse = new Course(name, courseMaximumCapacity);
            testInputCourse = null;

            ISchool testInputSchool = new School(schoolName);

            Assert.ThrowsException<ArgumentNullException>(() => testInputSchool.AddCourse(testInputCourse));
        }

        [TestMethod]
        public void AddCourse_shouldThrow_ifPassedIfDublicateCourse()
        {
            var name = "testCourse";
            ICourse testInputCourse = new Course(name, courseMaximumCapacity);

            ISchool testInputSchool = new School(schoolName);

            testInputSchool.AddCourse(testInputCourse);

            Assert.ThrowsException<ArgumentException>(() => testInputSchool.AddCourse(testInputCourse));
        }

        [TestMethod]
        public void RemoveCourse_shouldThrow_ifPassedCourseIsNotFound()
        {
            var name = "testCourse";
            ICourse testInputCourse = new Course(name, courseMaximumCapacity);

            ISchool testInputSchool = new School(schoolName);

            Assert.ThrowsException<ArgumentException>(() => testInputSchool.RemoveCourse(testInputCourse));
        }
    }
}
