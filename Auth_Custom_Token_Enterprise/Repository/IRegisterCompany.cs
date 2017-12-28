﻿using Auth_Custom_Token_Enterprise.Models;
using System.Collections.Generic;

namespace Auth_Custom_Token_Enterprise.Repository
{
    public interface IRegisterCompany
    {
        IEnumerable<RegisterCompany> ListofCompanies(int UserID);
        void Add(RegisterCompany entity);
        void Delete(RegisterCompany entity);
        RegisterCompany FindCompanyByUserId(int UserID);
        bool ValidateCompanyName(RegisterCompany registercompany);
        bool CheckIsCompanyRegistered(int UserID);
    }
}
