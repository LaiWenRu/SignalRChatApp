using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignalR.Models;

namespace SignalR.Controllers
{
    [Route("/[controller]/[action]")]
    public class ChatAPIController : Controller
    {
        [HttpGet]
        public IEnumerable<UserModel> UserListExamples()
        {
            return new List<UserModel>()
            {
                new UserModel() { Id = "1", Name = "Ru" },
                new UserModel() { Id = "2", Name = "Peace" },
                new UserModel() { Id = "3", Name = "Ken" },
                new UserModel() { Id = "4", Name = "John" },
                new UserModel() { Id = "5", Name = "Molly" },
            };
        }
        [HttpPost]
        public async Task SendMessage(MessageModel message)
        {

        }
    }
}
