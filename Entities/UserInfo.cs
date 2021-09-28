using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagement.Entities
{
    public class UserInfo
    {
        Guid Id;
        String UserName { get; set; }
        
        String Password { get; set; }

        String CompanyName { get; set; }

    }
}
