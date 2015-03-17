using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace PitchFx.Api.Controllers
{
    public class PitcherController : ApiController
    {
        // GET api/Pitcher/5
        public string Get(int id)
        {
            return "this is a pitcher";
        }
    }
}