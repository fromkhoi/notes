# GET
<input id="swagger" value='@Configuration.GetSection("ConnectionStrings")["HangFireConnection"]'/>

<input id="swagger" value='@Configuration["SwaggerURL"]'/>

# using
@using Microsoft.Extensions.Configuration
@inject IConfiguration Configuration

# appsettings.json
{
  "ApplicationInsights": {
    "InstrumentationKey": ""
  },

  "ConnectionStrings": {
    "HangFireConnection": "Server=192.168.1.235;Database=GoofMapper;User Id=sa;Password=imlv;MultipleActiveResultSets=True;"
  },

  "SwaggerURL": "localhost:52504/swagger/"
}

