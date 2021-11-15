using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace authentication.Services
{
    interface IDatabaseSettings
    {
        public string UserCollectionName { get; set; }
        public string ConnectionString { get; set; }

        public string UserDatabase { get; set; }
    }
    class DatabaseSettings: IDatabaseSettings
    {
        public string UserCollectionName { get; set; }
        public string ConnectionString { get; set; }

        public string UserDatabase { get; set; }
    }
}