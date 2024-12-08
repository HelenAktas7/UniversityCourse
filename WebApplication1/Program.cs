using Business.Abstract;
using Business.Concreate;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(); // API Controller'larý ekle
builder.Services.AddEndpointsApiExplorer();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Geliþtirme sýrasýnda hata detaylarý için

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers(); // API Controller'larý yönlendir

app.Run();