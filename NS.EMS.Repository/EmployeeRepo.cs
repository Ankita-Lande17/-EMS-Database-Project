using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NS.EMS.Data.Entities;
using NS.EMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NS.EMS.Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {
       public bool AddEmployee(EmployeeDtModel EmpDept)
        {
            using (var context = new EmployeeDBContext())
            {
                var paraamList = new List<SqlParameter>();
                paraamList.Add(new SqlParameter("@EmployeeName", EmpDept.EmployeeName));
                paraamList.Add(new SqlParameter("@Email", EmpDept.Email));
                paraamList.Add(new SqlParameter("@Mobile", EmpDept.Mobile));
                paraamList.Add(new SqlParameter("@Gender", EmpDept.Gender));
                
                paraamList.Add(new SqlParameter("@DeptId", EmpDept.DeptId));
                context.Database.ExecuteSqlRaw("usp_AddEmployee @EmployeeName, @Email, @Mobile, @Gender, @DeptId", paraamList);

            }
            return true;
        }

        public List<EmployeeDtModel> ShowDetail()
        {
            List<EmployeeDtModel> returnList = new List<EmployeeDtModel>();
            using (var context = new EmployeeDBContext())
            {
                var detail = context.EmpDept.FromSqlRaw("usp_GetEmployee").ToList();
                Console.WriteLine("Ankita");
                
                returnList = detail;
            }
            return returnList;
        }



        public List<EmployeeDtModel> UpdateEmployee(int id)
        {
            List<EmployeeDtModel> returnList = new List<EmployeeDtModel>();
            using (var context = new EmployeeDBContext())
            {
                
                returnList=context.EmpDept.FromSqlRaw("usp_UpdateEmployee {0}", id).ToList();
            }
            return returnList;
        }


        public bool FinalUpdate(EmployeeDtModel EmpDept)
        {
            using (var context = new EmployeeDBContext())
            {
                var paraamList = new List<SqlParameter>();
                paraamList.Add(new SqlParameter("@EID", EmpDept.EID));
                paraamList.Add(new SqlParameter("@EmployeeName", EmpDept.EmployeeName));
                paraamList.Add(new SqlParameter("@Email", EmpDept.Email));
                paraamList.Add(new SqlParameter("@Gender", EmpDept.Gender));
                paraamList.Add(new SqlParameter("@Mobile", EmpDept.Mobile));
                paraamList.Add(new SqlParameter("@DeptId", EmpDept.DeptId));
                context.Database.ExecuteSqlRaw("usp_FinalUpdate @EID, @EmployeeName, @Email,  @Mobile, @Gender, @DeptId", paraamList);

            }
            return true;
        }


        public List<EmployeeDtModel> DeleteEmployee(int id)
        {
            List<EmployeeDtModel> returnList = new List<EmployeeDtModel>();
            using (var context = new EmployeeDBContext())
            {

                returnList = context.EmpDept.FromSqlRaw("usp_UpdateEmployee {0}", id).ToList();
            }
            return returnList;
        }


        public bool FinalDelete(EmployeeDtModel EmpDept)
        {
            using (var context = new EmployeeDBContext())
            {
                var paraamList = new List<SqlParameter>();
                paraamList.Add(new SqlParameter("@EID", EmpDept.EID));
                context.Database.ExecuteSqlRaw("_uspDeleteEmployee @EID", paraamList);

            }
            return true;
        }
    }
}
