using System;
using System.Reflection;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        public override string ToString()
        {
            string result = "\n";
            result += $"\nID: {Id}"; 

            if (string.IsNullOrEmpty(Name))
            {
                result += "\nName: Data not available";
            }
            else
            {
                result += $"\nName: {Name}";
            }
            if (EmployerName is null || string.IsNullOrEmpty(EmployerName.ToString()))
            {
                result += "\nEmployer: Data not available";
            }
            else
            {
                result += $"\nEmployer: {EmployerName}";
            }
            if (EmployerLocation is null || string.IsNullOrEmpty(EmployerLocation.ToString()))
            {
                result += "\nLocation: Data not available";
            }
            else
            {
                result += $"\nLocation: {EmployerLocation}";
            }
            if (JobType is null || string.IsNullOrEmpty(JobType.ToString()))
            {
                result += "\nPosition Type: Data not available";
            }
            else
            {
                result += $"\nPosition Type: {JobType}";
            }
            if (JobCoreCompetency is null || string.IsNullOrEmpty(JobCoreCompetency.ToString()))
            {
                result += "\nCore Competency: Data not available";
            }
            else
            {
                result += $"\nCore Competency: {JobCoreCompetency}";
            }
            result += "\n";
            return result;
        }
        // TODO: Generate Equals() and GetHashCode() methods.

    }
}
