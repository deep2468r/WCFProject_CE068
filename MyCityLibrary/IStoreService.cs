using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ServiceModel;

namespace MyCityLibrary
{
    [ServiceContract]
    public interface IStoreService
    {

        [OperationContract]
        DataSet GetStores();

        [OperationContract]
        Store GetStoreByID(string ID);

        [OperationContract]
        DataSet GetStoresByName(string Name);

        [OperationContract]
        DataSet GetStoresByCategory(string Category);

    }

    [ServiceContract]
    public interface IUserService
    {

        [OperationContract]
        User GetUser(string UserID);

        [OperationContract]
        void AddUser(User user);
    }
}
