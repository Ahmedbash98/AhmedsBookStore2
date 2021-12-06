README for ASP.NET AhmedsBookStore Application

Program name: AhmedsBookStore,
Program purpose: Create an application for Book Store.
Date Modified: 2021-12-06


Dec 5 2021 Start Time 17:40pm

Started A new Application because the old had so many Errrors.

Reviewd the default Contollers, Models, Views folders with HomeController.cs, ErrorViewModel.cs and Home & Shared 
View folders with _ViewImports.cshtml and _ViewStart.cshtml

Made some modification to the startUp.cs file


Examed the rest of the code Run the program to check if it works propely


Update the BootStarp Theme using BootsWatch Used the Minty style


Modified the they shared _layout.cshtml and _loginPartials.cshtml to give a beeter design to the app.


Runed project to review changes.

pushed eveerything to GitHub repository.

Addedd  the additional stylesheets and scripts from the CSS_JStxt file to the _Layout.cshtml page.


add a dropdown to the NavBar

Runed project to review changes.

Add three (3) new projects 
AhmedsBook.DataAccess
AhmedsBook.Models
AhmedsBook.Utility


Copied the Data folder and paste to .DataAccess project and delete the original file.

Installed the  Microsoft.EntityFrameworkCore.Relational,SqlServer and Identity.EntityFrameworkCore.

Made Modifications to the AhmedsBook.Models

 Added a Customers area to Areas and made some modifictions to the app

Add a new Admin area in Areas and made some modifictions to the app

Update the GitHub repo


To prepare for the next part, builded the application and confirm there are no errors, Reviewed appsettings.json, modify the database name and saved it.

Use the NuGet Package Manager Console to  add-migration AddDefaultIdentityMigration, but i get error for does not match migrations.
Change to the correct default project .DataAccess and add run again. now it build succeeded.


Reviewed the AddDefaultIdentityMigration.cs file for the SQL-like syntax, statements, columns and primary key constraints, tables related the ASP.NET Identity.

 update the database now.

 Checked for errors, run the application.
 
 pushed and  commits to GitHub.

Added a new table to the DB by creating a Category model and push it to the DB: Added a new class file to the .Models project and modify it.

add-migration AddCategoryToDb via the PM Console- , 
20211206031902_AddCategoryToDb




Update this and note the added using statement, re-run the add-migration, added that migration again, review the changes to the AddCategoryToDb (resolve the duplication error that will occur).

Update the database, confirm the new Categories table via the SQL SOE and


push commits to GitHub.



After creating the Category.cs and adding it to the ApplicationDbContext it’s time to implement the Repository, a generic way of accessing common functionality, in the .DataAccess project.

Add a new folder name it Repository and add an IRepository folder inside it. Add a new item of type interface to the folder and name it IRepository.cs 

Modify so it can be used on the Category class to do all the CRUD operations by adding using statements.
Methods to use for CRUD: Get item from the DB, List of Categories, Add objects, Remove objects

Implement the class that implements the repository, add Repository.cs class in Repository folder.

Include the using statement, View the potential fixes and implement interface, Modify the code to create the constructors and dependency injection (DI).

Create individual repos for category and all potential models to be added in the future, CategoryRepository.cs
and ICategoryRepository.cs.

Modify CategoryRepository (note the using statements and the message for formal parameters – review in Repository.cs the method pointing to the ApplicationDBContext)

Modify ICategoryRepository interface, Review and modify the error now in CategoryRepository.cs (implement the interface to update), Complete the remaining modifications.

Build, fix any error and push commits to GitHub.

Implement a stored procedure repository and map multiple repositories in a Unit of Work

Add a new interface in the IRepository folder - ISP_Call.cs – that extends IDisposable, Include the methods shown and install the NuGet package for Dapper. Now implement this with a new class in the Repository folder.

Add a new class (SP_Call.cs) in the Repository folder, select the appropriate using statement and implement the ISP_Call interface

Add a connection to the database, note the additional using statements, Update the implementation of the ISP_Call interface, Now add the wrapper for Unit of Work.

Add a new interface (IUnitOfWork) to the IRepository folder and update the code.

Now implement this inside the UnitOfWork, Modify the code (make sure the public class implements the interface -  UnitOfWork : IUnitOfWork)

To make it accessible by the project, register it Startup.cs in the ConfigureServices method, add using statement.

so i just comment out the statement that throw an error and 

pushed commits to GitHub.



Added a new MVC Controller - Empty inside Areas/Admin, Name it CategoryController.cs
Modify the code to use the IUnitOfWork from the .DataAccess project and the IRepository folder by asdding using statement.

Added a new folder in the Areas/View with the same name as the Controller.

Added a new Index view to the folder and modify with the generic HTML coded.

Saved and runed the application

In _Layout.cshtml, move the Category link to the Content Management drop-down. 

Reviewed the changes to the navigation, Push to GitHub.

Modified the Index.cshtml to add the icons in the Category section from Font Awesome and confirm.

Added category.js file

Applied the code to activate the Edit and Delete buttons and Create New Category using the Upsert action

Added the IAction result to the controller and add a View, Copy and add the html from the Category Upsert View.txt

Create a partial view for the EDIT | BACK. 

Modify the Upsert.cshtml, Add the asp-action to the Index.cshtml page and run the application, 


Modified Upsert.cshtml so TITLE now uses the @title variable and refreshed the application. 

 Created an Upsert POST action method in the CategoryController.cs, 
 
Removed the _db.SaveChanges() method in the CategoryRepository.cs and move the _unitOfWork.Save() method with the return RedirectToaction method.



Did the same steps above for the coveType (same as the Category)

Added CoverType to the Repository. 
Added CoverTypeRepository Class. 
Added ICoverTypeRepository Interface.
Add CoverType to UnitOfWork and IUnitofWork.
Push CoverType to the Database. 
Created migration 
20211206050911_AddCoverTypeToDb

Performed CRUD operations on Cover Type.
Added Cover Type to NavBar.
Added CoverType Controller with all required Action Methods.
Cover Type Index View to use DataTables.
Cover Type Upsert View takes care of creating and updating CoverType.
The deleting CoverType is done using the API Call.



Added a new class (Product) in the Models project. 
Add the code to build the blueprint of this class 

Add reference to the new Products piece to the database in the ApplicationDbContext.cs file.
In the PM Console
Added add-migration command for an addProductToDb
20211206064716_AddProductToDb



In the SOE review the newly created Products table.
Updated the Product class so Title, ISBN and Author are Required, 


Created a new migration (addValidationToProduct) and update the database.
20211206065003_AddValidationToProduct


Added Product to the Repository. 
Added IProductRepository Interface.
Added ProductRepository Class.
Added Product to UnitOfWork and IUnitofWork
Build and check for errors, 
Got some erorr solved it 
 pushed Everthing to GitHub.
 
Added the IWebHostEvironment call and its using statement to the Microsoft.AspNetCore.Hosting, .

Created a ViewModel in the Models project to hold the Product object and select list for Category and CoverType. 

Modified the ProductVM class so it is public and

Modified the ProductController so the IActionResult Upsert calls to the ProductVM view model, 
Included the using statements to the ViewModels folder and Microsoft.AspNetCore.Mvc.Rendering.

Commented out the Upsert post method for now, 
Modifid the API call to include the Category and CoverType properites. 
Added an Index view.



 Installed the package Microsoft.AspNetCore.Mvc.ViewFeatures to the app
 
 Added the upsert runed the program had some Errors solved it using BulyBooks repository
 
 End Time 2:45 am  Total Hours  8 hours and 5 Mins.







