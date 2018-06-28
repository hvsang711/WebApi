using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Treehouse.FitnessFrog.Shared.Models;
using Treehouse.FitnessFrog.Spa.Dto;

namespace Treehouse.FitnessFrog.Spa.Controllers
{
    public class IntensitiesController : ApiController
    {      

        public IHttpActionResult Get()
        {
            var Dto = Enum.GetValues(typeof(Entry.IntensityLevel));
            var result = Dto.Cast<Entry.IntensityLevel>()
                .Select(rs => new IntensitiesDto
                {
                    Id = (int)rs,
                    Name = rs.ToString()
                })
                .ToList();
                
            return Ok(result);
        }
    }
}