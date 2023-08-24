using TestingProject.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
builder.Logging.AddConsole(options =>
{
    options.IncludeScopes = true;
    options.TimestampFormat = "HH:mm:ss ";
});


// Add services to the container.
//builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
//  ////dockercompose
//  //connectionString
//  builder.Configuration.GetConnectionString("DefaultConnection")
//  ));
builder.Services.AddScoped(typeof(ICardRepository), typeof(CardRepository));
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

public partial class Program { }
