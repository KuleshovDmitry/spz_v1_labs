using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Laba7.Controller
{
    static class Controller         //класс реализует запросы к БД
    {
        static public string connStr { get; private set; } = @"Data Source = (LocalDB)\MSSQLLocalDB; 
                                AttachDbFilename =C:\Users\admin\source\Laba7\Laba7\Model\Laba7DB.mdf; 
                                Integrated Security = True";
        static public void InsertLecturer(int id, string firstName, string lastName)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Insert into Lecturer(Id,FirstName, LastName) " +
                    "Values('"+id + "', '" +firstName+"', '"+ lastName+"')", connection);
                command.ExecuteNonQuery();
            }
        }
        static public void DeleteLecturer(string firstName, string lastName)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Delete from Lecturer where FirstName='" + 
                    firstName + "' and LastName = '" + lastName + "')", connection);
                command.ExecuteNonQuery();
            }
        }
        static public void InsertDiscipline(int id, string Name)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Insert into Discipline(Id, Name) " +
                    "Values('" + id + "', '" + Name + "')", connection);
                command.ExecuteNonQuery();
            }
        }
        static public void InsertCortege(int lecturerId, int disciplineId)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Insert into Cortege(LecturerId, DisciplineId) " +
                    "Values('" + lecturerId+"', '"+disciplineId + "')", connection);
                command.ExecuteNonQuery();
            }
        }
        static public void DeleteDiscipline(string Name)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Delete from Discipline where " +
                    "Name='" + Name + "')", connection);
                try { command.ExecuteNonQuery(); }
                catch
                {
                    Console.WriteLine("Ошибка запроса на удаление");
                    Console.WriteLine("Возможно запись уже удалена");
                }

            }
        }
        static public string GetLecturerFirstName(int Id)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Delete from Lecturer where " +
                    "id = ('" + Id + "')", connection);
                return command.ExecuteReader().GetString(2);
            }
        }
        static public string GetLecturerLastName(int Id)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Delete from Lecturer where " +
                    "id = ('" + Id + "')", connection);
                return command.ExecuteReader().GetString(3);
            }
        }
        static public void DeleteLecturer(int Id)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                SqlCommand command1 = new SqlCommand("Delete from Cortege where " +
                    "LecturerId = ('" + Id + "') ", connection);
                SqlCommand command2 = new SqlCommand("Delete from Lecturer where " +
                    "id = ('" + Id + "')", connection);
                command1.ExecuteNonQuery();
                command2.ExecuteNonQuery();
            }
        }
        static public string GetDiscipline(int Id)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select * Discipline(Name) where " +
                    "id = ('" + Id + "')", connection);
                return command.ExecuteReader().GetString(2);
            }
        }
        static public void DeleteDiscipline(int Id)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                SqlCommand command1 = new SqlCommand("Delete from Cortege where " +
                    "DisciplineId = ('" + Id + "') ", connection);
                SqlCommand command2 = new SqlCommand("Delete from Discipline where " +
                    "Id='" + Id + "'", connection);
                command1.ExecuteNonQuery();
                command2.ExecuteNonQuery();
            }
        }
        static public DataTable GetDataTable( SqlConnection connection)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand(
                    "SELECT Cortege.LecturerId, Cortege.DisciplineId, " +
                    "Discipline.Name, Lecturer.FirstName, Lecturer.LastName " +
                    "FROM Discipline INNER JOIN(Lecturer INNER JOIN Cortege " +
                    "ON Lecturer.Id = Cortege.LecturerId) " +
                    "ON Discipline.Id = Cortege.DisciplineId",  connection);
                
            dataAdapter.Fill(ds, "Cortege");
            return ds.Tables["Cortege"];
        }
        static public void DeleteCortege(int lecturerId, int dicsiplineId)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Delete from Cortege where " +
                    "LecturerId = ('" + lecturerId + "') and DisciplineId = ('"+dicsiplineId +"')", connection);
                try { command.ExecuteNonQuery(); }
                catch
                {
                    //Console.WriteLine("Ошибка запроса на удаление");
                }
            }
        }
    }
}
