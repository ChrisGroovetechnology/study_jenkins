using Microsoft.AspNetCore.Mvc;
using study_jenkins.Controllers;
using System;
using Xunit;

namespace study_jenkins.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var controller = new HomeController();
            Assert.IsType<ViewResult>(controller.Index());
        }
    }
}
