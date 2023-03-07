FROM mcr.microsoft.com/dotnet/sdk:6.0 as build
WORKDIR /app
EXPOSE 80
COPY Shared/FreeCourse.Shared/*.csproj Shared/FreeCourse.Shared/
COPY Frontend/FreeCourse.Web/*.csproj Frontend/FreeCourse.Web/
RUN dotnet restore Frontend/FreeCourse.Web/*.csproj
COPY . .
RUN dotnet publish Frontend/FreeCourse.Web/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:6.0 as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","FreeCourse.Web.dll" ]