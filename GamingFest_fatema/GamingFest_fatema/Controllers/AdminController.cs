using GamingFest_fatema.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GamingFest_fatema.Controllers
{
    public class AdminController : Controller
    {
        public object Admins { get; private set; }

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Gameadd2()
        {
             string connString = @"Server=DESKTOP-KC1AJ4P\SQLEXPRESS; Database= brandnewdata; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connString);
            string query = "select * from games";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<game> games = new List<game>();
            while (reader.Read())
            {
                game g = new game()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Date = reader.GetString(reader.GetOrdinal("Date")),
                    


                };
                games.Add(g);
            }

            conn.Close();
            return View (games);
        }
        [HttpGet]
          public ActionResult Overview2()
        {
            return View();
        }

       [HttpPost]
         public ActionResult Overview2(game g)
        {
            string connString = @"Server=DESKTOP-KC1AJ4P\SQLEXPRESS; Database= brandnewdata; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connString);
            string query = String.Format("Insert into games values ('{0}', '{1}')", g.Name,g.Date);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int r = cmd.ExecuteNonQuery();

            conn.Close();

            return View();
        
        }

           

        public ActionResult Profile_Update()
        {
            return View();
        }
        public ActionResult Profile_Update2()
        {
            return View();
        }

        public ActionResult Volunteers_Info()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Volunteers_Info2()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Volunteers_Info2( Admin v)
        {
            string connString = @"Server=DESKTOP-KC1AJ4P\SQLEXPRESS; Database= gamingdata; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connString);
            string query = String.Format("Insert into Students values ('{0}', '{1}', '{2}')", v.Name, v.Dob, v.Gender);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int r = cmd.ExecuteNonQuery();

            conn.Close();

            return View();
        }





        public ActionResult Users_Info()
        {
            return View();
        }
        public ActionResult Users_Info2()
        {
            return View();
        }
        public ActionResult Overview()
        {
            return View();
        }
        public ActionResult Overview2()
        {
            return View();
        }


        public ActionResult Review()
        {
            return View();
        }
        public ActionResult Review2()
        {
            return View();
        }

        public ActionResult Gameadd2()
        {
            return View();
        }

        public ActionResult Logout2()
        {
            return View();
        }

    }
}
