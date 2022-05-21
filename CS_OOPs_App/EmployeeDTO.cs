using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CS_OOPs_App
{
    /// <summary>
    /// Entity class / DTO / VO
    /// </summary>
    public class EmployeeDTO
    {
        private string[] departments = new string[] { "IT", "HR", "SL", "TR" };
        private int _EmpNo;
        public int EmpNo
        {
            get { return _EmpNo; }
            set { _EmpNo = value; }
        }
        private string _EmpName;
        public string EmpName
        {
            get { return _EmpName; }
            set { _EmpName = value; }
        }
        private int _Salary;
        public int Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }
        private string _Designation;
        public string Designation 
        {
            get { return _Designation; }
            set
            {
                _Designation = value;
            }
        }
        private string _DeptName;
        public string DeptName
        {
            get { return _DeptName; }
            set
            {
                foreach (string str in departments)
                {
                    if (str != value)
                    {
                        Console.WriteLine("Sorry DeptName is Not acceptable");
                        return;
                    }
                }
                
                _DeptName = value;
            }
        }
    }

}
