


# FROM mcr.microsoft.com/dotnet/aspnet:7.0
# COPY . /app
# WORKDIR /app
# EXPOSE 8080
# ENV ASPNETCORE_URLS=http://*:8080
# ENTRYPOINT ["dotnet", "ItemsDisplay.dll"]

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app
COPY ItemsDisplay.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish -c release -o /output

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /output
COPY --from=build /output .
ENTRYPOINT [ "dotnet", "ItemsDisplay.dll" ]