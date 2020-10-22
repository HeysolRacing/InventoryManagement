using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;

namespace InventoryManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly string sConnString = "Server=.;Database=InventoryManagement;Integrated Security=true";
        private readonly ILogger<DepartmentController> _logger;

        public DepartmentController(ILogger<DepartmentController> logger)
        {
            _logger = logger;
        }

        //[HttpGet]
        //public IEnumerable<Department> Get()
        //{
        //    string query = @"SELECT DepartmentId, DepartmentName FROM dbo.Department";
        //    DataTable dt = new DataTable();

        //    using (var con = new SqlConnection(sConnString))
        //    {
        //        using(var cmd = new SqlCommand(query, con))
        //        {
        //            using (var da = new SqlDataAdapter(cmd))
        //            { 
        //                cmd.CommandType = CommandType.Text;
        //                da.Fill(dt);
        //            }
        //        }
        //    }

        //    return dt.AsEnumerable().Select(row => new Department
        //    { 
        //        DepartmentId = Convert.ToInt32(row["DepartmentId"]),
        //        DepartmentName = row["DepartmentName"].ToString()

        //    });
        //}

        //[HttpPost]
        //public string Post(Department department)
        //{
        //    try 
        //    {
        //        string query = @" INSERT INTO [Department] ([DepartmentName]) VALUES ('" + department.DepartmentName + "')";
                
        //        using (var con = new SqlConnection(sConnString))
        //        {
        //            con.Open();
        //            using (var cmd = new SqlCommand(query, con))
        //            {
        //               cmd.CommandType = CommandType.Text;
        //               cmd.ExecuteNonQuery();
        //            }

        //            con.Close();
        //        }
        //    }
        //    catch(Exception ex) 
        //    {
        //        string error = ex.Message;
        //    }

        //    return "Add successfully";
        //}

        //[HttpPut]
        //public string Put(Department department)
        //{
        //    try
        //    {
        //        string query = @"UPDATE dbo.Department SET DepartmentName = '" + department.DepartmentName + "'" +
        //                        "WHERE DepartmentId = " + department.DepartmentId;
   
        //        using (var con = new SqlConnection(sConnString))
        //        {
        //            con.Open();
        //            using (var cmd = new SqlCommand(query, con))
        //            {
        //               cmd.CommandType = CommandType.Text;
        //               cmd.ExecuteNonQuery();
        //            }
                   
        //            con.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string error = ex.Message;
        //    }

        //    return "Update successfully";
        //}

        //[HttpDelete("{id}")]
        //public string Delete(int id)
        //{
        //    try
        //    {
        //        string query = @"DELETE FROM dbo.Department WHERE DepartmentId = " + id.ToString();
     
        //        using (var con = new SqlConnection(sConnString))
        //        {
        //            con.Open();
        //            using (var cmd = new SqlCommand(query, con))
        //            {
        //                cmd.CommandType = CommandType.Text;
        //                cmd.ExecuteNonQuery();
        //            }

        //            con.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string error = ex.Message;
        //    }

        //    return "Delete successfully";
        //}
    }
}
