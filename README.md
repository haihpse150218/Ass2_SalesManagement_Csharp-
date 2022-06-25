
# Introduction
    Imagine you're an employee of a product retailer named FStore. Your manager
    has asked you to develop a Windows Forms application for member management,
    product management, and order management. The application has a default
    account whose email is “admin@fstore.com” and password is “admin@@” that
    stored in the appsettings.json.
    The application has to support adding, viewing, modifying, and removing
    products—a standardized usage action verbs better known as Create, Read,
    Update, Delete (CRUD) and Search. This assignment explores creating an
    application using Windows Forms with .NET Core, C#, and ADO.NET / Entity
    Framework. The MS SQL Server database will be created to persist the data and
    it will be used for reading and managing data.
# Assignment Objective
    In this assignment, you will:
    2 | P a g e
    ▪ Use the Visual Studio.NET to create Windows Forms and Class Library (.dll)
    projects.
    ▪ Develop MDI (Multiple Document Interface) application using WinForms.
    ▪ Perform CRUD actions using ADO.NET and Entity Framework Core
    ▪ Use LINQ to query and sort data
    ▪ Apply passing data in WinForms application
    ▪ Apply 3-layers architecture to develop an application
    ▪ Apply MPV (Model-Presenter-View) pattern in WinForms application
    ▪ Apply Repository pattern and Singleton pattern in a project
    ▪ Add CRUD and searching actions to WinForms application.
    ▪ Apply to validate data type for all fields
    ▪ Run the project and test the WinForms actions.
    
# Main Functions
    ▪ Member management, Product management, and Order management:
    Read, Create, Update and Delete actions. Creating and Updating actions
    must be performed by popup dialog
    ▪ Search Product by ID , ProductName (by keyword of ProductName),
    UnitPrice, and UnitInStock
    ▪ Create a report statistics sales by the period from StartDate to EndDate, and
    sort sales in descending order
    ▪ Member authentication by Email and Password. If the user is “Admin” then
    allows to perform all actions, otherwise, the normal user is allowed to
    view/create/update the profile and view their orders history.
