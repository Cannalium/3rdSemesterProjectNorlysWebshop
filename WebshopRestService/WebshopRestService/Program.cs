using WebshopRestService.BusinessLogicLayer;
using WebshopData.DatabaseLayer;

var builder = WebApplication.CreateBuilder(args);

// Add services

builder.Services.AddControllers();

//Add services to the container:

//Order

builder.Services.AddSingleton<IOrderAccess, OrderDatabaseAccess>();
builder.Services.AddSingleton<IOrderData, OrderDataControl>();

//OrderLine

builder.Services.AddSingleton<IOrderLineAccess, OrderLineDatabaseAccess>(); 
builder.Services.AddSingleton<IOrderLineData,  OrderLineDataControl>();

//Person

builder.Services.AddSingleton<IPersonAccess, PersonDatabaseAccess>();
builder.Services.AddSingleton<IPersonData, PersonDataControl>();

//Product

builder.Services.AddSingleton<IProductAccess, ProductDatabaseAccess>(); 
builder.Services.AddSingleton<IProductData, ProductDataControl>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
