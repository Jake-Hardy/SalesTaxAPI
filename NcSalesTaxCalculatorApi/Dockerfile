FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80/tcp

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["NcSalesTaxCalculatorApi.csproj", "./"]
RUN dotnet restore "NcSalesTaxCalculatorApi.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "NcSalesTaxCalculatorApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NcSalesTaxCalculatorApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NcSalesTaxCalculatorApi.dll"]