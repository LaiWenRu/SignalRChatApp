using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignalR.Models;

namespace SignalR.ViewModels
{
    public class ChatViewModel
    {
        #region Properties
        public UserModel User { get; set; }
        public MessageModel Message { get; set; }
        public bool Logged { get; set; } = false;
        #endregion

        #region CTOR
        public ChatViewModel()
        {

        }
        #endregion

        #region Public Methods

        #endregion
    }
}
