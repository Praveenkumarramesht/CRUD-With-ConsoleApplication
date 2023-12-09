using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;


namespace DapperDataAccessLayer
{
    public class SchoolDetailsRepository:ISchoolDetailsRepository
    {
        public SchoolDetail InsertSP(SchoolDetail SchoolDetail)
        {

            try
            {
                var connectionString = "Data source=DESKTOP-1U0BM0H\\SQLEXPRESS;initial catalog=batch7;user id=sa;password=Anaiyaan@123;";

                var con = new SqlConnection(connectionString);
                con.Open();
                var insertQuery = $"exec SchoolDetailsInsert '{SchoolDetail.SchoolName}', '{SchoolDetail.Address}', '{SchoolDetail.StortedDate}', {SchoolDetail.PhoneNumber}, '{SchoolDetail.Email_id}'";
                con.Execute(insertQuery);
                con.Close();

            }
            catch (SqlException sql)
            {
                throw;

            }
            catch (Exception ex)
            {
                throw;
            }
            return SchoolDetail;
        }
        public IEnumerable<SchoolDetail> ReadSP()
        {
            try
            {
                var connectionString = "Data source=DESKTOP-1U0BM0H\\SQLEXPRESS;initial catalog=batch7;user id=sa;password=Anaiyaan@123;";

                var con = new SqlConnection(connectionString);
                con.Open();
                var selectQuery = $"SchoolDetailsRead";
                var schoolDetails = con.Query<SchoolDetail>(selectQuery);
                con.Close();
                return schoolDetails.ToList();

            }
            catch (SqlException sql)
            {
                throw;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public SchoolDetail FindSchoolDetailsByIdSP(long Id)
        {
            try
            {
                var connectionString = "Data source=DESKTOP-1U0BM0H\\SQLEXPRESS;initial catalog=batch7;user id=sa;password=Anaiyaan@123;";

                var con = new SqlConnection(connectionString);
                con.Open();
                var selectQuery = $"FindSchoolDetailsByNumber {Id}";
                var Find = con.QueryFirstOrDefault<SchoolDetail>(selectQuery);
                con.Close();
                return Find;

            }
            catch (SqlException sql)
            {
                throw;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void DeleteSchoolDetailsByIdSP(long Id)
        {
            try
            {
                var connectionString = "Data source=DESKTOP-1U0BM0H\\SQLEXPRESS;initial catalog=batch7;user id=sa;password=Anaiyaan@123;";

                var con = new SqlConnection(connectionString);
                con.Open();
                var deleteQuery = $"SchoolDetailstDelete {Id}";
                con.Execute(deleteQuery);
                con.Close();


            }
            catch (SqlException sql)
            {
                throw;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public SchoolDetail UpdateSchoolDetailsByIdSP(long Id, SchoolDetail Sch)
        {

            try
            {
                var connectionString = "Data source=DESKTOP-1U0BM0H\\SQLEXPRESS;initial catalog=batch7;user id=sa;password=Anaiyaan@123;";

                var con = new SqlConnection(connectionString);
                con.Open();
                var updateQuery = $"SchoolDetailsUpdate {Id},'{Sch.SchoolName}', '{Sch.Address}', '{Sch.StortedDate}', {Sch.PhoneNumber},'{Sch.Email_id}',";
                var shl = con.QueryFirstOrDefault<SchoolDetail>(updateQuery);
                con.Execute(updateQuery);
                con.Close();
                return shl;

            }
            catch (SqlException sql)
            {
                throw;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
