using TechJobsOO;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
           
            Assert.AreNotEqual(job1.Id, job2.Id);
            Assert.AreEqual(job1.Id + 1, job2.Id);
        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job c_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            
            Assert.AreEqual("Product tester", c_job.Name);
            Assert.AreEqual("ACME", c_job.EmployerName.ToString());
            Assert.AreEqual("Desert", c_job.EmployerLocation.ToString());
            Assert.AreEqual("Quality control", c_job.JobType.ToString());
            Assert.AreEqual("Persistence", c_job.JobCoreCompetency.ToString());
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Job c_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job a_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsFalse(a_job.Equals(c_job));
        }
        [TestMethod]
        public void TestJobToStringReturnsBlankLines()
        {
            Job a_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsTrue(a_job.ToString().StartsWith("\n"));
            Assert.IsTrue(a_job.ToString().EndsWith("\n"));
        }
        [TestMethod]
        public void TestJobToStringReturnsFields()
        {
            Job c_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual($"\n\nID: {c_job.Id}\nName: Product tester\nEmployer: ACME\nLocation: Desert\nPosition Type: Quality control\nCore Competency: Persistence\n", c_job.ToString());
        }
        [TestMethod]
        public void TestJobToStringReturnsNoDataForEmptyFields()
        {
            Job job1 = new Job();

            Assert.AreEqual($"\n\nID: {job1.Id}\nName: Data not available\nEmployer: Data not available\nLocation: Data not available\nPosition Type: Data not available\nCore Competency: Data not available\n", job1.ToString());
        }
    }
}
