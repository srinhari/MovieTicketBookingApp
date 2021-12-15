#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["MovieTicketBookingApp/MovieTicketBookingApp.csproj", "MovieTicketBookingApp/"]
RUN dotnet restore "MovieTicketBookingApp/MovieTicketBookingApp.csproj"
COPY . .
WORKDIR "/src/MovieTicketBookingApp"
RUN dotnet build "MovieTicketBookingApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MovieTicketBookingApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MovieTicketBookingApp.dll"]