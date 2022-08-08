namespace Discount.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            host.Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}


//CREATE TABLE Coupon(
//		ID SERIAL PRIMARY KEY         NOT NULL,
//		ProductName     VARCHAR(24) NOT NULL,
//		Description     TEXT,
//		Amount          INT
//	);

//INSERT INTO Coupon (ProductName, Description, Amount) VALUES('IPhone X', 'IPhone Discount', 150);

//INSERT INTO Coupon (ProductName, Description, Amount) VALUES('Samsung 10', 'Samsung Discount', 100);
