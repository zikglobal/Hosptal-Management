namespace Hospital.Models
{
    public class Payroll
    {
        public int Id { get; set; }
        public ApplicationUser EmployeeId { get; set; }
        public decimal Salary { get; set; }
        public decimal NetSalary { get; set; }
        public decimal HourlySalary { get; set; }
        public decimal BonusSalary { get; set; }
        public decimal Compasation { get; set; }
        public string AccountNumber { get; set; }
    }
}