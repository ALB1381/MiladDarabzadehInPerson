using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using MiladDarabzadeh.Core.Convertors;
using MiladDarabzadeh.Core.Services;
using MiladDarabzadeh.Core.Services.Interfaces;
using MiladDarabzadeh.Data.Context;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
builder.Services.AddRazorPages();
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
}
).AddCookie(options =>
{
    options.LoginPath = "/Login";
    options.ExpireTimeSpan = TimeSpan.FromMinutes(43200);
    options.LogoutPath = "/Logout";

});
builder.WebHost.ConfigureKestrel(options =>
{
    options.Limits.MaxRequestBodySize = null; // Disable the request body limit
});

#region DataBaseContext
builder.Services.AddDbContext<MiladContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MiladdarabzadehConnection"));
}
);
#endregion

#region IOC
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IToolsService, ToolsService>();
builder.Services.AddTransient<ICourseService, CourseService>();
builder.Services.AddTransient<IResponsiveItemsService, ResponsiveItemsService>();
builder.Services.AddTransient<IViewRenderService, RenderViewToString>();
builder.Services.AddTransient<IRoleAndPermissionService, RoleAndPermissionService>();
builder.Services.AddTransient<IDiscountService, DiscountService>();
builder.Services.AddTransient<IOrderService, OrderService>();
builder.Services.AddTransient<IExamService, ExamService>();
#endregion

var app = builder.Build();

app.Use(async (context, next) =>
{
    var cultureQuery = context.Request;
    if (cultureQuery.Path.Value.ToString().ToLower().StartsWith("/courses/episodesfiles"))
    {
        var callingUrl = context.Request.Headers["Referer"].ToString();
        if ((callingUrl.StartsWith("http://miladdarabzade.ir") || callingUrl.StartsWith("https://miladdarabzade.ir/")) && callingUrl != "")
        {
            await next(context);
        }
        else
        {
            context.Response.Redirect("/ErrorResult");
        }
    }
    else
    {
        await next(context);
    }
    //var cultureQuery = context.Request.Query["culture"];
    //if (!string.IsNullOrWhiteSpace(cultureQuery))
    //{
    //    var culture = new CultureInfo(cultureQuery);

    //    CultureInfo.CurrentCulture = culture;
    //    CultureInfo.CurrentUICulture = culture;
    //}


});

app.UseAuthentication();

app.UseAuthorization();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "Areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );

app.MapRazorPages();

app.UseStatusCodePages();

if (!app.Environment.IsDevelopment())
{

    app.UseStatusCodePagesWithRedirects("/ErrorResult");

}

app.Run();