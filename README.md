# SuperDuperAPI

Practice dot net API

## Getting Started

First download dependencies

```
dotnet restore
```

Then run it:

```
dotnet run
```

Once running, open up a browser and go to https://localhost:5001/swagger/index.html

From this swagger page, you can trigger any one of the API endpoints to test them out. The api endpoints that are showing up here are found in your Controllers/ folder.

### First Task

1. In the StringsController/ Add an endpoint that takes in a string and returns that same string in all caps.  
   a. The endpoint should be HTTPGET, accept a query string parameter for "lowerCase" and have the route /allcaps.

So when I call it, it should look like:

https://localhost:5001/strings/allcaps?lowerCase=bonanza

### Second Task

1. In the StringsController, Add an endpoint to add two strings together. If I pass in a flag, the strings should be seperated by a space. If no flag passed in, default to false and just add the strings together.

   a. The endpoint should be HTTPPOST, accept a body with an object that contains: string1, string2, includeSpace. The route should be /addStrings.  It should return just a string.
