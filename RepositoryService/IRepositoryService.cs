using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using RepositoryService.DataContracts;

namespace RepositoryService
{
    
    [ServiceContract]
    public interface IRepositoryService
    {

        [OperationContract]
        ICollection<UserObject> GetAllUsers();

        [OperationContract]
        UserObject GetUserById(int userId);
    }


    
}
