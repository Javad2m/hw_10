using Dapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git10;

public class UserRep : IUserRepository
{
    public void Add(User user)
    {
        using (IDbConnection db = new SqlConnection(Configuration.ConnectionString))
        {
            db.Execute(UserQueries.Create, new { user.UserName, user.Password, user.Status });
        }
    }



    public void Delete(string userName)
    {
        using (IDbConnection db = new SqlConnection(Configuration.ConnectionString))
        {
            db.Execute(UserQueries.Delete, new { UserName = userName });
        }
    }

    public User Get(string username)
    {
        using (IDbConnection db = new SqlConnection(Configuration.ConnectionString))
        {
            return db.QueryFirstOrDefault<User>(UserQueries.Get, new { UserName = username });
        }
    }

    public List<User> GetAll()
    {
        using (IDbConnection db = new SqlConnection(Configuration.ConnectionString))
        {
            return db.Query<User>(UserQueries.GetAll).ToList();
        }
    }

    public void Update(string userName, string password, string status)
    {
        var users = GetAll();
        var update = users.FirstOrDefault(x => x.UserName == userName);
        if (update != null)
        {
            using (IDbConnection db = new SqlConnection(Configuration.ConnectionString))
            {
                db.Execute(UserQueries.Update, new { UserName = userName, Password = password, Status = status });
            }
        }
    }
}
