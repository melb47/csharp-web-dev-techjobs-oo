using TechJobsOO;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        Job job1;
        Job job2;
        Job c_job;
        Job a_job;
        [TestInitialize]
        public void CreateJobObjects()
        {
            job1 = new Job();
            job2 = new Job();
            c_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            a_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        }
        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.AreNotEqual(job1.Id, job2.Id);
            Assert.AreEqual(job1.Id + 1, job2.Id);
        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product tester", c_job.Name);
            Assert.AreEqual("ACME", c_job.EmployerName.ToString());
            Assert.AreEqual("Desert", c_job.EmployerLocation.ToString());
            Assert.AreEqual("Quality control", c_job.JobType.ToString());
            Assert.AreEqual("Persistence", c_job.JobCoreCompetency.ToString());
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.AreEqual(false, a_job == c_job);
        }
        [TestMethod]
        public void TestJobToStringReturnsBlankLines()
        {
            Assert.AreEqual("\n \n", a_job.ToString());
        }
    }
}
