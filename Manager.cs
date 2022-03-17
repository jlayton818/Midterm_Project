using System;
namespace Midterm_Project{
    public class Manager : Employee{
        private string department, region;
        public string Department{
            get {return department;}
            set {department = value;}
        }
        public string Region{
            get {return region;}
            set {region = value;}
        }
        
        public Manager(string firstName, string lastName, string id, string department, string region) : base(firstName, lastName, id, EmployeeType.Manager){
            this.region = region;
            this.department = department;
        }
        public string getRegion(){
            return Region;
        }
        public string getDepartment(){
            return Department;
        }
        public void setFirstName(string firstName){
            this.FirstName = firstName;
        }
        public void setLastName(string lastName){
            this.LastName = lastName;
        }
        public void setRegion(string region){
            this.Region = region;
        }
        public void setDepartment(string department){
            this.Department = department;
        }
        public string getLastName(){
            return this.LastName;
        }
        public string getFirstName(){
            return this.FirstName;
        }
    }
}