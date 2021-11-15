using MongoDB.Driver;
using places.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace places.Services
{


    public class PlaceService: IPlacesService
    {
        public PlaceService(IPlacesDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            Database = client.GetDatabase(settings.DatabaseName);
        }

        public IMongoDatabase Database { get; }
    }
}
