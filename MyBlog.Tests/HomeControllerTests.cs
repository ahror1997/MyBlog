using Microsoft.AspNetCore.Mvc;
using MyBlog.Controllers;
using Xunit;

namespace MyBlog.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void IndexViewDataMessage()
        {
            HomeController controller = new HomeController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.NotNull(result);            
            Assert.Equal("Hello World!", result.ViewData["Message"]);
            
        }        
    }
}