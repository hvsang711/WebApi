using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Treehouse.FitnessFrog.Shared.Data;
using Treehouse.FitnessFrog.Spa.Dto;

namespace Treehouse.FitnessFrog.Spa.Controllers
{
    public class ActivitiesController : ApiController
    {
        private ActivitiesRepository _activitiesRepository = null;

        public ActivitiesController(ActivitiesRepository activitiesRepository)
        {
            _activitiesRepository = activitiesRepository;
        }

        public IHttpActionResult Get()
        {
            var Dto = _activitiesRepository.GetList()
                .Select(act => new ActivitiesDto
                {
                    Id = act.Id,
                    Name = act.Name
                });
            return Ok(Dto);
        }
    }
}