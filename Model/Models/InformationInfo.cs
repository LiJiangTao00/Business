using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class InformationInfo
    {
        public int InfoId { get; set; }
        public string InfoTitle { get; set; }
        public string InfoContents { get; set; }
        public string InfoAuthor { get; set; }
        public DateTime InfoAddtime { get; set; }
    }
}
