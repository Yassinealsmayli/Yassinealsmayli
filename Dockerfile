# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy project file
COPY YassineAlsmayli/YassineAlsmayli.csproj .
RUN dotnet restore

# Copy everything else
COPY . .

# Build
WORKDIR "/src/YassineAlsmayli"
RUN dotnet build -c Release -o /app/build

# Publish stage (renamed from 'publish' to avoid confusion)
FROM build AS publish-stage
RUN dotnet publish -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish-stage /app/publish .
ENTRYPOINT ["dotnet", "YassineAlsmayli.dll"]