﻿// <copyright file="AdrCli.cs" company="Endjin Limited">
// Copyright (c) Endjin Limited. All rights reserved.
// </copyright>

namespace Endjin.Adr.Cli
{
    using System.CommandLine.Builder;
    using System.CommandLine.Invocation;
    using System.Threading.Tasks;
    using Endjin.Adr.Cli.Commands;
    using Endjin.Adr.Cli.Contracts;
    using Endjin.Adr.Cli.Extensions;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// A CLI tool for creating and manading Architectural Decision Records.
    /// </summary>
    public static class AdrCli
    {
        /// <summary>
        /// Main entry point into the application.
        /// </summary>
        /// <param name="args">Command Line Switches.</param>
        /// <returns>Exit Code.</returns>
        public static async Task<int> Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.ConfigureDependencies();

            ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

            var appEnvironmentManager = serviceProvider.GetRequiredService<IAppEnvironmentManager>();

            await appEnvironmentManager.SetDesiredStateAsync().ConfigureAwait(false);

            var cmd = new CommandLineBuilder()
                .AddCommand(new InitialiseAdrRepositoryCommandHandler().Create())
                .AddCommand(new ListCommandHandler().Create())
                .UseDefaults()
                .Build();

            return await cmd.InvokeAsync(args).ConfigureAwait(false);
        }
    }
}