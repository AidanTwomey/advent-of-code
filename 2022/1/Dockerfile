FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
# WORKDIR .

# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore
RUN dotnet test
# Build and publish a release
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/runtime:7.0
WORKDIR /day-one.console
COPY --from=build-env /out .
ENTRYPOINT ["dotnet", "day-one.console.dll"]