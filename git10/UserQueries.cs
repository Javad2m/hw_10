using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git10;

public static class UserQueries
{
    public static string Create = "insert into [hw10].[dbo].[Users] (UserName, Password, Status) values (@UserName, @Password, @Status);";
    public static string Get = "SELECT * FROM Users WHERE UserName = @UserName";
    public static string GetAll = "SELECT * FROM Users";
    public static string Delete = "delete Users Where UserName = @UserName ";
    public static string Update = "UPDATE Users SET Status = @Status, Password = @Password WHERE UserName = @UserName";


}
