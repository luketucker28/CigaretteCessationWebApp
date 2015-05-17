using CigaretteCessationWebApp.Repository;
using CigaretteCessationWebApp.Models;
using CigaretteCessationWebApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;



namespace CigaretteCessationWebApp.Controllers
{
    [RoutePrefix("api/Smoking")]
    public class SmokingController : ApiController
    {
        private ConsumedRepository consumes = new ConsumedRepository();
        private TargetRepository targets = new TargetRepository();
        

       // PERSON DB
        // GET: /api//Consumeds/userID
        [HttpGet]
        [Route("Consumeds/{userID}")]
        public System.Web.Mvc.JsonResult Consumeds(string userID)
        {
            var consumed = consumes.GetByUserId(userID);
            var json = new System.Web.Mvc.JsonResult();
            json.Data = new { consumed };
            return json;
        }

        //POST: api/Smoking/Consumeds/userID
        [HttpPost]
        [Route("Consumeds/{userID}")]
        public HttpResponseMessage Consumeds(string userID,  Consumed consumed)
        {
            consumes.Add(consumed);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
        //DELETE: api/Persons/userID/Delete/ID
        [HttpDelete]
        [Route("Consumeds/Delete/{id}")]
        public HttpResponseMessage DeleteConsumed(int id)
        {
            consumes.Delete(id);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
        // GET: api/Smoking/Consumeds/userIID/ID
        [HttpGet]
        [Route("Consumeds/{userID}/{id}")]
        public System.Web.Mvc.JsonResult GetConsumed(string userID, int id)
        {
            var smoke = consumes.GetById(id);
            var json = new System.Web.Mvc.JsonResult();
            json.Data = new { smoke };
            return json;
        }

       // //GET: api/Smoking/Consumeds/UserID/Type/R
       // [HttpGet]
       // [Route("Persons/{userID}/fliterby/{reason}")]
       // public System.Web.Mvc.JsonResult GetByReasoning(string userID, string reason)
       // {
       //     var smoked = consumes.GetByReason(reason);
       //     var json = new System.Web.Mvc.JsonResult();
       //     json.Data = new { smoked };
       //     return json;
       // }
       // //Get: api/Smoking/Consumeds/UserId/Type/
       // [HttpGet]
       // [Route("Consumeds/{userID}/filterby/{Location}")]
       // public System.Web.Mvc.JsonResult GetByLocations(string userID, string location)
       // {
       //     var smoked = consumes.GetByLocation(location);
       //     var json = new System.Web.Mvc.JsonResult();
       //     json.Data = new { smoked };
       //     return json;
       // }
        
       
    }
}
