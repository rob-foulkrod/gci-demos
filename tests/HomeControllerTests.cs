using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using blowfish.web.Controllers;

namespace blowfish.web.tests;

public class HomeControllerTests
{
    [Fact]
    public void Index_Returns_ViewResult()
    {
        // Arrange
        var controller = new HomeController(new NullLogger<HomeController>());

        // Act
        var result = controller.Index() as ViewResult;

        // Assert
        Assert.NotNull(result);
    }

    [Fact]
    public void Privacy_Returns_ViewResult()
    {
        // Arrange
        var controller = new HomeController(new NullLogger<HomeController>());

        // Act
        var result = controller.Privacy() as ViewResult;

        // Assert
        Assert.NotNull(result);
    }
}
