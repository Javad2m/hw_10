using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git10;

public interface IUserRepository
{
    public void Add(User user);
    public List<User> GetAll();
    public User Get(string username);
    public void Update(string userName, string password, string status);
    public void Delete(string userName);


}
