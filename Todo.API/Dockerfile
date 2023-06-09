#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR .
COPY ["Todo.API/Todo.API.csproj", "Todo.API/"]
COPY ["Todo.Application/Todo.Application.csproj", "Todo.Application/"]
COPY ["Todo.Domain/Todo.Domain.csproj", "Todo.Domain/"]
COPY ["Todo.Persistence/Todo.Persistence.csproj", "Todo.Persistence/"]
COPY ["Todo.Infra/Todo.Infra.csproj", "Todo.Infra/"]
RUN dotnet restore "Todo.API/Todo.API.csproj"
COPY . .
WORKDIR "/Todo.API"
RUN dotnet build "Todo.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Todo.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Todo.API.dll"]