﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestuarantApplication_03_03_2023.Startup))]
namespace RestuarantApplication_03_03_2023
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
