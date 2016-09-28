namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Contracts;
    using Models;

    [TestClass]
    public class StudentTests
    {
        private ICourse testInputCourse;
        private IStudent testInputStudent;

        [TestMethod]
        public void Name_shouldThrow_ifPassedNameIsNullOrEmpty()
        {
            var testInputStudentName = "";

            Assert.ThrowsException<ArgumentException>(() => new Student(testInputStudentName));
        }

        [TestMethod]
        public void JoinCourse_shouldThrowArgumentNullException_ifPassedCourseObjectIsNull()
        {
            var testInputStudentName = "testStudent";
            this.testInputStudent = new Student(testInputStudentName);
            this.testInputCourse = null;

            Assert.ThrowsException<ArgumentNullException>(() => this.testInputStudent.JoinCourse(this.testInputCourse));
        }

        [TestMethod]
        public void LeaveCourse_shouldThrow_ifPassedCourseObjectIsNull()
        {
            var testInputStudentName = "testStudent";
            this.testInputStudent = new Student(testInputStudentName);
            this.testInputCourse = null;

            Assert.ThrowsException<ArgumentNullException>(() => this.testInputStudent.LeaveCourse(testInputCourse));
        }

        [TestMethod]
        public void JoinCourse_shouldThrow_ifPassedCourseHasFullCapacity()
        {
            var testInputCourseName = "testCourse";
            var testInputCourseMaximumCapacity = 1;
            this.testInputCourse = new Course(testInputCourseName, testInputCourseMaximumCapacity);

            var testInputStudentName = "testStudent1";
            this.testInputStudent = new Student(testInputStudentName);

            this.testInputStudent.JoinCourse(testInputCourse);

            var secondStudentName = "testStudent2";
            this.testInputStudent = new Student(secondStudentName);
        
            Assert.ThrowsException<ArgumentException>(() => this.testInputStudent.JoinCourse(testInputCourse));
        }

        [TestMethod]
        public void JoinCourse_shouldThrow_ifTheStudentCallerIsAlreadySignedUpForTheCourse()
        {
            var testInputStudentName = "testStudent";
            this.testInputStudent = new Student(testInputStudentName);

            var testInputCourseName = "testCourse";
            var testInputCourseMaximumCapacity = 3;
            this.testInputCourse = new Course(testInputCourseName, testInputCourseMaximumCapacity);

            this.testInputStudent.JoinCourse(this.testInputCourse);
            
            Assert.ThrowsException<ArgumentException>(() => this.testInputStudent.JoinCourse(this.testInputCourse));
        }

        [TestMethod]
        public void LeaveCourse_shouldThrow_ifThisStudentIsNotOnTheListOfStudentsForTheCourse()
        {
            var testInputStudentName = "testStudent";
            this.testInputStudent = new Student(testInputStudentName);

            var testInputCourseName = "testCourse";
            var testInputCourseMaximumCapacity = 30;
            this.testInputCourse = new Course(testInputCourseName, testInputCourseMaximumCapacity);

            Assert.ThrowsException<ArgumentException>(() => this.testInputStudent.LeaveCourse(this.testInputCourse));
        }
    }
}
