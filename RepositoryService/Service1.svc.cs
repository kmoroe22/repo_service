using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using RepositoryService.Data;
using RepositoryService.DataContracts;

namespace RepositoryService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RepositoryService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RepositoryService.svc or RepositoryService.svc.cs at the Solution Explorer and start debugging.
    public class RepositoryService : IRepositoryService
    {

        private readonly SentimentEntities _model = new SentimentEntities();

        public ICollection<UserObject> GetAllUsers()
        {
            return _model.Users.Select(user => new UserObject(user)).ToList();
        }

        public UserObject GetUserById(int userId)
        {
            var user = _model.Users.SingleOrDefault(x => x.UserId == userId);
            return user == null ? null : new UserObject(user);
        }
    }
}
