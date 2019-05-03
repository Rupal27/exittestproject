using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using BAL.BusinessLogic;
using DAL.Domain;
using Shared_Layer.DTO;
using Shared_Layer.Format;
using Shared_Layer.Interface;

namespace DataConsensus.Controllers
{
    public class MemberController : ApiController
    {
        private IBusinessMember member;

       public MemberController(IBusinessMember _member)
        {
            member = _member;
        }

        [System.Web.Mvc.HttpGet]
        public HttpResponseMessage Get(int id)
        {
            MemberDTO member = this.member.Get(id);
            member.ProfileImage = getImage(member.ProfileImage);
            return Request.CreateResponse(HttpStatusCode.OK, member);
        }


        public HttpResponseMessage GetAll()
        {

            List<MemberDTO> members = this.member.GetAll();
            for (int i = 0; i <members.Count(); i++)
            {
                members[i].ProfileImage = getImage(members[i].ProfileImage);
            }

            return Request.CreateResponse(HttpStatusCode.OK, this.member.GetAll());
        }

       
        [System.Web.Mvc.HttpPost]
        public HttpResponseMessage Add([FromBody]AddMemberModel model)
        {
            MemberDTO member = model.member;
            member.ProfileImage = saveImage(model.image, model.name);

        
            return Request.CreateResponse(HttpStatusCode.OK, this.member.Insert(member));
        }
        [System.Web.Mvc.HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, this.member.Delete(id));
        }

        public string saveImage(string image, string name)
        {
            string imageName = null;
            imageName = new string(Path.GetFileNameWithoutExtension(name).Take(10).ToArray()).Replace(" ", "-");
            imageName = imageName + DateTime.Now.ToString("yymmssfff") + Path.GetExtension(name);

            byte[] bytes = Convert.FromBase64String(image);
            using (Image actualImage = Image.FromStream(new MemoryStream(bytes)))
            {
                //actualImage.Save("output.jpg", ImageFormat.Jpeg); 
                actualImage.Save(System.Web.HttpContext.Current.Server.MapPath("~/Image/" + imageName));// Or Png
            }

            return imageName;
        }

        [System.Web.Mvc.HttpPost]
        public string getImage(string imageName)
        {

            string path = HttpContext.Current.Server.MapPath("~/Image/") + imageName;
            string base64String;
            using (System.Drawing.Image image = System.Drawing.Image.FromFile(path))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();
                    base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }

        }

    }
}
