using NS.EMS.Data.Entities;
using NS.EMS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NS.EMS.Business
{
    public interface IEmployeeBusiness
    {
        bool AddEmployee(EmployeeDtModel EmpDept);

        List<EmployeeDtModel> ShowDetail();
        List<EmployeeDtModel> UpdateEmployee(int id);
        bool FinalUpdate(EmployeeDtModel EmpDept);
        List<EmployeeDtModel> DeleteEmployee(int id);
        bool FinalDelete(EmployeeDtModel EmpDept);
    }
}
