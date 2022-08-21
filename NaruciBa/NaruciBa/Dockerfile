FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 5001
ENV ASPNETCORE_URLS=http://+:5001

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["NaruciBa/NaruciBa.csproj", "NaruciBa/"]
COPY ["NaruciBa.Model/NaruciBa.Model.csproj", "NaruciBa.Model/"]
RUN dotnet restore "NaruciBa/NaruciBa.csproj"
COPY . .
WORKDIR "NaruciBa"
RUN dotnet build "NaruciBa.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NaruciBa.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
ADD ./NaruciBa/Images ./Images
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NaruciBa.dll"]