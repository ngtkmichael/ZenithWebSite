•	First Name		: Thow Kwon Michael
•	Last Name		: Ng Tat Mew
•	Student number	: A01003377
•	Email address	: ng.tkmichael@yahoo.ca

•	What you have and what you have not completed ?
==========================
Task #1 – ASP.NET Core 1.0
==========================
1. Create ZenithSociety solution

2. Create ZenithWebSite project - using ASP.NET Core Web Application(.NET Core)

3. Create folder ZenithWebSite.Docs
3.1 Add the text files Migrations.txt & Readme.txt in ZenithWebSite.Docs

4. Create folder ZenithWebSite.Models.Zenith
4.1 Create classes Activity.cs & Event.cs
4.2 Create validation class, BeforeEndDateAttribute, for Start & End Dates of event.

5. Modify class ZenithWebSite.Data.ApplicationDbContext
5.1 Add properties Activities & Events to access data from tables.

6. Open the appsettings.json file
6.1 Add the following section after the Logging block:
"Data": {
    "DefaultConnection": {
      "ConnectionString": "Data Source=(localdb)\\mssqllocaldb;Database=ZenithSociety.mdf;Trusted_Connection=True;MultipleActiveResultSets=true"
    }
  }

7. Open the Startup.cs file.
7.1 Add the following code to the ConfigureServices() method just before services.AddMvc();
   var connection = Configuration["Data:DefaultConnection:ConnectionString"];
   services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connection));

8. Create class ZenithWebSite.Models.Zenith.DummyData
8.1 Insert dummy data in Activity & Event tables.

9. Modify the class  Startup.cs:
9.1 Inject the dependency "ApplicationDbContext context" into the arguments of the Configure() method:
public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, ApplicationDbContext context)

9.2 Add the following statement to make a call to seed the data at the bottom of the Configure() method:
DummyData.Initialize(context);

10. Modify file 00000000000000_CreateIdentitySchema.cs
10.1 Add the following fields to the creation of the table AspNetUsers:
FirstName = table.Column<string>(maxLength: 256, nullable: true),
LastName = table.Column<string>(maxLength: 256, nullable: true)

10.2 Create Activities table.
10.3 Create Events table.
10.4 Drop table Events.
10.5 Drop table Activities.

11. Modify file ApplicationDbContextModelSnapshot.cs 
11.1 Add the following properties to AspNetUsers table: 
b.Property<string>("FirstName")
    .HasAnnotation("MaxLength", 256);

b.Property<string>("LastName")
    .HasAnnotation("MaxLength", 256);

11.2 Add Activity Entity
11.3 Add Event Entity
11.4 Add FK ActivityId in Events table

12. Migrations
12.1 Compile your application
12.2 Open a command terminal inside the src\ZenithWebSite folder & execute the following command:
dotnet ef database update

13. Modify HomeController & Views:
13.1 To display current week's events.
13.2 So that the About & Contact web pages display proper information related to Zenith Society.

14. Add controllers (EF scaffolding):
14.1 ZenithWebSite.Controllers.ActivitiesController
14.2 ZenithWebSite.Controllers.EventsController

15. Editing the following views:
15.1 Activities.Create
15.2 Activities.Delete
15.3 Activities.Details
15.4 Activities.Edit
15.5 Activities.index
15.6 Events.Create
15.7 Events.Delete
15.8 Events.Details
15.9 Events.Edit
15.10 Events.index

16. Modifications so that the user to provide the following fields while registering:
- First Name
- Last Name
- Username
- Email
- Password
16.1 Modify the following classes & view:
AccountController.cs
RegisterViewModel.cs
LoginViewModel.cs
ApplicationUser.cs
Register.cshtml
Login.cshtml

16.2 Register the following users:
Username	Email				Password		Security Role	First Name	Last Name
a			a@a.a				P@$$w0rd		Admin			Jon			Snow
m			m@m.m				P@$$w0rd		Member			Arya		Stark
jdoe		doe1@Zenith.org		doe1@Zenith		Admin			John 		Doe
clannister	clan@Zenith.org		clan1@Zenith	Member			Cersei 		Lannister
dtargaryen	dtar@Zenith.org		dtar1@Zenith	Member			Daenerys	Targaryen
tlannister	tlan@Zenith.org		tlan1@Zenith	Member			Tyrion		Lannister
btarth		btar@Zenith.org		btar1@Zenith	Member			Brienne		of Tarth

16.3 Add 2 following Roles in the AspNetRoles table:
- Admin
- Member

16.4 Add the users' roles in the AspNetUserRoles table as per the list in 16.2

17.  Modify Views.Shared._Layout so as only when user log in as Admin, has access to the Activity & Event menues.



==============================
Task #2 – manage users & roles
==============================
1. Modify Register method in AccountController to assign the "Member" role as default to the registering user.

2. Admin to add/delete roles.
2.1 Add the following:
- Controller --> RoleController
- Views --> Index, Create & Delete in Views.Role

3. Admin to add/delete users from a role
3.1 Add the following:
- In RegisterViewModel.cs add Name property.
- In the AccountController, create 2 ActionResult methods RegisterRole(HttpGet & HttpPost)
to add user to a new role.
- Create the view RegisterRole.cshtml to assign a role to user.
- Add a link in Views.Role.Index to the RegisterRole view.

***************************************
***			NOT COMPLETED			***
***************************************
- Add/delete users from a role.
Tried different methods but in vain :-(
***************************************



==============================================
Task #3 - Create Web API services for all data
==============================================
1. Add Web API controllers:
- ActivitiesapiController
- EventsapiController
- AccountapiController
- CurrentWeekEventsapi



===================================================
Task #4 - Angular-ize some parts of the application
===================================================
1. Create an Angular project named ..\ZenithSociety\ZenithClientSite
ng new ZenithClientSite

2. Have the page to display current week Events(from a static arrays list of Activities & Events)
- app.component.ts
- app.component.html

***************************************
***			NOT COMPLETED			***
***************************************
1. Load the data consuming the Web API services.
2. Authentification.
3. Function to navigate for previous & next weeks of events.  
***************************************

==========================================
 Deploy ZenithWebSite to Azure via GitHub.
==========================================
URL of assignment on Azure:
http://zenithsocietyntmbcit.azurewebsites.net


•	Any major challenges
- 

