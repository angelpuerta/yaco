using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using places.Models;
using places.Services;

namespace places.Controllers
{
    [ApiController]
    [Route("place")]
    public class PlaceController : ControllerBase
    {
        private readonly IPubService _pubService;
        private readonly ILogger<PlaceController> _logger;

        public PlaceController(ILogger<PlaceController> logger, IPubService pubService)
        {
            this._logger = logger;
            this._pubService = pubService;
        }

        [HttpPost]
        public ActionResult<Place> Create(Place place)
        {
            _pubService.Create(place);
            return CreatedAtRoute("pub", new { id = place.Id.ToString() }, place);
        }

    }
}
