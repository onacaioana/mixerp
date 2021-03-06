// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Office.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Office.Tests
{
    public class GetLoginIdTests
    {
        public static GetLoginIdController Fixture()
        {
            GetLoginIdController controller = new GetLoginIdController(new GetLoginIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetLoginIdController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}