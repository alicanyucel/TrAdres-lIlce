Türkiyenin il ve ilçeleri
C# ,.Net Core Web Api
TAMAMLANDI

# TrAdresılIlce (.NET 8)

Türkiye için ülke/il/ilçe verilerini yöneten katmanlı bir Web API projesi.

- Dil/Çatı: .NET 8, C# 12
- Mimarî: Domain, Application, Infrastructure, WebAPI (clean/layered)
- Paketler: EF Core, ASP.NET Core Identity, MediatR, Scrutor, TS.Result, TS.GenericRepository

## Proje Yapısı
- `TrAdresılIlce.Domain`: Temel `Entity` sınıfları ve repository arayüzleri
- `TrAdresılIlce.Application`: Use case’ler (MediatR komut/sorgu), sabit veriler (`CountryConstants`, `ProvinceConstant`, `DistrictConstant`)
- `TrAdresılIlce.Infrastructure`: EF Core `ApplicationDbContext`, repository implementasyonları, migrations, DI
- `TrAdresılIlce.WebAPI`: API uçları, middleware’ler, program başlatma

## Çalıştırma (Docker Compose ile)
- Gereksinimler: Docker, Docker Compose
- Komutlar:
  - `docker compose up -d`
  - API varsayılan: `http://localhost:8080`
  - SQL Server: `localhost:1433` (`sa` / `Your_password123`)

`docker-compose.yml` içindeki `ConnectionStrings__SqlServer` değişkeni ile bağlantı dizesi API’ye aktarılır.

## Çalıştırma (Yerel)
- Gereksinimler: .NET 8 SDK, SQL Server
- Adımlar:
  - `appsettings.json` içindeki `ConnectionStrings:SqlServer` değerini güncelle
  - `dotnet restore` (çözüm kökünde)
  - `dotnet build`
  - EF Core migrationları uygula (Visual Studio veya CLI üzerinden)
  - `TrAdresılIlce.WebAPI` çalıştır

Geliştirme ortamında Swagger: `/swagger`

## Veri Ekleme (Seed Uçları)
Sabit verileri DB’ye yazmak için sırasıyla:
- `POST` `api/locations/createcountry` — `Country` (Türkiye) ekler (Id=1, `IDENTITY_INSERT` ile) ve varsa tekrar eklemez
- `POST` `api/locations/createprovinces` — 81 il ekler (Id’ler 1..81, `IDENTITY_INSERT` ile), zaten ekli ise atlar
- `POST` `api/locations/createdistricts` — İlçeleri ekler (Id’ler 1’den başlar), zaten ekli ise atlar

Listeleme (POST olarak tanımlıdır):
- `POST` `api/locations/getallcountries`
- `POST` `api/locations/getallprovinces`
- `POST` `api/locations/getalldistricts`

Notlar:
- Id’ler deterministik olacak şekilde `IDENTITY_INSERT` ile sabitlenmiştir.
- İlçeler, il isimlerine göre `ProvinceId` eşlemesiyle eklenir; önce illerin eklenmesi gerekir.

## Geliştirme İpuçları
- DI, `TrAdresılIlce.Infrastructure.DependencyInjection.AddInfrastructure` ile yapılır
- Repositoryler `GenericRepository` tabanını ve arayüzleri kullanır (`ICountryRepository`, `IProvinceRepository`, `IDistrictRepository`)
- `MediatR` ile handler’lar: `SetCountryCommandHandler`, `SetProvincesCommandHandler`, `SetDistrictCommandHandler`

## Lisans
Bu depo eğitim/örnek amaçlıdır.
