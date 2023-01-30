using AutoMapper;
using GamerAddict.Api.MapperProfiles;
using GamerAddict.BLL.Interfaces.Managers;
using GamerAddict.BLL.Manager;
using GamerAddict.BLL.Security;
using GamerAddict.DAL.Data;
using GamerAddict.DAL.Interfaces.Repositories;
using GamerAddict.DAL.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddControllersWithViews()
    .AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer("name=ConnectionStrings:DefaultConnection"));

var domain = "https://dev-c4fngek5.us.auth0.com/";
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.Authority = domain;
    options.Audience = "http://localhost:5081";
});

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("read: comments", policy => policy.Requirements.Add(new HasScopeRequirement("delete:comment", domain)));
});

builder.Services.AddCors();

builder.Services.AddSingleton<IAuthorizationHandler, HasScopeHandler>();

builder.Services.AddAutoMapper(typeof(MapperProfiles).Assembly);

builder.Services.AddScoped<IAnswerRepository, AnswerRepository>();
builder.Services.AddScoped<IAnswerManager, AnswerManager>();
builder.Services.AddScoped<ICityRepository, CityRepository>();
builder.Services.AddScoped<ICityManager, CityManager>();
builder.Services.AddScoped<ICommentRepository, CommentRepository>();
builder.Services.AddScoped<ICommentManager, CommentManager>();
builder.Services.AddScoped<IDeveloperRepository, DeveloperRepository>();
builder.Services.AddScoped<IDeveloperManager, DeveloperManager>();
builder.Services.AddScoped<IPlateformRepository, PlateformRepository>();
builder.Services.AddScoped<IPlateformManager, PlateformManager>();
builder.Services.AddScoped<IPlateform_VideoGameRepository, Plateform_VideoGameRepository>();
builder.Services.AddScoped<IPlateform_VideoGameManager, Plateform_VideoGameManager>();
builder.Services.AddScoped<IPublisherRepository, PublisherRepository>();
builder.Services.AddScoped<IPublisherManager, PublisherManager>();
builder.Services.AddScoped<IQuestionRepository, QuestionRepository>();
builder.Services.AddScoped<IQuestionManager, QuestionManager>();
builder.Services.AddScoped<IReportRepository, ReportRepository>();
builder.Services.AddScoped<IReportManager, ReportManager>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserManager, UserManager>();
builder.Services.AddScoped<IUser_VideoGameRepository, User_VideoGameRepository>();
builder.Services.AddScoped<IUser_VideoGameManager, User_VideoGameManager>();
builder.Services.AddScoped<IVideoGameRepository, VideoGameRepository>();
builder.Services.AddScoped<IVideoGameManager, VideoGameManager>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseAuthorization();

app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.MapControllers();

app.Run();

