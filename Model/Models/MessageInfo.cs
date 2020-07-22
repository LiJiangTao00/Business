using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class MessageInfo
    {
        public int ProductId { get; set; }
        public int MessageId { get; set; }
        public string MessageType { get; set; }
        public string Messagetitle { get; set; }
        public string Messagecontent { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; }
        public DateTime Commentdate { get; set; }
    }
}
