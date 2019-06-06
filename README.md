# appforum2019xamarin
After my presentation at AppForum 2019 Warsaw, Poland several I promised I would provide the codebase for the app in a public repo.

This app is very simple in nature but demonstrates a number of basic principles:

* Simple UI manipulation using XAML and event handlers
* Text to Speech and Sharing dialog using Xamarin Essentials
* App Center Data pulling data from Azure Cosmos DB to display in the app using just a few lines of code

Note: you will need to add your own app secrets in the App.xaml.cs and pre-populate your Cosmos DB instance in order to fully run the app.  The readonly public collection created by App Center requires a simple json document structure as follows:

```
{
    "document": {
        "Name" : "Richard Hopkins",
        "Email" : "richard.hopkins@somewhere.com"
    },
    "id": "<add a document-id-here>",
    "PartitionKey": "readonly"
}
```

It is recommended that more complex apps should be architected with an MVVM pattern, but for speed of implementation during the session, all code sits in the MainPage.xaml.cs code behind file.

