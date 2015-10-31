using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Dapper;
using System.Configuration;
namespace Fantooface.Models
{
    public static  class UserManager
    {
        private static readonly string ConnectionString = ConfigurationManager.AppSettings.Get(ConnectionString);
        public static User Login(string userName, string password)
        {
            User u = new User();
            using(var db = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString)){
                var q = @"select UserId, DisplayName, UserName, EmailId, UserRole  from Users where UserName=@username and Password=@password";
                var user = db.Query<User>(q, new { username = userName, password = password });
                foreach (var uu in user) {
                    u.UserId = Convert.ToInt32(uu.UserId);
                    u.UserName = uu.DisplayName;
                    u.EmailId = uu.EmailId;
                    u.UserName = uu.UserName;
                    u.UserRole = uu.UserRole;
                }
               
            }
            return u; 
        }
    }
}