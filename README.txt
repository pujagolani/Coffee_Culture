2022-10-10 10:27

created by: Puja Golani
Part-1
purpose: Create a ASP.NET Core Web App for the project
-using .NET Core 3.1
-individual user account authentication

first name of project is Coffee_Culture.

change index.cshtml welcome to coffee world!!.

add readme text file..

log in into my github account and make private to public.
rebuild application.

run the application, update readme file,

commit all and push to github..

for the change and try i change css file and change background color of body and footer.

test application and success.

again commit and push to github.

2022-10-13 12:34

deciding fields for the project. 
12:50Am
changed and update the vesion of nugetpackages.

confirm the all properties of the project

add new file named CoffeBean.cs in models folder.

01:13Am
make new file in named CoffeBeanContext.cs in Data folder.

update that file and add namespaces.

update the startup.cs and add code in startup.configureservices.

review the appsettings.json file.

rebuild the application and commit to github.

push to github, commit all

1:49am

2022-10-13 8:21

start building scafolding and i get error in building because i used wrong name in context file.

after getting error i rename CoffeBeanContext to Coffe_cultureContext.
commit to github.

error solved and rebuild again.

again did scafolding and it is done.

starting next step 8:40
commit to github

try to do migration but i get naming error in console than add -Context ApplicationDbContext
it run.

commit to git hub

test project success.
change controller in layout.cshtml file to create link on Coffee_culture.
change name in Coffee_culture.cs

10:30 started find data for the seed data file, done with the database at 11:27.
now save, commit and run, lets see what happen!!
get an error
A database operation failed while processing the request.
SqlException: Invalid object name 'CoffeeBean'.
there is naming error , i checked in sql database server and rename it.
lets test it....... changed the program.cs file
tested it and done it runs.
tested sucessfully. done with the part-5
commit to github
12:01 am
starting part6
Added namespaces in model/Coffeebean.cs
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
Add new validations above datetime and above price field.
part 6 completed.
started Part7
Add search
update the index method inside coffeecontrollers.
to add search string i set on types of coffee search.
tested run sucessfully.
Added search by roasting with adding class into model folder.
getting errors in coffeeroastingvm.cs
solved the errors (naming and variable declare are different that why i confused).
commit to github and tested.
sucessfully run.
next update index.cshtml to search by roasting to the index view.
commit to github.
part-7 done run sucessfully run with drop down list of roasting.
commit to github