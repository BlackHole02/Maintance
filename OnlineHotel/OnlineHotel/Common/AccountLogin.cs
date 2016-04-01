using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineHotel.Common
{
    [Serializable]
    public class AccountLogin
    {
        public int AccountID { set; get; }
        public string UserName { set; get; }
    }
}