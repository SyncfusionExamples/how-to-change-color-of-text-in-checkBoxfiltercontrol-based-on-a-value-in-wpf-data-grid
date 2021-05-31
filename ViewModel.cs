using System.Data;

namespace SfDataGridDemo
{
    public class ViewModel
    {
        private DataTable employeeCollection;

        public ViewModel()
        {
            this.EmployeeDetails = this.GetTable();
        }

        public DataTable EmployeeDetails
        {
            get { return employeeCollection; }
            set { employeeCollection = value; }
        }

        public DataTable GetTable()
        {
            EmployeeDetails = new DataTable();
            EmployeeDetails.Columns.Add("EmployeeID", typeof(int));
            EmployeeDetails.Columns[0].ColumnName = "Employee ID";
            EmployeeDetails.Columns.Add("EmployeeName", typeof(string));
            EmployeeDetails.Columns[1].ColumnName = "Employee Name";
            EmployeeDetails.Columns.Add("CustomerID", typeof(string));
            EmployeeDetails.Columns[2].ColumnName = "Customer ID";
            EmployeeDetails.Columns.Add("Country", typeof(string));            
            EmployeeDetails.Columns.Add("Colors", typeof(string));           

            EmployeeDetails.Rows.Add(1001, "Belgim", "Britain", "US", "LightBlue");
            EmployeeDetails.Rows.Add(1002, "Oliver", "Oregon", "UK", "Red");
            EmployeeDetails.Rows.Add(1003, "Bernald", "Alfki", "US", "Green");
            EmployeeDetails.Rows.Add(1004, "James", "Anatr", "Chicago", "Yellow");
            EmployeeDetails.Rows.Add(1005, "Beverton", "Bergs", "Spain", "Pink");
            EmployeeDetails.Rows.Add(1006, "Fransis", "Alfki", "US", "LightBlue");
            EmployeeDetails.Rows.Add(1007, "George", "Oregon", "SwitzerLand", "Red");
            EmployeeDetails.Rows.Add(1008, "Dintin", "Britain", "Britain", "Green");
            EmployeeDetails.Rows.Add(1009, "Diano", "Alfki", "Britain", "Yellow");
            EmployeeDetails.Rows.Add(1010, "Joysie", "Oregon", "China", "Pink");
            return EmployeeDetails;
        }
    }
}
