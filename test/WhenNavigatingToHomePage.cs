using Microsoft.Extensions.Logging.Abstractions;
using ItemsDisplay.Services;
using ItemsDisplay.Controllers;
using Microsoft.AspNetCore.Hosting;
using ItemsDisplay.Models;
using Microsoft.AspNetCore.Mvc;

namespace test;

public class WhenNavigatingToHomePage
{
    [Fact]
    public async void  ShouldGetDisplayingItem()
    {
        // arrange
        CharacterAttributeViewModel testVM = new();

        var env = new Moq.Mock<IWebHostEnvironment>();
        var service = new Moq.Mock<ICharacterService>();
        var controller = new CharacterController(
            NullLogger<CharacterController>.Instance,
            service.Object, env.Object
        );

        // act
        var respond = await controller.Index(null!, null!);
        
        // assert
        
        service.Verify(r => r.GetAllAsync(null!, null!), Moq.Times.AtLeastOnce);
    }  
}