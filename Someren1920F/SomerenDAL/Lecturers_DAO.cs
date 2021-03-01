using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    class Lecturers_DAO : Base
    {
        public List<Student> Db_Get_All_Students()
        {
            OpenConnection();

            string query = "SELECT personID, firstName FROM [Person]";
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
                    Name = (String)(dr["firstName"].ToString())
                };
                students.Add(student);
            }
            return students;
        }
    }
}
