# _ICE Breaker | Track, Report, & Alert Raid Sightings_

#### _Multilingual application for tracking, reporting, and alerting users about ICE raids in their local neighborhoods._

#### Developers: _**Kelli McCloskey, Nikki Boyd, Ryan Putman, Devin Mounts & Renee Sarley**_

## Description

_Our multilingual application allows users to report details about ICE raids in their neighborhoods. Notifications via text message will be delivered to all users; including the raid description and address. Refresh the page to receive live updates on our interactive, user-populated web map that illustrates all reported ICE sightings across the nation. Simply click on the points to learn more about each reporting's specific details. The ticker on the right side of the homepage provides live updates for the most 10 recent reported raid sightings._<br>

## Setup/Installation Requirements

* _1. Clone the master branch of "ICE-tracker" from this repository: https://github.com/nikkiboyd/ICE-tracker_
* _2. Ensure .NET Core 1.1 is installed on your machine._
* _3. Ensure Mono is installed on your machine._
* _4. Run the command `dotnet restore` to refresh packages._
* _5. Tests can be found in the folder "ICE-tracker.Tests" folder._
* _6. Run server and import the `ice_tracker.sql` database into phpMyAdmin._

## User Stories - MVP

_Report an ICE raid which will include the location, date, time and a description of the raid_<br>
_See all the reported ICE raids on a map_<br>
_Click on a raid on the map and see the details of the raid_<br>
_Receive a text message each time an ICE raid is reported_

## User Stories - Additional features for future implementation

_Filter the results on the map to view all raids that have occurred within a specified timeframe_<br>
_Select which zipcodes they would like to receive alerts for_<br>

## Known Bugs

_There are no known bugs at this time._

## Support and contact details

_Please email Nikki Boyd at boyd.nikki@icloud.com with any questions._

## Technologies Used

* _C#_
* _JavaScript_
* _phpMyAdmin_
* _mySql_
* _Twilio Web API_
* _Google Maps API_
* _Google Geocoder API_
* _Google Translator API_

### License

*This software is licensed under the MIT license.*

Copyright (c) 2018 **_Kelli McCloskey, Nikki Boyd, Ryan Putman, Devin Mounts & Renee Sarley_**
