


# FROM mcr.microsoft.com/dotnet/aspnet:7.0
# COPY . /app
# WORKDIR /app
# EXPOSE 8080
# ENV ASPNETCORE_URLS=http://*:8080
# ENTRYPOINT ["dotnet", "ItemsDisplay.dll"]

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS build
WORKDIR /src
COPY *.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish -c release -o /app

FROM mcr.microsoft.com/dotnet/aspnet
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT [ "dotnet", "ItemsDisplay.dll" ]