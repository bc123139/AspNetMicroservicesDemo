var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

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

app.UseAuthorization();

app.MapControllers();

app.Run();


//CREATE TABLE Coupon(
//		ID SERIAL PRIMARY KEY         NOT NULL,
//		ProductName     VARCHAR(24) NOT NULL,
//		Description     TEXT,
//		Amount          INT
//	);

//INSERT INTO Coupon (ProductName, Description, Amount) VALUES('IPhone X', 'IPhone Discount', 150);

//INSERT INTO Coupon (ProductName, Description, Amount) VALUES('Samsung 10', 'Samsung Discount', 100);
