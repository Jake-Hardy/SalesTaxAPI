# NC Sales Tax Calculator API

This API exposes a single `GET` endpoint which accepts query string arguments (a county name and a transaction price) and returns a `JSON` object.

## Running and Using the application

Docker is the easiest way to stand up the API and associated database.

- After cloning the application, simply running `docker-compose up --build` will build and run the API, as well as start the database and seed it with data.

- The following cURL request can be used to test the API:

`curl -X GET "http://localhost:5000/api/v1/nc/salesTax?County=new%20hanover&Price=10.00" -H  "accept: application/json"`

- Swagger docs are available at http://localhost:5000/swagger/index.html, and can also be used to test the API.

- The root directory of the application holds a second project containing unit tests. Those can be run from the root directory with the command `dotnet test`.