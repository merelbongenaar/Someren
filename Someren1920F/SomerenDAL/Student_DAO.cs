﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;
using System.Configuration;

namespace SomerenDAL
{
    public class Student_DAO : Base
    {
        //24.02 changed appconfig file
      
        public List<Student> Db_Get_All_Students()
        {
            OpenConnection();

            string query = "SELECT personID, firstName, lastName FROM [Person]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));

            
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    Number = (int)dr["personID"],
                    Name = (String)(dr["firstName"].ToString()) + (String)(dr["lastName"].ToString())

                };
                students.Add(student);
            }
            return students;
        }

    }
}
