


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

COPY ./*.sln ./
COPY ./src/*.csproj ./src/
COPY ./test/*.csproj ./test/
RUN dotnet restore ./*.sln

COPY . .
RUN dotnet build --no-restore ./*.sln

FROM build AS test
WORKDIR /app/test
RUN dotnet test --no-restore -c Release --results-directory /TestResult --logger "trx;LogFileName=itemsdisplay_Test-Results.trx" 

FROM build AS publish
WORKDIR /app/src
RUN dotnet publish --no-restore -c Release -o ./out

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=publish /app/src/out ./
ENTRYPOINT [ "dotnet", "ItemsDisplay.dll" ]