using Accademy.Entities;
using DataManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.DataManager
{
    public class SQLDataManager : IDataManager
    {
        public DataOperationResult CreateNewCliente(Cliente newCliente)
        {
            throw new NotImplementedException();
        }

        public ContoCorrente GetContocorrenteByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public bool LoginIsOK(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool UserIsAnOwner(string username)
        {
            throw new NotImplementedException();
        }
    }
}
