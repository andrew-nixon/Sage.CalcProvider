# Use the standard Microsoft .NET Core container
FROM microsoft/aspnetcore:1.1
 
WORKDIR /app
COPY ./bin/Debug/netcoreapp1.1/publish .

ENV ASPNETCORE_URLS http://+:80
EXPOSE 80
 
CMD ["dotnet", "spcs.dll"]