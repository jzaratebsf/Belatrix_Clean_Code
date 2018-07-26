namespace SOLID._02_OpenClosed
{
    public class Employee
    {
        public int ID { get; set; }
        public string EmployeeType { get; set; }
        public string Name { get; set; }

             

        public decimal CalculateBonus(decimal salary)
        {
            if (this.EmployeeType == "Permanent")
                return salary * .1M;
            else
                return salary * .05M;
        }
    }

    public interface IEmployeeUpdate
    {
        EmployeeUpdate();
    }
    public void EmployeeUpdate(int id, string name, string type)
    {
        this.ID = id;
        this.Name = name;
        this.EmployeeType = type;
    }
}