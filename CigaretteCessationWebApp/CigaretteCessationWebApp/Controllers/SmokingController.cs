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
    [RoutePrefix("api/CigaretteCessationWebApp")]
    public class SmokingController : ApiController
    {
        private ConsumedRepository consumes = new ConsumedRepository();
        private TargetRepository targeted = new TargetRepository();
        

        //PERSON DB
        // GET: /api/Recollection/Consumeds/userID
        [HttpGet]
        [Route("Consumeds/{userID}")]
        public System.Web.Mvc.JsonResult Consumeds()
        {
            var cons =  consumes.All();
            var json = new System.Web.Mvc.JsonResult();
            json.Data = new { cons };
            return json;
        }

        ////POST: api/Recollection/Persons/userID
        //[HttpPost]
        //[Route("Persons/{userID}")]
        //public HttpResponseMessage Persons(string userID, [FromBody] Person person)
        //{
        //    person_repo.Add(person);
        //    return new HttpResponseMessage(HttpStatusCode.OK);
        //}

        ////GET: api/Recollection/Persons/userIID/ID
        //[HttpGet]
        //[Route("Persons/{userID}/{id}")]
        //public System.Web.Mvc.JsonResult SinglePerson(string userID, int id)
        //{
        //    var person = person_repo.GetById(id);
        //    var json = new System.Web.Mvc.JsonResult();
        //    json.Data = new { person };
        //    return json;
        //}

        ////GET: api/Recollection/Persons/UserID/Type/RelationshipType
        //[HttpGet]
        //[Route("Persons/{userID}/Type/{relationshipType}")]
        //public System.Web.Mvc.JsonResult GetByRelationshipType(string userID, string relationshipType)
        //{
        //    var people = person_repo.getByRelationshipType(relationshipType);
        //    var json = new System.Web.Mvc.JsonResult();
        //    json.Data = new { people };
        //    return json;
        //}

        ////PUT: api/Persons/userID/Update/ID
        //[HttpPut]
        //[Route("Persons/{userID}/Update/{id}")]
        //public HttpResponseMessage UpdatePerson([FromBody] Person person)
        //{
        //    person_repo.Edit(person);
        //    return new HttpResponseMessage(HttpStatusCode.OK);
        //}

        ////DELETE: api/Persons/userID/Delete/ID
        //[HttpDelete]
        //[Route("Persons/Delete/{id}")]
        //public HttpResponseMessage DeletePerson(int id)
        //{
        //    person_repo.Delete(id);
        //    return new HttpResponseMessage(HttpStatusCode.OK);
        //}

        ////PLACES
        //// GET: /api/Recollection/Places/userID
        //[HttpGet]
        //[Route("Places/{userID}")]
        //public System.Web.Mvc.JsonResult Place(string userID)
        //{
        //    var place = place_repo.GetAllByUserId(userID);
        //    var json = new System.Web.Mvc.JsonResult();
        //    json.Data = new { place };
        //    return json;
        //}

        ////POST: /api/Recollection/Places/UserID
        //[HttpPost]
        //[Route("Places/{userID}")]
        //public HttpResponseMessage Places(string userID, [FromBody] Place place)
        //{
        //    place_repo.Add(place);
        //    return new HttpResponseMessage(HttpStatusCode.OK);
        //}

        ////GET: api/Recollection/Places/userID/ID
        //[HttpGet]
        //[Route("Places/{UserID}/{id}")]
        //public System.Web.Mvc.JsonResult SinglePlace(string userID, int id)
        //{
        //    var place = place_repo.GetById(id);
        //    var json = new System.Web.Mvc.JsonResult();
        //    json.Data = new { place };
        //    return json;
        //}

        ////PUT: api/Recollection/Places/userID/Update/ID
        //[HttpPut]
        //[Route("Places/{UserID}/Update/{id}")]
        //public HttpResponseMessage UpdatePlace([FromBody] Place place)
        //{
        //    place_repo.Edit(place);
        //    return new HttpResponseMessage(HttpStatusCode.OK);
        //}

        ////DELETE: api/Recollection/Places/userID/Delete/ID
        //[HttpDelete]
        //[Route("Places/{UserID}/Delete/{id}")]
        //public HttpResponseMessage DeletePlace(int id)
        //{
        //    place_repo.Delete(id);
        //    return new HttpResponseMessage(HttpStatusCode.OK);
        //}

        ////MEMORIES
        ////GET: api/Recollection/Memories/UserID/Place/placeID
        //[HttpGet]
        //[Route("Memories/{UserID}/Place/{id}")]
        //public System.Web.Mvc.JsonResult PlaceMemories(int id)
        //{
        //    var notes = memory_repo.GetAllPlaceMemories(id);
        //    var json = new System.Web.Mvc.JsonResult();
        //    json.Data = new { notes };
        //    return json;
        //}
        
       
    }
}
