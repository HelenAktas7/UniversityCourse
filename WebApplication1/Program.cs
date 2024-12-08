using Business.Abstract;
using Business.Concreate;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(); // API Controller'lar� ekle
builder.Services.AddEndpointsApiExplorer();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Geli�tirme s�ras�nda hata detaylar� i�in

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers(); // API Controller'lar� y�nlendir

app.Run();