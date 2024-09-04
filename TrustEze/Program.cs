using Microsoft.OpenApi.Models;
using System.Reflection;
using TrustEze.Models;


namespace TrustEze
{
    public class Program
    {


        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //builder.WebHost.UseUrls("http://localhost:8080;https://localhost:443");

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "ToDo API",
                    Description = "An ASP.NET Core Web API for managing ToDo items",
                    TermsOfService = new Uri("https://example.com/terms"),
                    Contact = new OpenApiContact
                    {
                        Name = "Example Contact",
                        Url = new Uri("https://example.com/contact")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Example License",
                        Url = new Uri("https://example.com/license")
                    }
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });

            builder.Services.AddCors();
            builder.Services.AddHttpClient();

            builder.Services.Configure<AuthControllerOptions>(p =>
            {
                p.CognitoUri = builder.Configuration["COGNITO_URI"] ?? throw new ArgumentNullException("COGNITO_URI");
                p.ClientSecret = builder.Configuration["CLIENT_SECRET"] ?? throw new ArgumentNullException("CLIENT_SECRET");
                p.ClientId = builder.Configuration["CLIENT_ID"] ?? throw new ArgumentNullException("CLIENT_ID");
                p.CallbackUri = builder.Configuration["CALLBACK_URI"] ?? throw new ArgumentNullException("CALLBACK_URI");
                p.HostedUIUri = builder.Configuration["HOSTED_UI_URI"] ?? throw new ArgumentNullException("HOSTED_UI_URI");
                p.FrontendRedirectURI = builder.Configuration["FRONTEND_REDIRECT_URI"] ?? throw new ArgumentNullException("FRONTEND_REDIRECT_URI");
            });

            var app = builder.Build();
            app.UseCors(x => x
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .SetIsOriginAllowed(origin => true)); // allow credentials

            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{
            app.UseSwagger();
            app.UseSwaggerUI();
            //app.UseSwaggerUI(c =>
            //{
            //    //c.SwaggerEndpoint("/swagger/v1/swagger.json", "TrustEze V1");
            //});
            //}

            app.UseHttpsRedirection();

            //app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}