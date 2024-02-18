﻿using IT_Roadmap.Core.Data;
using IT_Roadmap.Core.Repository;
using IT_Roadmap.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Roadmap.Infra.Service
{
    public class ContactUsService : IContactUsService
    {
        private readonly IContactUsRepository _contactuRepository;

        public ContactUsService(IContactUsRepository contactuRepository)
        {
            _contactuRepository = contactuRepository;
        }

        public List<Contactu> GetAllContactus()
        {
            return _contactuRepository.GetAllContactus();
        }

        public Contactu GetContactusById(decimal id)
        {
            return _contactuRepository.GetContactusById(id);
        }

        public void CreateContactus(Contactu contactuData)
        {
            _contactuRepository.CreateContactus(contactuData);
        }



        public void DeleteContactus(decimal id)
        {
            _contactuRepository.DeleteContactus(id);
        }
    }
}
