//using MiladDarabzadeh.Core.DTOs;
using MiladDarabzadeh.Data.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiladDarabzadeh.Core.Services.Interfaces
{
    public interface IUserService
    {
        public Task<bool> IsEmailExist(string email);
        public Task<bool> IsPhoneNumberExist(string PhoneNumber);
    }
}
