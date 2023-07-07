using BusinessAccessLayer.Services.customer;
using BusinessAccessLayer.Services.doctor;
using BusinessAccessLayer.Services.healthplan;
using BusinessAccessLayer.Services.insurance;
using BusinessAccessLayer.Services.result;
using BusinessAccessLayer.Services.Services.Login;
using BusinessAccessLayer.Services.Services.medicare;
using DataAccessLayer.Contracts;
using DataAccessLayer.Contracts.Contracts;
using DataAccessLayer.DataAccess;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
       .AddJwtBearer(options =>
       {
           options.TokenValidationParameters = new TokenValidationParameters
           {
               ValidateIssuer = true,
               ValidateAudience = true,
               ValidateLifetime = true,
               ValidIssuer = builder.Configuration["Jwt:Issuer"],
               ValidAudience = builder.Configuration["Jwt:Audience"],
               IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
           };
       });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



//Services
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IDoctorRepository, DoctorRepository>();
builder.Services.AddScoped<IResultRepository, ResultRepository>();
builder.Services.AddScoped<IHealthPlanRepository, HealthPlanRepository>();
builder.Services.AddScoped<IInsuranceRepository, InsuranceRepository>();
builder.Services.AddScoped<IMedicareServiceRepository, MedicareServiceRepository>();
builder.Services.AddScoped<ILoginRepository, LoginRepository>();


builder.Services.AddScoped<IServiceCustomer, ServiceCustomer>();
builder.Services.AddScoped<IServiceDoctor, ServiceDoctor>();
builder.Services.AddScoped<IServiceHealthPlan, ServiceHealthPlan>();
builder.Services.AddScoped<IServiceInsurance,ServiceInsurance>();
builder.Services.AddScoped<IServiceMedicare,ServiceMedicare>();
builder.Services.AddScoped<IServiceResult,ServiceResult>();
builder.Services.AddScoped<IServiceLogin, ServiceLogin>();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseAuthentication();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
