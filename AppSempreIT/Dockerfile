#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build-env
WORKDIR /app
#EXPOSE 80
#EXPOSE 443

#copy csprojt e restaura as camadas.
COPY *.csproj ./
RUN dotnet restore

#Copia tudo e builda.
COPY ../
RUN dotnet publish -c Release -o out

#Build com a imagem do runtime.
FROM mcr.microsoft.com/dotnet/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app/out .

#Usa porta dinamica heroku app.
CMD ASPNETCORE_URLS="http://*:$PORT" dotnet AppSempreIT.dll

#COPY ["AppSempreIT/AppSempreIT.csproj", "AppSempreIT/"]
#RUN dotnet restore "AppSempreIT/AppSempreIT.csproj"
#COPY . .
#WORKDIR "/src/AppSempreIT"
#RUN dotnet build "AppSempreIT.csproj" -c Release -o /app/build
#
#FROM build AS publish
#RUN dotnet publish "AppSempreIT.csproj" -c Release -o /app/publish
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "AppSempreIT.dll"]