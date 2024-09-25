# CarServiceAutorola

## Features

- Add a new car
- Get all cars or by VIN
- Update car information
- Delete a car by VIN

## Prerequisites

Before you begin, ensure you have met the following requirements:

- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)



### Clone the repository
git clone https://github.com/Laszlo199/CarServiceAutorola.git

## Navigate to the Project Directory
    cd CarServiceAutorola/WebApi

### Restore Dependencies
    dotnet restore

### Run the Application
    dotnet run

# If you want to use Docker:

### Navigate to the Project Directory
    cd CarServiceAutorola

### Run the Application
    docke-compose up --build


## Additional Information:
- Its possible to use with docker or with swagger and postman.
- With swagger lisening on: http://localhost:9090/swagger/index.html
- The project will be available at http://localhost:9090 by default.

## API Endpoints

- **Get all cars**
  - `GET /api/car`
- **Get a car by VIN**
  - `GET /api/car/{vin}`
- **Add a new car**
  - `POST /api/car`
- **Update a car**
  - `PUT /api/car`
- **Delete a car**
  - `DELETE /api/car/{vin}`