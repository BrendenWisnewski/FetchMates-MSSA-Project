# FetchMates-MSSA-Project
This is my project for MSSA, FetchMates, a dog park scheduling app

### Navigation

1. [Concept](https://github.com/BrendenWisnewski/FetchMates-MSSA-Project/blob/main/README.md#concept)
2. [Wireframe Sketches](https://github.com/BrendenWisnewski/FetchMates-MSSA-Project/blob/main/README.md#wireframe-sketches)
3. [System Requirements](https://github.com/BrendenWisnewski/FetchMates-MSSA-Project/blob/main/README.md#system-requirements)
4. [Test Procedures](https://github.com/BrendenWisnewski/FetchMates-MSSA-Project/blob/main/README.md#testing)
5. [Prototype](https://github.com/BrendenWisnewski/FetchMates-MSSA-Project/blob/main/README.md#prototype)


## Concept
I am a dog father of two dogs, dog lover, and a dog park enthusiast. I love going to the dog park but hate going to an empty dog park. This app would allow you to schedule dog park times and give you an idea of how many other dogs will be at the park near you (San Diego Focused). Also, it will allow you to create a profile for your dog and connect with other dogs that have a similar personality to your dog. The goal is to connect with other dog owners and be an informed dog park goer. 

[To Top](https://github.com/BrendenWisnewski/FetchMates-MSSA-Project/blob/main/README.md#fetchmates-mssa-project)

## Wireframe Sketches

### Start Page
![initial page](https://github.com/BrendenWisnewski/FetchMates-MSSA-Project/blob/main/Images/Wireframes/InitialPage.jpg)

### Create a Profile
![create profile](https://github.com/BrendenWisnewski/FetchMates-MSSA-Project/blob/main/Images/Wireframes/CreateProfile.jpg)

### Gather more Profile Information
![extra info](https://github.com/BrendenWisnewski/FetchMates-MSSA-Project/blob/main/Images/Wireframes/Extra%20Info.jpg)

### Home Page
![home page](https://github.com/BrendenWisnewski/FetchMates-MSSA-Project/blob/main/Images/Wireframes/HomePage1.jpg)

### Scheduling a Park Time
![schedule a time](https://github.com/BrendenWisnewski/FetchMates-MSSA-Project/blob/main/Images/Wireframes/Schedule%20a%20Park%20Time.jpg)

### Find a Park
![find a park](https://github.com/BrendenWisnewski/FetchMates-MSSA-Project/blob/main/Images/Wireframes/Find%20a%20Park.jpg)

### My Mates (Friends)
![my mates](https://github.com/BrendenWisnewski/FetchMates-MSSA-Project/blob/main/Images/Wireframes/My%20Mates.jpg)

[To Top](https://github.com/BrendenWisnewski/FetchMates-MSSA-Project/blob/main/README.md#fetchmates-mssa-project)

## System Requirements

### User Stories

As a new dog owner, I want to be able to find safe parks in my area so that I can bring my new dog to a dog park and know that he or she will be safe.

As a dog parent who just moved to San Diego, I would like to be able to locate multiple parks in my region and see the ratings of those parks so that I am aware of what I will experience when I am at that dog park.

As a new dog owner and a person who just moved to San Diego, I would like to be able to find other dogs and dog owners in my region so that I can start to socialize my dog and meet other dog owners.

As a San Diegan dog owner, I would like to be able to communicate with other dog owners on an app so that I can socialize my dog in an outdoor setting and be able to socially distance.

### Use Cases

Given the amount of dog parks in San Diego, when there are plenty of new dog owners, then I will provide Google map pinning all the known dog parks on Google Maps.

Given the amount of dog parks in San Diego, when some of these parks can get very packed, then I will create a calendar like feature which will let users schedule times that they will be at the dog park so that other owners can get an idea of peak and off-peak times.

Given a new dog owner when there are plenty of apps for people to meet, then I will create a matching feature strictly for dogs based on matching dogs based on their personalities so that no data is collected on the user rather just a small amount of information on the dog.

Given the current state of affairs with COVID when California is still enforcing regulations, then my app is going to be focused on meeting at dog parks that are outdoors and allows people to socially distance and let their dogs play. 


Given that not all dogs are friendly when there are dogs who do not enjoy dogs but still want to go to parks then the user will be able to use the calendar feature to get a picture of when the off-peak times are so that they can still bring their dog to the park to release their energy.

### UML

![uml](https://github.com/BrendenWisnewski/FetchMates-MSSA-Project/blob/main/Images/UML.jpg)

### Requirements

|Requiredment ID|Description|Test Method|TestID|
|---|---|---|---|
|1|The system shall ask the user to log in or create a profile.|test|1|
|2|The system shall allow the user to create a profile for their dog.|test|2|
|2.1|The system shall validate user input to verify correct information is being inputted.|test|2|
|2.2|The system shall gather a small amount of information on the users dog to include name, weight, gender, and breed.|test|2|
|2.3|The system shall ask for personality traits to describe their dog.|test|2|
|2.4|The system shall match profiles with similar personalities and allow the user to chose which profiles to interact with.|test|3|
|2.5|The system shall provide a messaging feature to let two profiles communicate.|inspection| |
|3|The system shall provide a map to provide dog park locations.|inspection| |
|3.1|The system shall allow user input on park ratings to allow other users to get input on dog parks in the region.|test|4|
|3.2|The system shall redirect users to Google Maps for directions to the dog park.|inspection| |
|3.3|The system shall allow users to schedule a time to go to the dog park using a calendar.|test|5|
|3.4|The system shall show peak and off peak times to allow dog owners to get an idea of when the best time to bring their dog is.|test|5|

[To Top](https://github.com/BrendenWisnewski/FetchMates-MSSA-Project/blob/main/README.md#fetchmates-mssa-project)

## Testing

|Test ID|Requirement ID|Test Procedure|Status|Time Completed|
|---:|:---|:---|:---:|:---|
|1|1|Validate login in credentials|not completed| |
|2|2.0, 2.1, 2.3, 2.3|Validate correct information is being inputted in the text fields|not completed| |
|3|2.4|Build tests to check that approriate profiles are being matched with the similar personalities|not completed| |
|4|3.1|Build tests to verify that user responses are visiable on the map|not completed| |
|5|3.3, 3.4|Validate user input times and allow overlapping of other user times|not completed| |

[To Top](https://github.com/BrendenWisnewski/FetchMates-MSSA-Project/blob/main/README.md#fetchmates-mssa-project)

## Prototype

These are some HTML prototype snap shots of the user interface I would like to implement. I really want my webapp to be bright and colorful and very dog centered and dog friendly. The first thing I thought of was getting a dog as the backround image when you first enter the page. It doesnt leave the user with any questions about what the weboste is about. The user will enter and understand that the webapp is for dog owners, and for people trying to find and schedule dog park times.

### Welcome Page

This is the idea of what I would like the first page to be. When the user enters it is very clean and simple, make an account or log in. I have not implemented the account creation page yet, that is still in process. My main focus at the time is building a welcoming page. Create an Account and Sign Up will both redirect to a account creation page. The find parks tab will redirect to a calender where users can select a park and time when they would like to attend. My Mates will redirect the user to their profile home page. About us will be a page with a mission statement and a little more about the project.

![initial page](https://github.com/BrendenWisnewski/FetchMates-MSSA-Project/blob/main/Images/Prototype/Fetch%20Mates%20Home%20Page.jpg)

### Schedule a Park Time

This is the park scheduling simple concept. Using a calender the user can schedule a time and a place where they can bring their dog to the park. I started to like the idea of the calender because it is a simple and easy way for other owners to see where dog owners are planning to be that day or week. The functionality I would like to include is, when the user clicks on a day, they can input their dogs profile name, the park they would like to attend (San Diego focused), and a time they will attend.

![calender](https://github.com/BrendenWisnewski/FetchMates-MSSA-Project/blob/main/Images/Prototype/Calender%20view.jpg)


[To Top](https://github.com/BrendenWisnewski/FetchMates-MSSA-Project/blob/main/README.md#fetchmates-mssa-project)


## Database In Action

### Dogs in the Database So Far
![create dog](https://github.com/BrendenWisnewski/FetchMates-MSSA-Project/blob/main/Images/Database%20in%20Action/Create%20Dog%20Information.jpg)

### Create a New Dog
![add in dog](https://github.com/BrendenWisnewski/FetchMates-MSSA-Project/blob/main/Images/Database%20in%20Action/Adding%20in%20Dog%20Information.jpg)

### Dogs Who Have Scheduled
![park](https://github.com/BrendenWisnewski/FetchMates-MSSA-Project/blob/main/Images/Database%20in%20Action/Scheduling%20the%20Park.jpg)

### Schedule a Park Time
![schedule](https://github.com/BrendenWisnewski/FetchMates-MSSA-Project/blob/main/Images/Database%20in%20Action/Creating%20a%20Dog%20Park%20Visit.jpg)


[To Top](https://github.com/BrendenWisnewski/FetchMates-MSSA-Project/blob/main/README.md#fetchmates-mssa-project)
