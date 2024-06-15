using budgetmanagementsystem.application.Contracts.Persistence;
using budgetmanagementsystem.infrastructure.expense.expenses.Filter;
using budgetmanagementsystem.infrastructure.Identity.Authenticate.Extension;
using budgetmanagementsystem.infrastructure.Identity.Authorisation;
using budgetmanagementsystem.infrastructure.Identity.Token;
using budgetmanagementsystem.infrastructure.Identity.UserClaim;
using budgetmanagementsystem.infrastructure.income.incomes.Filter;
using budgetmanagementsystem.persistence;
using budgetmanagementsystem.infrastructure.print.Print;
using budgetmanagementsystem.persistence.Extensions;
using budgetmanagementsystem.persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<budgetmanagementsystemDbContext>(options => options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDistributedMemoryCache();
builder.Services.AddAuthenticationExtension();
builder.Services.AddAuthorisationExtension();
builder.Services.AddTokenService();
builder.Services.AddClaim();
builder.Services.VerifyClaim();
builder.Services.addExpenseService();
builder.Services.AddIncomeService();
builder.Services.AddPrintService();
builder.Services.AddControllers();
builder.Services.AddScoped<IAsyncExpenseRepository, ExpenseRepository>();
builder.Services.AddScoped<IAsyncIncomeRepository, IncomeRepository>();
builder.Services.AddScoped<IAsyncUserRepository, UserRepository>();
builder.Services.AddScoped<IAsyncAdminRepository, AdminRepository>();
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

app.UseHttpsRedirection();
app.UseCors();
app.UseAuthentication();
app.UseAuthorization();
//app.UseSession();
app.MapControllers();

app.Run();
