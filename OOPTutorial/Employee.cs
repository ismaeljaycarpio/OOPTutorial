using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTutorial
{
    class Employee
    {
        //class fields to ensure that data manipulation only exist in the class
        private int _empID;
        private string _loginName;
        private string _password;
        private string _department;
        private string _name;

        //constructors
        public Employee()
        {
            _empID = -1;
        }

        public Employee(int empID)
        {
            if(empID == 1)
            {
                _empID = 1;
                LoginName = "Ismael";
                Password = "pa$$word";
                Department = "Admin";
                Name = "Ismael Jay Carpio";
            }
            else if(empID == 2)
            {
                _empID = 2;
                LoginName = "SomeUser";
                Password = "user123";
                Department = "User";
                Name = "Some User";
            }
            else
            {
                throw new Exception("Invalid Employee ID");
            }
        }

        public int EmployeeID
        {
            //read only property
            get { return _empID;  }
        }

        public string LoginName
        {
            get { return _loginName; }
            set { _loginName = value; }
        }

        public string Password
        {
            get { return _password;  }
            set
            {
                if(value.Length >= 6)
                {
                    _password = value;
                }
                else
                {
                    throw new Exception("Password must be atleast 6 characters long");
                }
            }
        }

        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }

        public string Name
        {
            get { return _name;  }
            set { _name = value;  }
        }
  
        public Boolean Login(string loginName, string password)
        {
            if(loginName == "Ismael" && password == "pa$$word")
            {
                _empID = 1;
                Name = "Ismael Jay Carpio";
                Department = "Admin";
                return true;
            }
            else if(loginName == "Some" && password == "administration")
            {
                _empID = 2;
                Name = "Some User";
                Department = "User";
                return true;
            }
            else
            {
                return false;
            }
        }

        public int AddEmployee(string loginName, string password, string department, string name)
        {
            _empID = 3; //should be auto-increment
            LoginName = loginName;
            Password = password;
            Department = department;
            Name = name;
            return EmployeeID;
        }

        public int AddEmployee(string department, string name)
        {
            _empID = 3;
            Department = department;
            Name = name;
            return EmployeeID;
        }

        public void ChangePassword(string password)
        {
            Password = password;
        }
    }
}
