# MyFileStorage(MFS)
<img src="AboutProject/UploadDocument-MFS.png" alt="Dashboard">

Simple Windows application for uploading and downloading files

## Description

The **MFS** application allows you to upload and download your files privately or share them with your friends. The main objective of this application is to create a WinForms application that follows clean code practices.


## Getting Started
In this project, the **MVP (Model View Presenter)** pattern is used. This application only relies on a SQL instance database for simplicity. It is better to store files on a file storage service like **AWS S3**, which is better for real-world applications.
### Dependencies

* Visual Studio (Preferrable IDE)
* .Net Framework 4.7.2
* SQL EXPRESS

### Installing

You can register a new user from the login form after you change the datebase settings.

<img src="AboutProject/Registration-MFS.png" alt="Registration">

### Database setup

Edit the **App.config** file and replace the credentials with your database:
```
<connectionStrings>
 <add name="MFSContextConnectionString" connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=MFSDbContext;Integrated Security=True" providerName="System.Data.SqlClient" />
</connectionStrings>
  ```

## License

This project is licensed under the MIT License - see the LICENSE.md file for details

## Links

* [Winforms-MVP](https://github.com/mrts/winforms-mvp)
* [What is Model–view–presenter
](https://en.wikipedia.org/wiki/Model%E2%80%93view%E2%80%93presenter)