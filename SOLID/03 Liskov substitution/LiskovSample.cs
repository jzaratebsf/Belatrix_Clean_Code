using System;

namespace SOLID._03_Liskov_substitution
{
    public abstract class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Employee()
        {
        }

        public Employee(int id, string name)
        {
            this.ID = id; this.Name = name;
        }

        public abstract decimal CalculateBonus(decimal salary);

        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
        }
    }

    public class PermanentEmployee : Employee
    {
        
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }

    public class TemporaryEmployee : Employee
    {
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }
    }

    public class ContractEmployee : Employee
    {
        public override decimal CalculateBonus(decimal salary)
        {
            throw new NotImplementedException();
        }
    }
}
