﻿namespace SdvCode.Tests.Profile.Controller
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;
    using Moq;
    using SdvCode.Constraints;
    using SdvCode.Controllers;
    using SdvCode.Models.User;
    using SdvCode.Services.Profile;
    using System;
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Text;
    using System.Threading.Tasks;
    using Xunit;

    public class DeleteActivityByIdTests
    {
        [Fact]
        public async Task DeleteActivityByIdShouldReturnCorrectViewModel()
        {
            ApplicationUser user = new ApplicationUser { UserName = "pesho" };

            var mockService = new Mock<IProfileService>();
            mockService.Setup(x => x.DeleteActivityById(user, 1))
                .ReturnsAsync("Test");

            var mockUserManager = new Mock<UserManager<ApplicationUser>>(
                    new Mock<IUserStore<ApplicationUser>>().Object,
                    new Mock<IOptions<IdentityOptions>>().Object,
                    new Mock<IPasswordHasher<ApplicationUser>>().Object,
                    new IUserValidator<ApplicationUser>[0],
                    new IPasswordValidator<ApplicationUser>[0],
                    new Mock<ILookupNormalizer>().Object,
                    new Mock<IdentityErrorDescriber>().Object,
                    new Mock<IServiceProvider>().Object,
                    new Mock<ILogger<UserManager<ApplicationUser>>>().Object);
            mockUserManager.Setup(x => x.GetUserAsync(It.IsAny<ClaimsPrincipal>()))
                .ReturnsAsync(user);

            var roleStore = new Mock<IRoleStore<ApplicationRole>>();
            var roleManagerMock =
                new Mock<RoleManager<ApplicationRole>>(roleStore.Object, null, null, null, null);

            var httpContext = new DefaultHttpContext();
            var tempData = new TempDataDictionary(httpContext, Mock.Of<ITempDataProvider>());
            var controller = new ProfileController(mockUserManager.Object, roleManagerMock.Object, mockService.Object)
            {
                TempData = tempData,
            };

            var result = await controller.DeleteActivityById(user.UserName, 1);
            Assert.IsType<RedirectResult>(result);

            var redirect = result as RedirectResult;
            Assert.Equal($"/Profile/{user.UserName}", redirect.Url);

            Assert.True(controller.TempData.ContainsKey("Success"));
            Assert.Equal(
                string.Format(SuccessMessages.SuccessfullyDeletedActivityById, "Test"),
                controller.TempData["Success"]);
        }
    }
}