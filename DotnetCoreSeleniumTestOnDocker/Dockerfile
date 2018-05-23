FROM selenium/standalone-chrome AS base
WORKDIR /app
RUN	cd ~ 
RUN	sudo wget -q packages-microsoft-prod.deb https://packages.microsoft.com/config/ubuntu/16.04/packages-microsoft-prod.deb
RUN	sudo dpkg -i packages-microsoft-prod.deb && \
	sudo apt-get install apt-transport-https -y && \
	sudo apt-get update && \
	sudo apt-get install dotnet-sdk-2.1.200 -y



	#https://www.microsoft.com/net/download/linux-package-manager/ubuntu16-04/sdk-current
	#https://docs.docker.com/install/linux/docker-ce/ubuntu/#install-docker-ce-1
	#Azure vm docker extension
	#http://francescomolfese.it/en/2017/09/creazione-di-un-ambiente-docker-in-azure-tramite-vm-extension/
#FROM microsoft/dotnet:2.0-sdk AS build
#WORKDIR /src
#COPY DotnetCoreSeleniumTestOnDocker/DotnetCoreSeleniumTestOnDocker.csproj DotnetCoreSeleniumTestOnDocker/
#RUN dotnet restore DotnetCoreSeleniumTestOnDocker/DotnetCoreSeleniumTestOnDocker.csproj
#COPY . .
#WORKDIR /src/DotnetCoreSeleniumTestOnDocker
#RUN dotnet build DotnetCoreSeleniumTestOnDocker.csproj -c Release -o /app
#
#FROM build AS publish
#RUN dotnet publish DotnetCoreSeleniumTestOnDocker.csproj -c Release -o /app
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app .
#ENTRYPOINT ["dotnet", "DotnetCoreSeleniumTestOnDocker.dll"]
#