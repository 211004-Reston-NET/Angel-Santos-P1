# First our virtual OS will need the .NET 5.0 SDK
# We can utilize docker hub to access one of the published images from .NET themselves
FROM mcr.microsoft.com/dotnet/sdk:5.0 as build

#Setting our working directory
WORKDIR /app

# Time to copy our projects and paste it to the working directory
# * it is the wildcard meaning it'll grab anything in your folder that has .sln extension
COPY *.sln ./
COPY StoreBL/*.csproj StoreBL/
COPY StoreDL/*.csproj StoreDL/
COPY StoreModels/*.csproj StoreModels/
COPY ModelTest/*.csproj ModelTest/
COPY FrontStoreWebUI/*.csproj FrontStoreWebUI/

# We need to build/restore our files (bin & obj)
RUN cd FrontStoreWebUI && dotnet restore

# copy the source files
COPY . ./
#cmd /bin/bash It was to check if it copied everything and restored everything

# We need to publish the application and its dependencies to a folder for deployment
RUN dotnet publish FrontStoreWebUI -c Release -o publish --no-restore

# We change our base image to be the runtime since we already used the SDK to create the application itself
# This is to use a lot less memory
FROM mcr.microsoft.com/dotnet/aspnet:5.0 as runtime

WORKDIR /app
COPY --from=build /app/publish ./

CMD ["dotnet", "FrontStoreWebUI.dll"]

