using InventoryManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;

namespace InventoryManagement.Infraestructure.Repositories
{
    public class EmployeeRepository
    {
        private readonly string sConnString = "Server=.;Database=InventoryManagement;Integrated Security=true";

        [HttpGet]
        public IEnumerable<Employee> GetEmployees()
        {
            var employees = Enumerable.Range(1, 10).Select(x => new Employee
            {
                EmployeeId = x,
                EmployeeName = $"EmployeeName {x}",
                Department = "Department - " + x.ToString(),
                DateofHire = DateTime.Now.ToString(),
                PhotoFileName = "PhotoFileName : " + x.ToString(),
            });

            return employees;

            //DataTable dt = new DataTable();

            //string sConnString = "Server =.; Database = InventoryManagement; Integrated Security = true";

            //using (var con = new SqlConnection(sConnString))
            //{
            //    using (var cmd = new SqlCommand("[dbo].[GetEmployee]", con))
            //    {
            //        using (var da = new SqlDataAdapter(cmd))
            //        {
            //            cmd.CommandType = CommandType.StoredProcedure;
            //            da.Fill(dt);
            //        }
            //    }
            //}

            //return dt.AsEnumerable().Select(row => new Employee
            //{
            //    EmployeeId = Convert.ToInt32(row["EmployeeID"]),
            //    EmployeeName = row["EmployeeName"].ToString(),
            //    Department = row["Department"].ToString(),
            //    DateofHire = row["DateofHire"].ToString(),
            //    PhotoFileName = row["PhotoFileName"].ToString(),

            //});
        }

        //[HttpPost]
        //public string Post(Employee employee)
        //{
        //    try
        //    {
        //        using (var con = new SqlConnection(sConnString))
        //        {
        //            using (var cmd = new SqlCommand("[dbo].[AddEmployee]", con))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                cmd.Parameters.Add("@EmployeeName", SqlDbType.VarChar).Value = employee.EmployeeName;
        //                cmd.Parameters.Add("@Department", SqlDbType.VarChar).Value = employee.Department;
        //                cmd.Parameters.Add("@HireDate", SqlDbType.Date).Value = employee.DateofHire;
        //                cmd.Parameters.Add("@PhotoFileName", SqlDbType.VarChar).Value = employee.PhotoFileName;

        //                con.Open();
        //                cmd.ExecuteNonQuery();
        //            }

        //            con.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string error = ex.Message;
        //    }

        //    return "Add successfully";
        //}

        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}

        //public string SaveFile()
        //{
        //    try
        //    {
        //        var httpRequest = HttpContext.Request;
        //        var postedFile = httpRequest;
        //    }
        //    catch (Exception ex)
        //    {
        //        string error = ex.Message;
        //        throw;
        //    }

        //    return "anonymous.png";
        //}
    }
}
