using Microsoft.EntityFrameworkCore;
using SpecialDP.Data;
using SpecialDP.Data.Repository;
using SpecialDP.Data.Repository.Interface;
using SpecialDP.Data.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Database
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
    );
//when use UnitOfwork, nomore register Repository DI
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(ICardRepository), typeof(CardRepository));
//
builder.Services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
//register MediatR
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));
builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
