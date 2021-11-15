using MongoDB.Driver;
using places.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace places.Services
{

    public interface IPlacesService
    {
        IMongoDatabase Database { get; }
    }

    public class PlacesService: IPlacesService
    {
        public PlacesService(IPlacesDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            Database = client.GetDatabase(settings.DatabaseName);
        }

        public IMongoDatabase Database { get; }
    }
}
