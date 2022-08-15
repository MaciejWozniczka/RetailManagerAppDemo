using RetailManager.Library.Internal.DataAccess;
using RetailManager.Library.Models;
using System.Collections.Generic;

namespace RetailManager.Library.DataAccess
{
    public class UserData
    {
        public List<User> GetUserById(string Id)
        {
            SqlDataAccess sql = new SqlDataAccess();
            var parameters = new { Id = Id };

            var output = sql.LoadData<User, dynamic>("dbo.spUserLookup", parameters, "RetailManager");

            return output;
        }
    }
}
