FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["TrAdresýlIlce/TrAdresýlIlce.WebAPI/TrAdresýlIlce.WebAPI.csproj", "TrAdresýlIlce/TrAdresýlIlce.WebAPI/"]
COPY ["TrAdresýlIlce/TrAdresýlIlce.Application/TrAdresýlIlce.Application.csproj", "TrAdresýlIlce/TrAdresýlIlce.Application/"]
COPY ["TrAdresýlIlce/TrAdresýlIlce.Domain/TrAdresýlIlce.Domain.csproj", "TrAdresýlIlce/TrAdresýlIlce.Domain/"]
COPY ["TrAdresýlIlce/TrAdresýlIlce.Infrastructure/TrAdresýlIlce.Infrastructure.csproj", "TrAdresýlIlce/TrAdresýlIlce.Infrastructure/"]
RUN dotnet restore "TrAdresýlIlce/TrAdresýlIlce.WebAPI/TrAdresýlIlce.WebAPI.csproj"
COPY . .
WORKDIR /src/TrAdresýlIlce/TrAdresýlIlce.WebAPI
RUN dotnet publish -c Release -o /app/publish /p:UseAppHost=false
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "TrAdresýlIlce.WebAPI.dll"]
