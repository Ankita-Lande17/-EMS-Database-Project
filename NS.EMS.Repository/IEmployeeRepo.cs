using NS.EMS.Data.Entities;
using NS.EMS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NS.EMS.Repository
{
    public interface IEmployeeRepo
    {
        //bool AddEmployee(EmployeeModel employeeModel);

        bool AddEmployee(EmployeeDtModel EmpDept);

        // List<Employee> ShowDetail();

        List<EmployeeDtModel> ShowDetail();
        // bool UpdateEmployee(EmployeeModel employeeModel, int id);
        //bool UpdateEmployee(int id);


        List<EmployeeDtModel> UpdateEmployee(int id);
        bool FinalUpdate(EmployeeDtModel EmpDept);

        List<EmployeeDtModel> DeleteEmployee(int id);
        //bool FinalDelete(EmpDeptModel EmpDept);

        bool FinalDelete(EmployeeDtModel EmpDept);
    }
}
