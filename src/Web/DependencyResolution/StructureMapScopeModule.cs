using StructureMap.Web.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTemplate.Web.DependencyResolution
{
	public class StructureMapScopeModule : IHttpModule
	{
		public void Dispose()
		{
		}

		public void Init(HttpApplication context)
		{
			context.BeginRequest += (sender, e) => IocActivator.StructureMapDependencyScope.CreateNestedContainer();
			context.EndRequest += (sender, e) => {
				HttpContextLifecycle.DisposeAndClearAll();
				IocActivator.StructureMapDependencyScope.DisposeNestedContainer();
			};
		}
	}
}