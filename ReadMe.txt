GpsGeolocator0.1 Test Cases
Overview
This repository contains NUnit test cases for the GpsGeolocator0.1 Xamarin.Forms application. These test cases use Moq for mocking the IGeolocationService interface, allowing you to test the GetLocation method.

Prerequisites
Visual Studio comunity 
NUnit and Moq NuGet packages installed

Running the Tests
Open the solution in Visual Studio community.
Build the solution to restore dependencies.
Open the Test Explorer in Visual Studio community.
Run all tests.

Test Cases
GetLocation_WithLastKnownLocation_ReturnsExpectedResult
This test case checks if the GetLocation method correctly displays the latitude and longitude when there is a last known location available.

Test Steps:
Arrange:

Mock the IGeolocationService.
Create an instance of the MainPage class with the mocked service.
Set up the mock to return a known last known location.
Action:

Invoke the GetLocation method on the MainPage instance.
Assert:

Verify that the displayed text in txtLoc matches the expected result based on the known last known location.
GetLocation_WithoutLastKnownLocation_ReturnsExpectedResult
This test case checks if the GetLocation method correctly displays the latitude and longitude when there is no last known location available.

Test Steps:
Arrange:

Mock the IGeolocationService.
Create an instance of the MainPage class with the mocked service.
Set up the mock to return null for the last known location.
Set up the mock to return a known location when GetLocationAsync is called.
Action:

Invoke the GetLocation method on the MainPage instance.
Assert:

Verify that the displayed text in txtLoc matches the expected result based on the known location returned by GetLocationAsync.