# EthosInc
This is the repository we will use for our COP 3855 final project.

**How to Build:**
<ol>
  <li>Login to GitHub through Visual Studio and clone the master repository</li>
  <li>From the "Solution Explorer" menu on the right, click on EthosInc.sln</li>
  <li>Open the NuGet Package Manager console by going to Tools -> NuGet Package Manager -> Package Manager Console</li>
  <li> (Optional) If you have problems with SQL, rebuild the database by typing in "Add-Migration Initial", and then "Update-Database" after the previous command finishes</li>
  <li> (Optional) If your project won't run at all because of a NuGet error, try going into the console and typing in "dotnet restore"</li>
</ol>

**Admin Panel Instructions:**
To access the admin panel, which allows administratiors to add, delete, and modify items in the database, follow these steps:
<ol>
  <li>Run the EthosInc project</li>
  <li>Navigate to https://www.localhost:#####/Admin/Index</li>
  <li>Enter the username: Admin,email: admin@admin.com, and password: Admin1!.
</ol>
