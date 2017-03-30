using StructureMap.Configuration.DSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTemplate.Web.DependencyResolution.Registries
{
	public class HttpContextRegistry : Registry
	{
		public HttpContextRegistry()
		{
			For<HttpContextBase>().Transient().Use(x => new HttpContextWrapper(System.Web.HttpContext.Current));
		}
	}
}