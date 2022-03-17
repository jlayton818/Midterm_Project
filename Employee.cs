using System;

namespace Midterm_Project{
    public class Employee{
        private string firstName, lastName, id;
        private EmployeeType type;

        public string FirstName{
            get {return firstName;}
            set {firstName = value;}
        }
        public string LastName{
            get {return lastName;}
            set {lastName = value;}
        }
        public EmployeeType EmployeeType {
            get {return type;}
            set {type = value;}
        }
        public string ID{
            get {return id;}
            set {id = value;}
        }
        
        public Employee(string firstName, string lastName, string id, EmployeeType type)
        {
            this.type = type;
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
        }
        public void getEmployeeInfo(){

            Console.WriteLine($"Name : {this.firstName}{this.lastName}");
            Console.WriteLine($"ID : {this.id}");
            Console.WriteLine($"Type : \"{this.EmployeeType}\"");
        }

    }
}