using LinearRegression.WebApi.DataModels;
using Microsoft.Extensions.ML;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddPredictionEnginePool<TaxiFareModelInput, TaxiFareModelOutput>()
    .FromFile(modelName: "LinearRegression.MLModels.TaxiFareMLModel", filePath: "MLModels/TaxiFareMLModel.zip", watchForChanges: true);

builder.Services.AddPredictionEnginePool<WeatherModelInput, WearherModelOutput>()
    .FromFile(modelName: "LinearRegression.MLModels.WeatherMLModel", filePath: "MLModels/WeatherMLModel.zip", watchForChanges: true);

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

app.UseCors(x => x
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .SetIsOriginAllowed(origin => true)
                    .AllowCredentials());

app.UseAuthorization();

app.MapControllers();

app.Run();
