
using TripSharePay_Repository.IoC;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

// This method gets called by the runtime. Use this method to add services to the container.
builder.Services.AddCors();
builder.Services.AddControllers();

//Extens�o para configurar a autoriza��o das rotas
//builder.Services.RegisterAuthorization(builder.Configuration);

builder.Services.AddEndpointsApiExplorer();

//Classe para configurar o Swagger
builder.Services.AddSwagger();

builder.Services.RegisterServices(builder.Configuration);
//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();