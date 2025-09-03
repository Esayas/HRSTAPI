using HRSTAPI.Controllers;
using HRSTAPI.Extensions;
using HRSTAPI.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddSwaggerExplorer()
                .InjectDbContext(builder.Configuration)
                .AddAppConfig(builder.Configuration)
                .AddIdentityHandlersAndStore()
                .ConfigureIdentityOptions()                
                .AddIdentityAuth(builder.Configuration);

var app = builder.Build();

app.ConfigureSwaggerExplorer()
   .ConfigureCORS(builder.Configuration)
   .AddIdentityAuthMiddlewares();


app.MapControllers();

// Expose Identity endpoints like /register, /login, etc.

app.MapGroup("/api")
    .MapIdentityApi<AppUser>();
app.MapGroup("/api")
   .MapIdentityUserEndpoints();



app.Run();


