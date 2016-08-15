using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: /Store
        public string Index()
        {
            return "Hello from Store.Index()";
        }

        // GET: /Store/Browse
        public string Browse(string id)
        {
            return string.Format("Hello from Store.Browse({0})", id);
        }

        // GET: /Store/Details/id
        public string Details(int id)
        {
            return string.Format("Hello from Store.Details[{0}]", id);
        }
    }
}