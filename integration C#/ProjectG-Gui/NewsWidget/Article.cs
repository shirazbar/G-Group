using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectG_Gui.NewsWidget
{
    class Article
    {
        private string title;
        private string url;

        public Article()
        {
            title = null;
            url = null;
        }
        public string getTitle()
        {
            return this.title;
        }
        public string getUrl()
        {
            return this.url;
        }
        public bool setTitle(string title)
        {
            if (title == null)
                return false;
            this.title = title;
            return true;
        }
        public bool setUrl(string url)
        {
            if (url == null)
                return false;
            this.url = url;
            return true;
        }
    }
}
