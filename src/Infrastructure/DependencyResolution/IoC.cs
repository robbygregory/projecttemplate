using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap.Graph;
using System.Diagnostics;

namespace ProjectTemplate.Infrastructure.DependencyResolution
{
	public static class IoC
	{
		public static IContainer Initialize(IRegistrationConvention[] conventions = null)
		{
			var container = new Container(x => x.Scan(scanner => {
				var rootNamespace = "ProjectTemplate";
				scanner.AssembliesFromApplicationBaseDirectory(a => a.FullName.Contains(rootNamespace));
				if (conventions != null)
				{
					foreach (var convention in conventions)
					{
						scanner.With(convention);
					}
				}
				scanner.WithDefaultConventions();
				scanner.LookForRegistries();
			}));
			Debug.Write(container.WhatDoIHave());
			return container;
		}
	}
}