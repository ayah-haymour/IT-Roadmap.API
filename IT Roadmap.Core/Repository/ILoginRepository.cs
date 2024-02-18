using IT_Roadmap.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Roadmap.Core.Repository
{
    public interface ILoginRepository
    {
        User GenerateToken(User users);

    }
}
