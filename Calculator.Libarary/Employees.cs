using System.Text.RegularExpressions;


namespace Calculator.Libarary
{
    public class Employee
    {
        public string Name { get; set; }
        private string _email;

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(value);
                if (match.Success)
                {
                    _email = value;
                }
                else
                {
                    throw new System.Exception("Invalid Email");
                }
            }
        }
    }
}

/*
 Create Table EmployeeUT
(
Name nvarchar(50),
Email nvarchar(50)
)

Insert into EmployeeUT values ('David', 'David@aaa.com')
Insert into EmployeeUT values ('Sam', 'Sam@aaa.com')
Insert into EmployeeUT values ('Tom', 'Tom@aaa.com')
Insert into EmployeeUT values ('Mike', 'Mike@aaa.com')
Insert into EmployeeUT values ('Pam', 'Pam@aaa.com')
Insert into EmployeeUT values ('Sam', 'Sam@aaa.com')
Insert into EmployeeUT values ('Todd', 'Toddaaa.com')
Insert into EmployeeUT values ('Alex', 'Alex@aaa.com')
Insert into EmployeeUT values ('Mark', 'Mark@aaa.com')
Insert into EmployeeUT values ('Simon', 'Simon@aaa.com')
 */
