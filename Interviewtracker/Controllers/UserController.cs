using Interviewtracker.DataLayer;
using InterviewTracker.BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Interviewtracker.Controllers
{
    public class UserController : ApiController
    {
        private readonly IUserInterviewTrackerServices _trackerServices;

        public UserController(IUserInterviewTrackerServices trackerServices)
        {
            _trackerServices = trackerServices;
        }
        public async Task<IEnumerable<ApplicationUser>> GetAllUser()
        {
            return await _trackerServices.GetAllUser();
        }



        //public string Get()
        //{
        //    return "Welcome To Web API";
        //}
        //public List<string> Get(int Id)
        //{
        //    return new List<string> {
        //        "Data1",
        //        "Data2"
        //    };
        //}
    }
}
