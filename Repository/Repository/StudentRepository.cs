using Dapper;
using Domain;
using Domain.DBContext;
using Domain.DBDapper;
using Microsoft.EntityFrameworkCore;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DataBaseContext _dataBaseContext;
        public StudentRepository(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }
        public async Task<List<Student>> GetStudent()
        {
            return await _dataBaseContext.Students.ToListAsync();
        }
        public async Task<Student> GetStudentByID(int studentId)
        {
            return await _dataBaseContext.Students.Where(x => x.StudentId == studentId).FirstOrDefaultAsync();
        }

        public bool EditStudent(Student EditStudent)
        {
            var paramT = new DynamicParameters();
            paramT.Add("@StudentId", EditStudent.StudentId, System.Data.DbType.Int32);
            paramT.Add("@FullName", EditStudent.FullName, System.Data.DbType.String);
            paramT.Add("@Addrees", EditStudent.Address, System.Data.DbType.String);
            paramT.Add("@PhoneNumber", EditStudent.PhoneNumber, System.Data.DbType.String);
            paramT.Add("@Email", EditStudent.Email, System.Data.DbType.String);

            string sqlEdit = "StudentInsert";
            int Result = -100;
            try
            {
                var sReader = DapperManagerSQL.Instance.Conn.ExecuteReader(sqlEdit, paramT, commandType: CommandType.StoredProcedure);
                while (sReader.Read())
                {
                    // chỉ trường được duy nhất SQL trả về Result = 1
                    Result = sReader["ResultSql"] == null ? 0 : int.Parse(sReader["ResultSql"].ToString());

                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return Result > 0;


        }
        public async Task<bool> InsertStudent(Student insertstudent)
        {

            var listStudent = await _dataBaseContext.Students.ToListAsync();
            if (listStudent != null && listStudent.Count > 0)
            {
                if (listStudent.Any(e => e.StudentId == insertstudent.StudentId))
                {
                    return false;
                }

            }
            Student student = new Student()
            {
                FullName = insertstudent.FullName,
                Address = insertstudent.Address,
                PhoneNumber = insertstudent.PhoneNumber,
                Email = insertstudent.Email
               
            };
            try
            {
                _dataBaseContext.Students.Add(student);
                await _dataBaseContext.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }

        }

        public async Task<bool> DeleteStudent(int idStudent)
        {
            try
            {
                var DbListdate = await _dataBaseContext.Students.FindAsync(idStudent);

                if (DbListdate == null)
                {
                    return false;
                }

                _dataBaseContext.Students.Remove(DbListdate);
                await _dataBaseContext.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }

}

