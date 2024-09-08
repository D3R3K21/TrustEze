FROM mcr.microsoft.com/dotnet/sdk AS build-env
WORKDIR /app
COPY . .
RUN dotnet restore ./TrustEze/TrustEze.csproj
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0

#ENV CLIENT_ID
#ENV CLIENT_SECRET
#ENV COGNITO_URI
#ENV CALLBACK_URI

WORKDIR /app
COPY --from=build-env /app/out ./
COPY ./etc-letsencrypt/live/trusteze.co/fullchain.pem /etc/letsencrypt/live/trusteze.co/fullchain.pem
COPY ./etc-letsencrypt/live/trusteze.co/privkey.pem /etc/letsencrypt/live/trusteze.co/privkey.pem
EXPOSE 8080
EXPOSE 80
EXPOSE 443


ENTRYPOINT ["dotnet", "./TrustEze.dll"]