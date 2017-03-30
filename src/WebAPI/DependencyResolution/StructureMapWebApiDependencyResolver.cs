using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;

namespace ProjectTemplate.WebAPI.DependencyResolution
{
	public class StructureMapWebApiDependencyResolver : StructureMapWebApiDependencyScope, IDependencyResolver
	{
		public StructureMapWebApiDependencyResolver(IContainer container)
			: base(container)
		{
		}
		public IDependencyScope BeginScope()
		{
			IContainer child = this.Container.GetNestedContainer();
			return new StructureMapWebApiDependencyResolver(child);
		}
	}
}