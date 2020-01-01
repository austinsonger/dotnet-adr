﻿// <copyright file="TemplatesDefaultSetCommand.cs" company="Endjin Limited">
// Copyright (c) Endjin Limited. All rights reserved.
// </copyright>

namespace Endjin.Adr.Cli.Commands
{
    using System;
    using System.CommandLine;
    using System.CommandLine.Invocation;
    using Endjin.Adr.Cli.Configuration;
    using Endjin.Adr.Cli.Contracts;

    public class TemplatesDefaultSetCommand
    {
        private readonly ITemplateSettingsMananger templateSettingsMananger;

        public TemplatesDefaultSetCommand(ITemplateSettingsMananger templateSettingsMananger)
        {
            this.templateSettingsMananger = templateSettingsMananger;
        }

        public Command Create()
        {
            var cmd = new Command("set", "Sets the default ADR Template.")
            {
                Handler = CommandHandler.Create((string templateId) =>
                {
                    if (!string.IsNullOrEmpty(templateId))
                    {
                        var templateSettings = this.templateSettingsMananger.LoadSettings(nameof(TemplateSettings));
                        var template = templateSettings.MetaData.Details.Find(x => x.Id == templateId);

                        templateSettings.DefaultTemplate = template.FullPath;

                        this.templateSettingsMananger.SaveSettings(templateSettings, nameof(TemplateSettings));

                        Console.WriteLine($"Setting \"{template.Title}\" as the default ADR template.");
                    }
                }),
            };

            cmd.AddArgument(new Argument<string>("templateId"));

            return cmd;
        }
    }
}