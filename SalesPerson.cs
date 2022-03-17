using System;

namespace Midterm_Project{
    public class SalesPerson : Employee{

        private string department;
        private float totalSales;
        private SalesLevel sales;

        public string Department{
            get {return department;}
            set {department = value;}
        }
        public float TotalSales{
            get {return totalSales;}
            set {totalSales = value;}
        }
        public SalesPerson(string firstName, string lastName, string id, string department, float totalSales) : base(firstName, lastName, id, EmployeeType.Sales){
            this.department = department;
            this.totalSales = totalSales;
        }
        public float getSales()
        {
            return totalSales;
        }
        public void updateSales(float newSales){
            this.TotalSales += newSales;
        }
        public SalesLevel GetSalesLevel(){
            if (this.totalSales > 40000){
                return SalesLevel.Platnium;
            }
            else if (this.totalSales > 30000){
                return SalesLevel.Diamond;
            }
            else if(this.totalSales > 20000){
                return SalesLevel.Gold;
            }
            else if(this.totalSales > 10000){
                return SalesLevel.Silver;
            }
            else{
                return SalesLevel.Bronze;
            }
        }

    }
}