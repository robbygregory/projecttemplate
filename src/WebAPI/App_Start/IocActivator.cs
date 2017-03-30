using ProjectTemplate.WebAPI;
using ProjectTemplate.WebAPI.DependencyResolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(IocActivator), "Start")]
namespace ProjectTemplate.WebAPI
{
	public class IocActivator
	{
		public static void Start()
		{
			var container = Web.IocActivator.StructureMapDependencyScope.Container;
			GlobalConfiguration.Configuration.DependencyResolver = new StructureMapWebApiDependencyResolver(container);
		}
	}
}