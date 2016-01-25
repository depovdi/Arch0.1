using System;
using AutoMapper;
using NUnit.Framework;
using Rf.Web;

namespace Rf.Web.Tests.Infrastructure
{
    [TestFixture]
    public class AutoMapperTests
    {
        [Test]
        public void All_mappings_should_be_configured_correctly()
        {
            var startup = new Startup();
            startup.ConfigureAutomapper();

            Mapper.AssertConfigurationIsValid();
        }
    }
}
