FROM microsoft/aspnetcore:2.1
ARG source=.
WORKDIR /app
EXPOSE 80
COPY $source .
ENTRYPOINT ["dotnet", "DotNetCoreApp_Linux.dll"]