# Narrativia

A blog written in ASP.NET Core and Angular

## Note

This repo is not related to 
[Narrativia](http://www.narrativia.com/) (the production company set up by the lat Sir Terry Pratchett) in anyway; except as a reference to a character in the Discworld series of novels.

psst, this one => https://wiki.lspace.org/mediawiki/Narrativia_(goddess)

## Licence Used

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

See the contents of the LICENSE file for details

## Support This Project

If you have found this project helpful, either as a library that you use or as a learning tool, please consider buying me a coffee:

<a href="https://www.buymeacoffee.com/dotnetcoreshow" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important" ></a>

## Pull Requests

[![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat-square)](http://makeapullrequest.com)

Pull requests are welcome, but please take a moment to read the Code of Conduct before submitting them or commenting on any work in this repo.

## Code of Conduct

Narrativia has a Code of Conduct which all contributors, maintainers and forkers must adhere to. When contributing, maintaining, forking or in any other way changing the code presented in this repository, all users must agree to this Code of Conduct.

See [Code of Conduct.md](Code-of-Conduct.md) for details.

## Requirements

Narrativia requires the following software to be installed on the dev machine in order to build it:

 - [.NET Core SDK 2.0+](dot.net/core)
 - [NodeJs LTS](https://nodejs.org/en/)

## Running The Application

1. Ensure that the `appsettings.json` file contains a valid `ConnectionStrings` section.

You will need two connection strings:

* narrativiaDataConnection

This is the database which will contain all of the blog posts, comments and meta data

Example ConnectionStrings section:

    "ConnectionStrings": {
      "narrativiaDataConnection": "DataSource=narrativiaData.db"
    },

2. Open a command prompt in the `Narrativia.Ui` directory

Issue the following commands to set up the databases:

    dotnet restore

Check for migrations in the `Narrativia.Repository.Data` directory. If there isn't a directory labelled `Migrations`, then run the following (from the `Narrativia.Ui`) directory to generate them:

    dotnet ef migrations add InitialMigration -c DataContext -p ../Narrativia.Repository/Narrativia.Repository.csproj -s Narrativia.Ui.csproj

Apply all migrations to the database by running the following commands (from the `Narrativia.Ui` directory):

    dotnet ef database update -c DataContext -p ../Narrativia.Repository/Narrativia.Repository.csproj -s Narrativia.Ui.csproj

3. Restore all npm packages

Issue the following command from the `Narrativia.Ui` directory:

    npm install

4. Run the application and seed the database

Issue the following command from the `Narrativia.Ui` directory:

    dotnet run
