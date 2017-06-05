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
        public String GetJson(String app)
        {
            var urlParams = new RequestParams();
            urlParams["site"] = app;
            if (app.Equals("bbc")|| app.Equals("abc")|| app.Equals("mtv")|| app.Equals("nyn"))
            {
                resp = req.Get("http://localhost/g-group/News/index.php", urlParams);
            }
            string json = resp.ToString();
            return json; 
        }


    }
}
