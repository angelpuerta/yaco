using MongoDB.Driver;
using places.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace places.Services
{

    public interface IPubService
    {
        public Place Create(Place place);

        public List<Place> Get();
    }

    public class PubService:IPubService
    {
        private readonly IMongoCollection<Place> _pubs;
        public PubService(IPlacesService placeService, IPlacesDatabaseSettings placesDatabaseSettings)
        {
            _pubs = placeService.Database.GetCollection<Place>(placesDatabaseSettings.PubCollectionName);
        }

        public Place Create(Place place)
        {
            _pubs.InsertOne(place);
            return place;
        }

        public List<Place> Get()
        {
            return _pubs.Find(_ => true).ToList();
        }
    }
}
