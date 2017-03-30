using StructureMap.Configuration.DSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTemplate.Infrastructure.DependencyResolution.Registries
{
	public class TestRegistry : Registry
	{
		public TestRegistry()
		{
			For<DateTime>().Transient().Use(x => new DateTime(2000, 1, 1));
		}
	}
}
