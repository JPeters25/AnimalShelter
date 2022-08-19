# Animal Shelter API

#### Week 13 Independent Code Review Creating API

#### By Justin peters

## Technologies Used

* _C#_
* _CSHTML_
* _CSS_
* _Entity Framework_
* _SQL Database_
* _dotnet_
* _Markdown_

## Description

_You've completed a few projects at the dev agency where you work and you've been given more autonomy to choose which project you'd like to work on next. The agency currently has three new back-end contracts to build APIs for their clients. Since this is the first time you've been given free rein on a project, take this opportunity to showcase your versatility for the project manager._

## Disclaimers -- IMPORTANT

_This API was not developed by a licensed animal shelter. The dogs are fictional and not actually in a shelter_

## Link to Git Hub Repository
* _API:_ https://github.com/JPeters25/AnimalShelter.git
* _Client:_ https://github.com/JPeters25/AnimalShelterClient.git

###  Naming Conventions

* _Production Database:_ animal_shelter
* _Main Project Folder:_ AnimalShelter.solution

## Setup/Installation Requirements

* _Clone or download repository to your local._
* _Cd into AnimalShelter and run dotnet restore, dotnet build to confirm the project has no errors._
* _Touch appsettings.json and add the following configuration:_

<pre>{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[animal_shelter];uid=root;pwd=[password];"
  }
}</pre>

* _Run dotnet ef migrations add Initial and dotnet ef database update to build database._
* _Then use dotnet watch run to run web application._

_NOTE:_ [password] should be replaced by your password. Do not include square brackets in final configuration.

## Known Bugs

* _No known bugs in API._

## License

* MIT

## Contact Information

_Please contact us with any questions or contribuitions, jmarvel525@gmail.com

Copyright(c) August 2022 Justin Peters