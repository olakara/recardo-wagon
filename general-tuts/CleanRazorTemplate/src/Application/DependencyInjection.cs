﻿using System.Net.Http.Headers;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
   public static IServiceCollection AddApplicationServices(this IServiceCollection services)
   {
      return services;
   }
}