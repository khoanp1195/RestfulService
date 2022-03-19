using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using PlaneSite.Models;

namespace PlaneSite.Controllers
{
    [EnableCors(origins:"*", headers:"*", methods:"*")]
    public class PlaneController : ApiController
    {
     [HttpGet]
     [Route("api/planes")]
        public List<Plane> GetAll()
        {
            List<Plane> planes = new PlaneDAO().SelectAll();
            return planes;
        }


        [HttpGet]
        [Route("api/planes/search/{keyword}")]
        public List<Plane> Search(String keyword)
        {
            List<Plane> planes = new PlaneDAO().SelectByKeyword(keyword);
            return planes;
        }

        [HttpGet]
        [Route("api/planes/{Id}")]
        public Plane GetDetails(int Id)
        {
            Plane plane = new PlaneDAO().SelectById(Id);
            return plane;
        }


        [HttpPost]
        [Route("api/planes")]
        public bool Addnew(Plane newPlane)
        {
            bool result = new PlaneDAO().Insert(newPlane);
            return result;
        }

        [HttpDelete]
        [Route("api/planes/{Id}")]
        public bool Delete(int Id)
        {
            bool result = new PlaneDAO().Delete(Id);
            return result;

        }

        [HttpPut]
        [Route("api/planes/{Id}")]
        public bool Update(int Id, Plane newPlane)
        {
            if (Id != newPlane.Id) return false;
            bool result = new PlaneDAO().Update(newPlane);
            return result;
        }
    }
}