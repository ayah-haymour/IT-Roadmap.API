﻿using IT_Roadmap.Core.Common;
using IT_Roadmap.Core.Data;
using IT_Roadmap.Core.DTO;
using IT_Roadmap.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IT_Roadmap.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IDbContext dbContext;

        public UserController(IUserService userService, IDbContext _dbContext)
        {
            _userService = userService;
            this.dbContext = _dbContext;
        }

        [HttpGet]
        [Route("GetAllUsers")]
        public ActionResult<List<User>> GetAllUsers()
        {
            return _userService.GetAllUsers();
        }

        [HttpGet]
        [Route("GetUserCount")]
        public int GetUserCount()
        {
            return _userService.GetUserCount();
        }

        [HttpGet]
        [Route("GetAllUsersEmail")]
        public ActionResult<List<AllUsersEmails>> GetAllUsersEmail()
        {
            return _userService.GetAllUsersEmail();
        }

        [HttpGet]
        [Route("GetUserById/{id}")]
        public ActionResult<User> GetUserById(decimal id)
        {
            return _userService.GetUserById(id);
        }

        [HttpPost]
        [Route("CreateUser")]
        //[Authorize]
        // [RequiresClaim("roleid", "1")]
        public IActionResult CreateUser(User user)
        {

            _userService.CreateUser(user);
            return Ok();
        }

        [HttpPut]
        [Route("UpdateUser")]
        //[Authorize]
        // [RequiresClaim("roleid", "1")]
        public IActionResult UpdateUser(User user)
        {


            _userService.UpdateUser(user);
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteUser/{id}")]
        public IActionResult DeleteUser(decimal id)
        {
            _userService.DeleteUser(id);
            return Ok();
        }

        [HttpPost]
        [Route("UploadImage")]
        public User UploadImage()
        {
            var file = Request.Form.Files[0];
            var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var fullPath = Path.Combine("C:\\Users\\Amjad\\IT_Roadmap\\src\\assets\\Images", fileName);
            using (var stream = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            User item = new User();
            item.Profileimage = fileName;
            return item;
        }
    }
}
