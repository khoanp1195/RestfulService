using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PlaneClient
{
    class PlaneBUS
    {
        String URI = "http://www.khoaaa.somee.com/api/planes";
        public List<Plane> GetAll()
        {
            WebClient client = new WebClient();
            String response = client.DownloadString(URI);
            List<Plane> planes = JsonConvert.DeserializeObject<List<Plane>>(response);
            return planes;
        }

        public Plane GetDetails(int Id)
        {
            WebClient client = new WebClient();
            String response = client.DownloadString(URI + "/" + Id);
            Plane plane = JsonConvert.DeserializeObject<Plane>(response);
            return plane;
        }
        public bool AddNew(Plane newPlane)
        {
            String data = JsonConvert.SerializeObject(newPlane);
            WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            String response = client.UploadString(URI, "POST", data);
            bool result = bool.Parse(response);
            return result;

        }
        public bool Update(Plane newPlane)
        {
            String data = JsonConvert.SerializeObject(newPlane);
            WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            String response = client.UploadString(URI + "/" + newPlane.Id, "PUT", data);
            return bool.Parse(response);
        }
        public bool Delete(int Id)
        {
            WebClient client = new WebClient();
            String response = client.UploadString(URI + "/" + Id, "DELETE", "");
            return bool.Parse(response);
        }
        public List<Plane> Search(String keyword)
        {
            WebClient client = new WebClient();
            String response = client.DownloadString(URI + "/search/" + keyword);
            return JsonConvert.DeserializeObject<List<Plane>>(response);
        }
    }

}
