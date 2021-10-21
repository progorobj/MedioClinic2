using System;
using Autofac;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using System.Reflection;
using XperienceAdapter.Repositories;
using XperienceAdapter.Localization;
using Microsoft.Extensions.Localization;
using XperienceAdapter.Services;
using Business.Repositories;

namespace MedioClinic1.Configuration
{
	public class AutoFacConfig
	{
		public void ConfigureContainer(ContainerBuilder builder)
		{
			builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
				.Where(type => type.IsClass && !type.IsAbstract && typeof(IService).IsAssignableFrom(type))
				.AsImplementedInterfaces()
				.InstancePerLifetimeScope();

			builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
				.Where(type => type.GetTypeInfo()
					.ImplementedInterfaces.Any(
						@interface => @interface.IsGenericType && @interface.GetGenericTypeDefinition() == typeof(IRepository<>)))
				.AsImplementedInterfaces()
				.InstancePerLifetimeScope();

			builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
				.Where(type => type.GetTypeInfo()
					.ImplementedInterfaces.Any(
						@interface => @interface.IsGenericType && @interface.GetGenericTypeDefinition() == typeof(IPageRepository<,>)))
				.AsImplementedInterfaces()
				.InstancePerLifetimeScope();

			builder.RegisterType<NavigationRepository>()
								.As<INavigationRepository>()
								.InstancePerLifetimeScope();

			builder.RegisterType<XperienceStringLocalizerFactory>().As<IStringLocalizerFactory>()
	            .InstancePerLifetimeScope();

			builder.RegisterType<RepositoryServices>().As<IRepositoryServices>()
	            .InstancePerLifetimeScope();
		}
	}
}
