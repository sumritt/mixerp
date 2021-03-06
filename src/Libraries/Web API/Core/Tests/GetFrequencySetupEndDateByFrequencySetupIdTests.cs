// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetFrequencySetupEndDateByFrequencySetupIdTests
    {
        public static GetFrequencySetupEndDateByFrequencySetupIdController Fixture()
        {
            GetFrequencySetupEndDateByFrequencySetupIdController controller = new GetFrequencySetupEndDateByFrequencySetupIdController(new GetFrequencySetupEndDateByFrequencySetupIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetFrequencySetupEndDateByFrequencySetupIdController.Annotation());
            Assert.Equal(new DateTime(), actual);
        }
    }
}