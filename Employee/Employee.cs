using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class Employee
    {
        private string _Id;
        private string _Name;
        private string _DepartmentName;

        public delegate void EmpMessageFired(string message);

        public Employee(string Id, string Name, string DepartmentName)
        {
            _Id = Id;
            _Name = Name;
            _DepartmentName = DepartmentName;
        }
        public string GetId()
        {
            MessageFired(_Id);
            return _Id;
        }
        public string GetName()
        {
            MessageFired2(_Name);
            return _Name;
        }
        public string GetDepartmentName()
        {
            MessageFired3(_DepartmentName);
            return _DepartmentName;
        }
        public event EmpMessageFired MessageFired;
        public event EmpMessageFired MessageFired2;
        public event EmpMessageFired MessageFired3;

        public void update(string msg)
        {
            //was confused how to create an overloaded method for two string variables.
        }
    }
}
