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
    public class LoginController : ApiController
    {
        private IBusinessMember member;

        public LoginController(IBusinessMember _member)
        {
            member = _member;
        }

        [System.Web.Mvc.HttpPost]
        public HttpResponseMessage Find([FromBody]MemberDTO val)
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.member.Check(val));
        }

    }
}
