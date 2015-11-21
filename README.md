This is how you get the mvc sample application to work from aspnet5 home project.
This is using VS 2015 Community which is the free version, which might be the cause of some issues.
when you clone the project it won't just work by default.
download and install VS community 2015 which will also install the new .NET runtime
clone the original project or the one from this repository
https://github.com/aspnet/Home/tree/dev/samples/1.0.0-rc1-final/HelloMvc

1) when you open the project for the first time, it will not compile because it is missing references to DNX
--this is when you have to start finaggling things in the command line. Open command window to the directory of the HelloMvc project. Execute command "dnu restore". Now you will actually be able to build the project

2) when you want to run the project all you have to do is change the drop down to "web" and hit the run button. this will run the new built in web server (not IIS) and open a browser. But this results in some annoying behavior, everytime you make a change you have to restart the project.

3)install dnx watch in order to have a tool that will reset everything automatically for you whenver a file change is made
--type in the command line "dnu commands install Microsoft.Dnx.Watcher" 
--then type "dnx-watch web"
--now whenever you save a code file and refresh the page the change will show up. without this the change would not show up
