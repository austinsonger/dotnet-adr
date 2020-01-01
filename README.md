# Endjin.Adr
A .NET Global Tool for adopting and using Architectural Decision Records (ADR).

See https://github.com/joelparkerhenderson/architecture_decision_record for a comprehensive overview of ADR.

## dotnet global tools

`adr` is a .NET global tool. 

To list all the global tools installed on your machine, open a command prompt and type:

`dotnet tool list -g`

To install the `adr` global tool use the following command:

`dotnet tool install -g adr`

To install a specific version, use:

`dotnet tool install -g adr --version <version-number>`

To update to the latest version of the tool, use:

`dotnet tool update -g adr`

To uninstall the tool, use:

`dotnet tool uninstall -g adr`

## dotnet suggest

`adr` supports [dotnet suggest](https://github.com/dotnet/command-line-api/wiki/dotnet-suggest), for tab based auto completion.

To install dotnet suggest:

`dotnet tool install -g dotnet-suggest`

Next check if you have a PowerShell profile configured, by opening a PowerShell prompt and typing the following:

`echo $profile`

You should see something like:

`$ENV:USERPROFILE\Documents\PowerShell\Microsoft.PowerShell_profile.ps1`

If you don't see such a file run the following command:

`Invoke-WebRequest -Uri https://raw.githubusercontent.com/dotnet/command-line-api/master/src/System.CommandLine.Suggest/dotnet-suggest-shim.ps1 -OutFile $profile`

Otherwise, copy the contents of the file above and paste it into your pre-existing profile.

## ADR Commands

`adr init <PATH>`

`adr new <TITLE>`

`adr new -s <RECORD NUMBER> <TITLE>`

`adr templates`

`adr templates default show`

`adr templates default set <TEMPLATE ID>`

`adr templates install <VERSION>`

`adr templates list`

`adr templates update`

## System Details

An application profile folder is created in:

`%%UserProfile%%\AppData\Roaming\endjin\dotnet-adr`

Templates are stored in:

`templates\`

Configuration in:

`configuration\`

The templates NuGet package is cached in `%%UserProfile%%\.nuget\packages`. 

## Licenses

[![GitHub license](https://img.shields.io/badge/License-Apache%202-blue.svg)](https://raw.githubusercontent.com/endjin/Endjin.Adr/master/LICENSE)

This project is available under the Apache 2.0 open source license.

For any licensing questions, please email [&#108;&#105;&#99;&#101;&#110;&#115;&#105;&#110;&#103;&#64;&#101;&#110;&#100;&#106;&#105;&#110;&#46;&#99;&#111;&#109;](&#109;&#97;&#105;&#108;&#116;&#111;&#58;&#108;&#105;&#99;&#101;&#110;&#115;&#105;&#110;&#103;&#64;&#101;&#110;&#100;&#106;&#105;&#110;&#46;&#99;&#111;&#109;)

## Project Sponsor

This project is sponsored by [endjin](https://endjin.com), a UK based Microsoft Gold Partner for Cloud Platform, Data Platform, Data Analytics, DevOps, a Power BI Partner, and .NET Foundation Corporate Sponsor.

We help small teams achieve big things.

For more information about our products and services, or for commercial support of this project, please [contact us](https://endjin.com/contact-us). 

We produce two free weekly newsletters; [Azure Weekly](https://azureweekly.info) for all things about the Microsoft Azure Platform, and [Power BI Weekly](https://powerbiweekly.info).

Keep up with everything that's going on at endjin via our [blog](https://blogs.endjin.com/), follow us on [Twitter](https://twitter.com/endjin), or [LinkedIn](https://www.linkedin.com/company/1671851/).

Our other Open Source projects can be found on [GitHub](https://endjin.com/open-source)

## Acknowledgements

- [Joel Parker Henderson](https://github.com/joelparkerhenderson) for [collating the various ADR templates](https://github.com/joelparkerhenderson/architecture_decision_record) we make use of.
- [David Glick](https://daveaglick.com/) for his incredibly [useful blog series](https://daveaglick.com/posts/exploring-the-nuget-v3-libraries-part-1) on the NuGet v3 SDK API.
- [Martin Björkström](https://twitter.com/mholo65) for his [excellent gist](https://gist.github.com/mholo65/ad5776c36559410f45d5dcd0181a5c64) that does the heavy lifting of downloading and extracting NuGet packages.

## Code of conduct

This project has adopted a code of conduct adapted from the [Contributor Covenant](http://contributor-covenant.org/) to clarify expected behavior in our community. This code of conduct has been [adopted by many other projects](http://contributor-covenant.org/adopters/). For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [&#104;&#101;&#108;&#108;&#111;&#064;&#101;&#110;&#100;&#106;&#105;&#110;&#046;&#099;&#111;&#109;](&#109;&#097;&#105;&#108;&#116;&#111;:&#104;&#101;&#108;&#108;&#111;&#064;&#101;&#110;&#100;&#106;&#105;&#110;&#046;&#099;&#111;&#109;) with any additional questions or comments.

## IP Maturity Matrix (IMM)

The IMM is endjin's IP quality framework.

[![Shared Engineering Standards](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/74e29f9b-6dca-4161-8fdd-b468a1eb185d?nocache=true)](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/74e29f9b-6dca-4161-8fdd-b468a1eb185d?cache=false)

[![Coding Standards](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/f6f6490f-9493-4dc3-a674-15584fa951d8?cache=false)](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/f6f6490f-9493-4dc3-a674-15584fa951d8?cache=false)

[![Executable Specifications](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/bb49fb94-6ab5-40c3-a6da-dfd2e9bc4b00?cache=false)](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/bb49fb94-6ab5-40c3-a6da-dfd2e9bc4b00?cache=false)

[![Code Coverage](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/0449cadc-0078-4094-b019-520d75cc6cbb?cache=false)](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/0449cadc-0078-4094-b019-520d75cc6cbb?cache=false)

[![Benchmarks](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/64ed80dc-d354-45a9-9a56-c32437306afa?cache=false)](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/64ed80dc-d354-45a9-9a56-c32437306afa?cache=false)

[![Reference Documentation](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/2a7fc206-d578-41b0-85f6-a28b6b0fec5f?cache=false)](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/2a7fc206-d578-41b0-85f6-a28b6b0fec5f?cache=false)

[![Design & Implementation Documentation](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/f026d5a2-ce1a-4e04-af15-5a35792b164b?cache=false)](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/f026d5a2-ce1a-4e04-af15-5a35792b164b?cache=false)

[![How-to Documentation](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/145f2e3d-bb05-4ced-989b-7fb218fc6705?cache=false)](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/145f2e3d-bb05-4ced-989b-7fb218fc6705?cache=false)

[![Date of Last IP Review](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/da4ed776-0365-4d8a-a297-c4e91a14d646?cache=false)](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/da4ed776-0365-4d8a-a297-c4e91a14d646?cache=false)

[![Framework Version](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/6c0402b3-f0e3-4bd7-83fe-04bb6dca7924?cache=false)](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/6c0402b3-f0e3-4bd7-83fe-04bb6dca7924?cache=false)

[![Associated Work Items](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/79b8ff50-7378-4f29-b07c-bcd80746bfd4?cache=false)](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/79b8ff50-7378-4f29-b07c-bcd80746bfd4?cache=false)

[![Source Code Availability](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/30e1b40b-b27d-4631-b38d-3172426593ca?cache=false)](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/30e1b40b-b27d-4631-b38d-3172426593ca?cache=false)

[![License](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/d96b5bdc-62c7-47b6-bcc4-de31127c08b7?cache=false)](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/d96b5bdc-62c7-47b6-bcc4-de31127c08b7?cache=false)

[![Production Use](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/87ee2c3e-b17a-4939-b969-2c9c034d05d7?cache=false)](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/87ee2c3e-b17a-4939-b969-2c9c034d05d7?cache=false)

[![Insights](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/71a02488-2dc9-4d25-94fa-8c2346169f8b?cache=false)](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/71a02488-2dc9-4d25-94fa-8c2346169f8b?cache=false)

[![Packaging](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/547fd9f5-9caf-449f-82d9-4fba9e7ce13a?cache=false)](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/547fd9f5-9caf-449f-82d9-4fba9e7ce13a?cache=false)

[![Deployment](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/edea4593-d2dd-485b-bc1b-aaaf18f098f9?cache=false)](https://endimmfuncdev.azurewebsites.net/api/imm/github/endjin/Endjin.Adr/rule/edea4593-d2dd-485b-bc1b-aaaf18f098f9?cache=false)