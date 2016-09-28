namespace School.Tests
{
    using Contracts;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Models;
    using System;

    [TestClass]
    public class CourseTests
    {
        private string courseName;
        private int courseMaximumCapacity;

        [TestInitialize]
        public void InitializeIdGenerator()
        {
            courseName = "courseName";
            courseMaximumCapacity = 3;
        }

        [TestMethod]
        public void AddStudentToCourse_shouldThrow_ifCourseHasMaximumAllowedStudentsEnrolled()
        {
            // Arrange
            var studentName = "studentName";
            ICourse testCourse = new Course(courseName, courseMaximumCapacity);

            // Act
            for (int i = 0; i < courseMaximumCapacity; i++)
            {         
                IStudent testInputStudent = new Student(studentName);
                testCourse.AddStudentToCourse(testInputStudent);
            }

            // Assert
            Assert.ThrowsException<ArgumentException>(() => testCourse.AddStudentToCourse(new Student(studentName)));
        }

        [TestMethod]
        public void AddStudentToCourse_shouldThrow_ifPassedADuplicateStudent()
        {
            var name = "studentName";
            IStudent testInputStudent = new Student(name);

            ICourse testCourse = new Course(courseName, courseMaximumCapacity);

            testCourse.AddStudentToCourse(testInputStudent);     

            Assert.ThrowsException<ArgumentException>(() => testCourse.AddStudentToCourse(testInputStudent));
        }

        [TestMethod]
        public void AddStudentToCourse_shouldThrow_ifPassedANullArgument()
        {
            IStudent testInputStudent = null;

            ICourse testCourse = new Course(courseName, courseMaximumCapacity);

            Assert.ThrowsException<ArgumentNullException>(() => testCourse.AddStudentToCourse(testInputStudent));
        }

        [TestMethod]
        public void RemoveStudentFromCourse_shouldThrow_ifPassedStudentIsNotFound()
        {
            var name = "studentName";
            IStudent testInputStudent = new Student(name);

            ICourse testCourse = new Course(courseName, courseMaximumCapacity);

            Assert.ThrowsException<ArgumentException>(() => testCourse.RemoveStudentFromCourse(testInputStudent));
        }

        [TestMethod]
        public void RemoveStudentFromCourse_shouldReturnTrue_ifPassedANullArgument()
        {
            IStudent testInputStudent = null;

            ICourse testCourse = new Course(courseName, courseMaximumCapacity);

            Assert.ThrowsException<ArgumentNullException>(() => testCourse.RemoveStudentFromCourse(testInputStudent));
        }
    }
}
