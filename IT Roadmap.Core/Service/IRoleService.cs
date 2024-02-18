﻿using IT_Roadmap.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Roadmap.Core.Service
{
    public interface IRoleService
    {
        List<Role> GetAllRoles();
        Role GetRoleById(decimal id);
        void CreateRole(Role roleData);
        void UpdateRole(Role roleData);
        void DeleteRole(decimal id);
    }
}
