using IT_Roadmap.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Roadmap.Core.Service
{
    public interface IContactUsService
    {
        List<Contactu> GetAllContactus();
        Contactu GetContactusById(decimal id);
        void CreateContactus(Contactu contactusData);
        void DeleteContactus(decimal id);
    }
}
