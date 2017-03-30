using ProjectTemplate.Web.DependencyResolution;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;

namespace ProjectTemplate.WebAPI.DependencyResolution
{
	public class StructureMapWebApiDependencyScope : StructureMapDependencyScope, IDependencyScope
	{
		public StructureMapWebApiDependencyScope(IContainer container)
			: base(container)
		{
		}
	}
}