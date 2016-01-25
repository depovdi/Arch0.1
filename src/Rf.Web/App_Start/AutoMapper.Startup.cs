using AutoMapper;
using Rf.Web.Configuration.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rf.Web
{
    public partial class Startup
    {
        public void ConfigureAutomapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<FormulierMappingProfile>();
            });
        }
    }
}