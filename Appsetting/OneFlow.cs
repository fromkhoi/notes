{
  "Common": {
    "SetupRoot": "\\\\192.168.1.235\\pconeflow-basic-setup\\basic\\root",
    "ServiceURLRouter": "http://192.168.1.235/print-service/api/v1/api-services/imlv"
  },
  "ConnectionStrings": {
    "DefaultConnection": "Addr=192.168.1.235; database=PCOneFlow_Basic; user id=sa; password=imlv",
    "HangFireConnection": "Data Source=192.168.1.235;Initial Catalog=PCOneFlow_Basic;Persist Security Info=True;User ID=sa;Password=imlv"
  },
  "MenuSetting": {
    "RecoveryActiveTab": "true",
    "RePrintImportActive": "true",
    "RecoveryListActive": "true"
  },
  "Logging": {
    "IncludeScopes": true,
    "LogLevel": {
      "Default": "Debug",
      "System": "Warning",
      "Microsoft": "Warning",
      "Microsoft.EntityFrameworkCore": "Debug",
      "Goof.PCOFCoreWebApp": "Information",
      "Goof.PCOFCoreWebApp.Trace": "Information"
    }
  },
  "TokenAuthentication": {
    "AuthenticationScheme": "printportalWebApp",
    "SecretKey": "secretkey_printportal123!",
    "Issuer": "printportalIssuer",
    "Audience": "printportalAudience",
    "TokenPath": "/api/token",
    "CookieName": "access_token",
    "ExpirationMinutes": "120"
  },
  "DocumentBoxAuthentication": {
    "Token": "PCOneFlow",
    "Type": "0"
  },
  "Seq": {
    "ServerUrl": "http://localhost:5341",
    "ApiKey": "1234567890",
    "MinimumLevel": "Information",
    "LevelOverride": {
      "Microsoft": "Warning"
    }
  }
}