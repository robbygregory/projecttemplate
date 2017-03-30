using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using ProjectTemplate.Infrastructure.DependencyResolution;
using ProjectTemplate.Web;
using ProjectTemplate.Web.DependencyResolution;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebActivatorEx;

[assembly: PreApplicationStartMethod(typeof(IocActivator), "Start")]
[assembly: ApplicationShutdownMethod(typeof(IocActivator), "End")]
namespace ProjectTemplate.Web
{
	public static class IocActivator
	{
		public static StructureMapDependencyScope StructureMapDependencyScope { get; set; }
		public static void End()
		{
			StructureMapDependencyScope.Dispose();
		}

		public static void Start()
		{
			IContainer container = IoC.Initialize();
			StructureMapDependencyScope = new StructureMapDependencyScope(container);
			DependencyResolver.SetResolver(StructureMapDependencyScope);
			DynamicModuleUtility.RegisterModule(typeof(StructureMapScopeModule));
		}
	}
}