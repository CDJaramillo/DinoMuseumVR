# Dino Museum VR

Dino Museum VR is for educational use.

## Getting Started

If you wanna edit this project on Unity make sure you switch it on Android platform. 

### Prerequisites

You need the next software and hardware for use the project.

*Unity 5.6 or above.

*Google VR SDK.

*A Smartphone with Android 4.4.4 or above and gyroscope.

*A Cardboard

*Android SDK and Java JDK (make sure to install Android Studio and download the SDK, and install the [JDK from here](http://www.oracle.com/technetwork/java/javase/downloads/jdk8-downloads-2133151.html)

### Installing

First you need Unity 5.6 or above, also you need Android Studio with the SDK and JDK, then you need to create the APK and a compatible smartphone with gyroscope for using the project and a Google Cardboards (or other VR device) for the VR experiencie.

If you download the APK from this repository you need a compatible smartphone and a googles VR.

## Running the tests

The player can move through the museum and use the waypoints (spheres) to move on any direction.

In the museum players can see some dinosaurs and images, also a text (on spanish for now) with some information of these creatures.

### Break down into end to end tests

The principal test are if the waypoints work with the cardboard button, the structure of the museum was good and if the text is smooth

I use differents type of people and I changed the problems this is my results of my tests with people.

With classmates they saw a problem with the walls, are too bright and give some motion sickness, also the information text are not smoothnes

For the solution I've changed the walls with new type of texture, also y use a ceiling, for the text I've changed for a button with a 2D image sprite, and use a script for the player using the cardboard button this text get bigger and easy to read.

With normal people the only problem was the walls.

## Built With

* [Unity](https://unity3d.com/es) - The game engine.
* [Google VR SDK for Android](https://developers.google.com/vr/develop/android/get-started) - SDK for VR devices

## Contributing

When contributing to this repository, please first discuss the change you wish to make via issue, email, or any other method with the owners of this repository before making a change.

Please note we have a code of conduct, please follow it in all your interactions with the project.

Pull Request Process
Ensure any install or build dependencies are removed before the end of the layer when doing a build.
Update the README.md with details of changes to the interface, this includes new environment variables, exposed ports, useful file locations and container parameters.
Increase the version numbers in any examples files and the README.md to the new version that this Pull Request would represent. The versioning scheme we use is SemVer.
You may merge the Pull Request in once you have the sign-off of two other developers, or if you do not have permission to do that, you may request the second reviewer to merge it for you.
 
## Authors

* **Cristian Jaramillo** - *Initial work* - [Dino Museum VR](https://github.com/Chuntaco/DinoMuseumVR)

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## Acknowledgments

* Hat tip to anyone who's code was used
* Inspiration
* Motivation
* Studies
* Etc
