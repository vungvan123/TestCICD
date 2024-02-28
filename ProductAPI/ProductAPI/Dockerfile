# Use the official .NET 5 SDK image
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build

WORKDIR /app

# Copy the project files and restore dependencies
COPY . .
RUN dotnet restore

# Build the application
RUN dotnet publish -c Release -o out

# Use the official .NET 5 runtime image
FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime

WORKDIR /app

# Copy the published output from the build stage
COPY --from=build /app/out .

# Set the entry point for the application
ENTRYPOINT ["dotnet", "ProductAPI.dll"]