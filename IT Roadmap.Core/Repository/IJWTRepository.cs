using IT_Roadmap.Core.Common;
using IT_Roadmap.Core.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Roadmap.Core.Repository
{
    public interface IJWTRepository
    {
        User Auth(User user);
    }
}
