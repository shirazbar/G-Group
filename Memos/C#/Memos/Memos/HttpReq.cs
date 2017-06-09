using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xNet;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Memos
{
    class HttpReq
    {
        public HttpRequest req;
        public HttpResponse resp;
        public HttpReq()
        {
            this.req = new HttpRequest();
            req.Cookies = new CookieDictionary();
        }
        public JArray GetJson(String app)
        {
            if (app.Equals("Memos"))
            {
                resp = req.Get("http://localhost/G-Group/Memos/PHP/index.php");
            }
            string json = resp.ToString();
            var result = JsonConvert.DeserializeObject<JArray>(json);
            return result; //returns the representation of the json as an array object
        }


    }
}
