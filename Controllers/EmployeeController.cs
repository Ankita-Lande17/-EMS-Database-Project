using Microsoft.AspNetCore.Mvc;
using NS.EMS.Business;
using NS.EMS.Model;
using System;

namespace NS.EMS.WEB.Controllers
{
    public class EmployeeController : Controller
    {
        
        private readonly IEmployeeBusiness _IEmployeeBusiness;
        public EmployeeController(IEmployeeBusiness iEmployeeBusiness)
        {
            _IEmployeeBusiness = iEmployeeBusiness;
        }
        public IActionResult EmployeeDetail()
        {
            return View();

           // return View(_IEmployeeBusiness.ShowDetail());
        }
        [HttpPost]
        public IActionResult EmployeeDetail(EmployeeDtModel EmpDept)
        {

            EmpDept.DeptId = Convert.ToInt32(EmpDept.DeptId);
            Console.WriteLine("Ankita");
            Console.WriteLine(EmpDept.EmployeeName);
            Console.WriteLine(EmpDept.DeptId);
            _IEmployeeBusiness.AddEmployee(EmpDept);
           // return View();
           return RedirectToAction("ShowDetail");
        }

        public IActionResult ShowDetail( )
        {
            return View(_IEmployeeBusiness.ShowDetail());
        }

        public IActionResult Edit(int id)
        {
            //_IEmployeeBusiness.UpdateEmployee(id);
            return View(_IEmployeeBusiness.UpdateEmployee(id));
        }

        [HttpPost]
        public IActionResult Edit(EmployeeDtModel EmpDept)
        {
            Console.WriteLine(EmpDept.EID);
            EmpDept.DeptId = Convert.ToInt32(EmpDept.DeptId);
            _IEmployeeBusiness.FinalUpdate(EmpDept);
            return RedirectToAction("ShowDetail");
        }
        public IActionResult Delete(int id)
        {
            return View(_IEmployeeBusiness.DeleteEmployee(id));
        }

        [HttpPost]
        public IActionResult Delete(EmployeeDtModel EmpDept)
        {
            Console.WriteLine(EmpDept.EID);
            _IEmployeeBusiness.FinalDelete(EmpDept);
            return RedirectToAction("ShowDetail");
        }
    }
}
