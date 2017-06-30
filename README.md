# OverwatchHeroes

Languages Used: C#, HTML, CSS , Javascript

Frameworks: ASP.NET MVC, ASP.NET Razor, Materialize 

The website was developed in Visual Studio 2017, using the ASP.NET MVC Framework. ASP.NET Razor was used for the back end, whereas, the Materialize Framework was used for the front end. 

The models for this project included heroes, and their respective information and a repository which these heroes were stored in. The views for this project included the Index page as well as the Details page for a selected hero. The controllers for this project included the home controller as well as a controller for 404 errors. 

When a hero is chosen on the home page , the hero's name is passed to an action method which pulls the respective hero from the repository. The hero is then passed to the view which dynamically generates the details page for the hero. 

The web application also features filters which allow specific hero types to be highlighted on the home page. The solution took advantage of ids within HTML and Javascript to update the home page. 

Lastly, the web application was deployed and published through Microsoft Azure. Github was used for version control. 
