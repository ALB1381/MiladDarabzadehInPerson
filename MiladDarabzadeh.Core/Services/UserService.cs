
using Microsoft.EntityFrameworkCore;
using MiladDarabzadeh.Core.Security;
using MiladDarabzadeh.Core.Services.Interfaces;
using MiladDarabzadeh.Data.Context;
using MiladDarabzadeh.Data.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiladDarabzadeh.Core.Services
{
    public class UserService : IUserService
    {
        #region Enjecations Part
        private MiladContext _context;
        IToolsService _toolsService;
        public UserService(MiladContext context, IToolsService toolsService)
        {
            _context = context;
            _toolsService = toolsService;
        }
        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        #endregion
        public async Task<bool> IsEmailExist(string email)
        {
            return await _context.Users.AnyAsync(c => c.UserEmail == email);
        }

        public async Task<bool> IsPhoneNumberExist(string PhoneNumber)
        {
            return await _context.Users.AnyAsync(c => c.UserPhoneNumber == PhoneNumber);
        }
    }
}
