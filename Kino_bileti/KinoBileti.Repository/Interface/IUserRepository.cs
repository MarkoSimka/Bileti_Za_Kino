﻿using KinoBileti.Domain.Idenitity;
using System;
using System.Collections.Generic;
using System.Text;

namespace KinoBileti.Repository.Interface
{
    public interface IUserRepository
    {
        IEnumerable<EShopApplicationUser> GetAll();
        EShopApplicationUser Get(string id);
        void Insert(EShopApplicationUser entity);
        void Update(EShopApplicationUser entity);
        void Delete(EShopApplicationUser entity);
    }
}