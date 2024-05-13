FROM mcr.microsoft.com/dotnet/sdk
WORKDIR /app
COPY . .
RUN dotnet restore
RUN dotnet publish Environment.csproj -c Release -o out
WORKDIR out
ENV ASPNETCORE_URLS="http://*:1453"
ENTRYPOINT ["dotnet", "Environment.dll"]