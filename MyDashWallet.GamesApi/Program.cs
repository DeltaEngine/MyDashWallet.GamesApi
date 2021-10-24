var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.MapGet("/authenticate", () => "nadhei");
app.MapGet("/getProducts", () => "a b c");
app.MapGet("/getDash", () => "amount address lastDeposit lastWithdrawal lastTx");
app.MapGet("/buyProduct", () => "true");
app.Run();