using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FitLogGo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Cors;
using System.Collections;

namespace FitLogGo.Controllers
{
    public class GoogleChartController : Controller
    {
        private FitLogGoDbContext _context;

        public GoogleChartController(FitLogGoDbContext context)
        {
            _context = context;
        }

        [Route("api/Charts")]
        [HttpGet]
        [EnableCors("AllowAll")]
        public JsonResult GetMilesData()
        {
            IEnumerable perDayMileage = (from ses in _context.Sessions

                                         select new
                                         {
                                             WorkoutNumber = ses.SessionId,
                                             MileageName = ses.MilesTraveled
                                           
                                         })
                                           /*).OrderBy(a => a.WorkoutNumber).Take(10).ToList()*/;
        
            return Json(perDayMileage);
          
        }

        [Route("api/ChartsTwo")]
        [HttpGet]
        [EnableCors("AllowAll")]
        public JsonResult GetMinutesData()
        {
            IEnumerable perDayMinutes = (from ses in _context.Sessions

                                         select new
                                         {
                                             WorkoutNumber = ses.SessionId,
                                             MinutesName = ses.MinutesWorked

                                         })
                                           /*).OrderBy(a => a.WorkoutNumber).Take(10).ToList()*/;

            return Json(perDayMinutes);

        }

    }
}
