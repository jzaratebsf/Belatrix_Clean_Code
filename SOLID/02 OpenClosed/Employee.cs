using SOLID._02_OpenClosed;

namespace SOLID._02_OpenClosed
{
    public class  Employee
    {
        public int ID { get; set; }
        public string EmployeeType { get; set; }
        public string Name { get; set; }      
                
    }    

    public class newEmployee : Employee
    {
        private Employee worker = new Employee();

        void createEmployee(Employee worker, int id, string name, string type)
        {
            worker.ID = id;
            worker.Name = name;
            worker.EmployeeType = type;
        }
    }

    public class CalculateBonusEmployee : Employee
    {
        decimal CalculateBonus(decimal salary)
        {
            if (this.EmployeeType == "Permanent")
                return salary * .1M;
            else
                return salary * .05M;
        }
    }
}
