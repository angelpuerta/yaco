using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace places.Models
{

    public interface IPlacesDatabaseSettings
    {
        public string PubCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string  DiscoCollectionName { get; set; }
    }

    public class PlacesDatabaseSettings : IPlacesDatabaseSettings
    {
        public string PubCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string DiscoCollectionName { get; set; }
    }
}
