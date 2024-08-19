using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
//using MiladDarabzadeh.Core.Services.Interfaces;

namespace MiladDarabzadeh.Core.Security
{
    //public class PermissionCheckerAttribute : AuthorizeAttribute, IAuthorizationFilter
    //{
    //    IPermissionService _service;

    //    int _permissionId = 0;
    //    public PermissionCheckerAttribute(int PerId)
    //    {
    //        _permissionId = PerId;
    //    }

    //    public void OnAuthorization(AuthorizationFilterContext context)
    //    {
    //        _service = (IPermissionService)context.HttpContext.RequestServices.GetService(typeof(IPermissionService));
    //        if (!context.HttpContext.User.Identity.IsAuthenticated)
    //        {
    //            context.Result = new RedirectResult("/Login"+context.HttpContext.Request.Path);
    //        }
    //        else
    //        {
    //            string UserName = context.HttpContext.User.Identity.Name;
    //            if (!_service.IsThUserHaveAccessLevel(UserName,_permissionId))
    //            {
    //              context.Result = new RedirectResult("/");
    //            }
    //        }
    //    }
    //}
}
