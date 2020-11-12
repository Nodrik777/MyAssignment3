using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Assignment3.Models;
using System.Runtime.Remoting.Messaging;

namespace Assignment3.Controllers
{
    public class TeacherDataController : ApiController
    {

        private TeacherDBContext MyModule = new TeacherDBContext();
        // This controller will access teacher table of our Assignment database
        /// <summary>
        /// Returns list of teachers
        /// </summary>
        /// <example>
        /// Get api/TeacherData/ListTeachers
        /// </example>
        /// <returns> A List of teachres </returns>
        /// 
        [HttpGet]

        public IEnumerable<Teacher> ListTeachers()

        {
            MySqlConnection Conn = MyModule.AccessDatabase();


            // open connection between database and and web server
            Conn.Open();


            // Estalishing new command for database
            MySqlCommand cmd = Conn.CreateCommand();

            //SQL QUERY
            cmd.CommandText = "Select * from teachers";

            // THIS IS FOR EXTRA BONUS

            /*select teacherid, teacherfname, teacherlname, classname FROM teachers
            JOIN classes
            ON teachers.teacherid = classes.teacherid
            order by teacherlname; */


            MySqlDataReader ResultSet = cmd.ExecuteReader();


            List<Teacher> Teachers = new List<Teacher> {};


           while (ResultSet.Read())
            {
                //Accessing in our DB column "teacherid"

                int Teacherid = (int)ResultSet["teacherid"];
                string TeacherFname = (string)ResultSet["teacherfname"];
                string TeacherLname = (string)ResultSet["teacherlname"];
                string Employeenumber = (string)ResultSet["employeenumber"];
                DateTime Hiredate = (DateTime)ResultSet["hiredate"];
                decimal Salary = (decimal)ResultSet["salary"];

                Teacher NewTeacher = new Teacher();
                NewTeacher.Teacherid = Teacherid;
                NewTeacher.TeacherFname = TeacherFname;
                NewTeacher.TeacherLname = TeacherLname;
                NewTeacher.Employeenumber = Employeenumber;
                NewTeacher.Hiredate = Hiredate;
                NewTeacher.Salary = Salary;


                Teachers.Add(NewTeacher);
            }

           //Closing connection between DB and server
            Conn.Close();


            //Return the list of teachers
            return Teachers;


        }


        public Teacher FindTeacher(int id)

        {

            Teacher NewTeacher = new Teacher();
            MySqlConnection Conn = MyModule.AccessDatabase();


            // open connection between database and and web server
            Conn.Open();


            // Estalishing new command for database
            MySqlCommand cmd = Conn.CreateCommand();

            //SQL QUERY to find Teacher by id
            cmd.CommandText = "Select * from teachers where teacherid = " +id;


            MySqlDataReader ResultSet = cmd.ExecuteReader();


            while (ResultSet.Read())
            {
                //Accessing in our DB columns "teacherfname" and "teacherlastame"

                int Teacherid = Convert.ToInt32(ResultSet["teacherid"]);
                string TeacherFname = (string)ResultSet["teacherfname"];
                string TeacherLname = (string)ResultSet["teacherlname"];
                string Employeenumber = (string)ResultSet["employeenumber"];
                DateTime Hiredate = (DateTime)ResultSet["hiredate"];
                decimal Salary = (decimal)ResultSet["salary"];

                NewTeacher.Teacherid = Teacherid;
                NewTeacher.TeacherFname = TeacherFname;
                NewTeacher.TeacherLname = TeacherLname;
                NewTeacher.Employeenumber = Employeenumber;
                NewTeacher.Hiredate = Hiredate;
                NewTeacher.Salary = Salary;

                
            }


            return NewTeacher;
        }

        public Teacher FindTeacher(int id)

        {

            Teacher NewTeacher = new Teacher();
            MySqlConnection Conn = MyModule.AccessDatabase();


            // open connection between database and and web server
            Conn.Open();


            // Estalishing new command for database
            MySqlCommand cmd = Conn.CreateCommand();

            //SQL QUERY to find Teacher by id
            cmd.CommandText = "Select * from teachers where teacherid = " + id;


            MySqlDataReader ResultSet = cmd.ExecuteReader();


            while (ResultSet.Read())
            {
                //Accessing in our DB columns "teacherfname" and "teacherlastame"

                int Teacherid = (int)ResultSet["teacherid"];
                string TeacherFname = (string)ResultSet["teacherfname"];
                string TeacherLname = (string)ResultSet["teacherlname"];
                string Employeenumber = (string)ResultSet["employeenumber"];
                DateTime Hiredate = (DateTime)ResultSet["hiredate"];
                decimal Salary = (decimal)ResultSet["salary"];

                NewTeacher.Teacherid = Teacherid;
                NewTeacher.TeacherFname = TeacherFname;
                NewTeacher.TeacherLname = TeacherLname;
                NewTeacher.Employeenumber = Employeenumber;
                NewTeacher.Hiredate = Hiredate;
                NewTeacher.Salary = Salary;


            }


            return NewTeacher;
        }

    }
}
