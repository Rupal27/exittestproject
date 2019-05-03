using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Shared_Layer.DTO;
using Shared_Layer.Interface;

namespace DataConsensus.Controllers
{
    public class HouseController : ApiController
    {
        private IBusinessHouse member;

        public HouseController(IBusinessHouse _member)
        {
            member = _member;
        }

        [System.Web.Mvc.HttpGet]
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.member.Get(id));
        }


        public HttpResponseMessage GetAll()
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.member.GetAll());
        }


        [System.Web.Mvc.HttpPost]
        public HttpResponseMessage Add([FromBody]HouseListingDTO val)
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.member.Insert(val));
        }
        [System.Web.Mvc.HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.member.Delete(id));
        }

        [System.Web.Mvc.HttpGet]
        public HttpResponseMessage Get(string state)
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.member.StatePopulation());
        }

    }
}
