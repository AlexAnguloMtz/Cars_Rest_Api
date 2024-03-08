# Cars REST API Documentation

## Overview

This documentation provides details about the REST API for managing cars. The API allows users to perform CRUD operations (Create, Read, Update, Delete) on car resources.

## Base URL:
http://147.182.251.117:8080

## Models

### Car

Represents a Car entity used in responses.

| Field | Type   | Description        |
|-------|--------|--------------------|
| id    | string | Unique identifier for the car. |
| brand | string | Brand of the car.  |
| model | string | Model of the car.  |
| year  | int    | Year of the car.   |

### CarDto

Data transfer object (DTO) representing Car information used in requests.

| Field | Type   | Description        |
|-------|--------|--------------------|
| brand | string | Brand of the car.  |
| model | string | Model of the car.  |
| year  | int    | Year of the car.   |

## Endpoints

### Get All Cars

Retrieve a list of all cars.

- **Endpoint**: `/cars`
- **Method**: `GET`
- **Response**: Returns an array of Car objects.


### Get Car by ID

Retrieve details of a specific car by its ID.

- **Endpoint**: `/cars/:id`
- **Method**: `GET`
- **Parameters**: 
  - `id` (string): ID of the car to retrieve.
- **Response**: 
  - Returns the Car object with the specified ID - 200 OK.
  - Returns 404 NOT FOUND if the car with the specified ID does not exist.


### Create Car

Create a new car using the provided information.

- **Endpoint**: `/cars`
- **Method**: `POST`
- **Request Body**: 
	- CarDto. Data Transfer Object (DTO) representing car information.
- Returns 201 CREATED


### Update Car by ID

Update details of a specific car by its ID.

- **Endpoint**: `/cars/:id`
- **Method**: `PUT`
- **Parameters**: 
  - `id` (string): ID of the car to update.
- **Request Body**: 
  - CarDto: Data Transfer Object (DTO) representing updated car information.
- Returns 200 OK on Success
- Returns 404 If Car with ID does not exist

- 
### Delete Car by ID

Delete a specific car by its ID.

- **URL**: `/cars/:id`
- **Method**: `DELETE`
- **Parameters**: 
  - `id` (string): ID of the car to delete.
- **Response**: 
  - Returns status code 200 OK upon successful deletion.
  - Returns 404 NOT FOUND if the car with the specified ID does not exist.
