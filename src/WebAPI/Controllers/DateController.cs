using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectTemplate.WebAPI.Controllers
{
    public class DateController : ApiController
    {
		private DateTime _date;

		public DateController(DateTime date)
		{
			_date = date;
		}

		public HttpResponseMessage Get() {
			return Request.CreateResponse(HttpStatusCode.OK, _date.ToShortDateString());
		}
    }
}
