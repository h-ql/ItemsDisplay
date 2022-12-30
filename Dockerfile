


# FROM mcr.microsoft.com/dotnet/aspnet:7.0
# COPY . /app
# WORKDIR /app
# EXPOSE 8080
# ENV ASPNETCORE_URLS=http://*:8080
# ENTRYPOINT ["dotnet", "ItemsDisplay.dll"]

# FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
# WORKDIR /app
# COPY ItemsDisplay.csproj .
# RUN dotnet restore
# COPY . .
# RUN dotnet publish -c release -o /output

# FROM mcr.microsoft.com/dotnet/aspnet:7.0
# WORKDIR /output
# COPY --from=build /output .
# ENTRYPOINT [ "dotnet", "ItemsDisplay.dll" ]


FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app
COPY ["./src/ItemsDisplay.csproj", "./src"]
COPY ["./test/test.csproj", "test/"]

RUN dotnet restore ./src/ItemsDisplaySites.csproj
RUN dotnet build --no-restore
COPY . .

FROM build AS test
RUN dotnet test --no-build -c Release --results-directory /testresults --logger "trx;LogFileName=itemsdisplay_TestResults.trx" ./app/test/test.csproj

FROM build AS publish
RUN dotnet publish ./app/ItemsDisplay.csproj --no-restore -c Release -o ./app/src/publish

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /publish
COPY --from=build /publish .
ENTRYPOINT [ "dotnet", "ItemsDisplay.dll" ]