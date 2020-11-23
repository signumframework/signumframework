using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Signum.Upgrade.Upgrades
{
    class Upgrade_20201110_DotNet5 : CodeUpgradeBase
    {
        public override string Description => "Upgrade to .Net 5";

        public override string SouthwindCommitHash => "db5736eff63bd240d78f27a6db71ab693c5903f8 5a03b1f37f7aba99013a6d3f9292bd6d631c306b";

        public override void Execute(UpgradeContext uctx)
        {
            uctx.ForeachCodeFile("*.cs", uctx.EntitiesDirectory, file =>
            {
                file.Replace(
                    searchFor: @"protected override void ChildCollectionChanged(object sender, NotifyCollectionChangedEventArgs args)",
                    replaceBy: @"protected override void ChildCollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)");
            });

            uctx.ForeachCodeFile("*.csproj", file =>
            {
                file.Replace(
                    searchFor: @"<TargetFramework>netcoreapp3.1</TargetFramework>",
                    replaceBy: @"<TargetFramework>net5.0</TargetFramework>");

                file.UpdateNugetReference(@"Signum.MSBuildTask", @"5.0.0");
                file.UpdateNugetReference(@"Signum.TSGenerator", @"5.0.0");
                file.UpdateNugetReference(@"Swashbuckle.AspNetCore", @"5.6.3");
                file.UpdateNugetReference(@"Microsoft.Extensions.Configuration", @"5.0.0");
                file.UpdateNugetReference(@"Microsoft.Extensions.Configuration.Binder", @"5.0.0");
                file.UpdateNugetReference(@"Microsoft.Extensions.Configuration.Json", @"5.0.0");
                file.UpdateNugetReference(@"Microsoft.Extensions.Configuration.UserSecrets", @"5.0.0");
                file.UpdateNugetReference(@"Microsoft.NET.Test.Sdk", @"16.8.0");
            });

            uctx.ChangeCodeFile($@"Southwind.React\Startup.cs", file =>
            {
                file.Replace("AddNewtonsoftJson", "AddJsonOptions");
                file.Replace(
                    "public bool Match(HttpContext httpContext, IRouter route, ", 
                    "public bool Match(HttpContext? httpContext, IRouter? route, ");
            });

            uctx.ChangeCodeFile($@"Southwind.React/package.json", file =>
            {
                file.UpgradeNpmPackage("@types/react", "file:../Framework/Signum.React/node_modules/@types/react");
                file.UpgradeNpmPackage("node-sass", "5.0.0");
                file.UpgradeNpmPackage("sass-loader", "10.1.0");
            });

            uctx.ChangeCodeFile($@"Southwind.React/Dockerfile", file =>
            {
                file.ReplaceLine(
                    a=>a.Contains("FROM mcr.microsoft.com/dotnet/core/aspnet"), 
                    "FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base");
                file.ReplaceLine(
                    a => a.Contains("FROM mcr.microsoft.com/dotnet/core/sdk"),
                    "FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build");

                file.ReplaceBetween(
                    a => a.Contains("RUN apt-get -y install curl"),
                    a => a.Contains("RUN apt-get -y install nodejs"),
@"RUN apt-get -y install curl
RUN curl -sL https://deb.nodesource.com/setup_15.x | bash -
RUN apt-get install -y nodejs");
            });
        }
    }
}
