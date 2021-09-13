FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["4.WebApi/QuizPlayer.WebApi/QuizPlayer.WebApi.csproj", "4.WebApi/QuizPlayer.WebApi/"]
COPY ["1.Domain/QuizPlayer.Domain.Entities/QuizPlayer.Domain.Entities.csproj", "1.Domain/QuizPlayer.Domain.Entities/"]
COPY ["2.Infraestructure/QuizPlayer.Infra.IoC/QuizPlayer.Infra.IoC.csproj", "2.Infraestructure/QuizPlayer.Infra.IoC/"]
COPY ["3.Application/QuizPlayer.Application.Services/QuizPlayer.Application.Services.csproj", "3.Application/QuizPlayer.Application.Services/"]
COPY ["3.Application/QuizPlayer.Application.Contracts/QuizPlayer.Application.Contracts.csproj", "3.Application/QuizPlayer.Application.Contracts/"]
COPY ["3.Application/QuizPlayer.Application.Interfaces/QuizPlayer.Application.Interfaces.csproj", "3.Application/QuizPlayer.Application.Interfaces/"]
COPY ["1.Domain/QuizPlayer.Domain.Services/QuizPlayer.Domain.Services.csproj", "1.Domain/QuizPlayer.Domain.Services/"]
COPY ["1.Domain/QuizPlayer.Domain.Interfaces/QuizPlayer.Domain.Interfaces.csproj", "1.Domain/QuizPlayer.Domain.Interfaces/"]
COPY ["2.Infraestructure/QuizPlayer.Infra.Data/QuizPlayer.Infra.Data.csproj", "2.Infraestructure/QuizPlayer.Infra.Data/"]
RUN dotnet restore "4.WebApi/QuizPlayer.WebApi/QuizPlayer.WebApi.csproj"
COPY . .
WORKDIR "/src/4.WebApi/QuizPlayer.WebApi"
RUN dotnet build "QuizPlayer.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "QuizPlayer.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
EXPOSE 80/tcp
ENTRYPOINT ["dotnet", "QuizPlayer.WebApi.dll"]