using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace FormUI
{
    public static class DataAccess
    {
        public static List<Person> GetPeople(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                var output = connection.Query<Person>($"Select * from People where LastName = '{lastName}'").ToList();
                return output;
            }  
        }
        public static List<Person> GetAllPeople()
        {
            using (IDbConnection connectionForAllPeople = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                var allPeopleList = connectionForAllPeople.Query<Person>($"Select * from People").ToList();
                return allPeopleList;
            }
        }

        public static void InsertPerson(string firstName , string lastName , string emailAddress , string phoneNumber)
        {
            using (IDbConnection connectionInsert = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                List<Person> people = new List<Person>();

                people.Add(new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber });
                //connectionInsert.Execute("dbo.People_Insert @FirstName, @LastName, @EmailAddress, @PhoneNumber", people);

                var result = connectionInsert.Execute($"INSERT INTO [dbo].[People]([FirstName], [LastName], [EmailAddress], [PhoneNumber]) VALUES (@FirstName, @LastName, @EmailAddress, @PhoneNumber)",people);
            }
        }
    }
}

