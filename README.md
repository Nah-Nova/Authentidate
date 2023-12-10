# Authentidate
📱 Authentidate: The Authentic Dating App 💌
![Screenshot 2023-11-20 at 16 48 17](https://github.com/Nah-Nova/Authentidate/assets/56248103/d2a00497-f87a-4d3c-a6b9-56e17bc89b50)

## Introduction

Welcome to the Authentidate Mobile App Project! This project is a part of the A2D2 en B2C4 course - Mobile Applications in PI4, and it's a solo project undertaken as part of your coursework.

## Project Overview

### Assignment Description

The objective of this project is to develop a mobile application with a primary focus on user interaction and the application of various features provided by the Maui framework. The app aims to provide a dating experience that prioritizes authenticity and genuine connections among users. While functionality is important, the emphasis is on exploring and applying the capabilities of Maui.

### Project Choice

For this assignment, I have chosen Option 3: "App for singles (dating app) that introduces people to each other based on a quiz." The goal is to create a dating app that goes beyond swiping profiles and instead matches users based on their responses to a personalized quiz. Users can create their quizzes to share with others, fostering authentic connections.

## Features

- **User Authentication**: Implement secure user authentication and registration.
- **Quiz-Based Matching**: Allow users to answer quizzes to determine compatibility with others.
- **Profile Creation**: Enable users to create detailed profiles with photos and interests.
- **Custom Quizzes**: Let users create and share their quizzes for matchmaking.
- **Secure Messaging**: Implement private messaging between matched users.
- **User Privacy**: Provide control over profile visibility and privacy settings.
- **Reporting and Blocking**: Include features for reporting and blocking inappropriate users.
- **Community Standards**: Enforce clear guidelines for respectful interactions.
- **User Reviews**: Allow ratings and reviews for user interactions.
- **Safety Measures**: Implement identity verification and safety features.
- **User-Centered Design**: Place an emphasis on user experience and interface design.

## Design
[Authentidate-V1 High Fidelity Design](https://www.figma.com/file/PGEVCEQiztcgkpZBai1My2/Authentidate---V1?type=design&node-id=1%3A2&mode=design&t=AA3sQp2S6XCaOqGe-1)
## Technical Stack

- **Framework**: .NET MAUI
- **Programming Language**: C#
- **Database**: In-memory database
- **API Integration**: (if applicable)
- **Version Control**: Git/GitHub

## Getting Started

### Prerequisites

- .NET MAUI installed
- Visual Studio or Visual Studio Code
- (Any additional prerequisites...)

### Installation
1. Clone this repository: `git clone https://github.com/Nah-Nova/Authentidate`
2. Open the project in Visual Studio or Visual Studio Code.
3. Run the following commands in your terminal:

   ```bash
   sudo dotnet workload restore
   nuget restore
   ```

4. Build and run the application.

These commands will ensure that all the required workloads and NuGet packages are properly restored for your project.

## Usage

- Create an account or log in.
- Answer quizzes to determine compatibility.
- Create your quizzes for matchmaking.
- Explore profiles and connect with matches.
- Communicate securely through messaging.
- Report and block users for inappropriate behavior.
- Follow community guidelines for respectful interactions.

## Requirements
### Gebruikersrequirements

1. **Gebruikersregistratie**: Gebruikers moeten zich kunnen registreren met een e-mailadres en wachtwoord.
2. **Profielaanmaak**: Gebruikers moeten hun persoonlijke profiel kunnen aanmaken, inclusief foto's en interesses.
3. **Quizzen Beantwoorden**: Gebruikers moeten quizzen kunnen beantwoorden om hun compatibiliteit met anderen te bepalen.
4. **Eigen Quizzen Maken**: Gebruikers moeten hun eigen quizzen kunnen maken en delen.
5. **Privéberichten**: Gebruikers moeten veilig privéberichten kunnen versturen naar matches.
6. **Profielprivacy**: Gebruikers moeten controle hebben over de zichtbaarheid van hun profiel en privacy-instellingen.
7. **Rapporteren en Blokkeren**: Gebruikers moeten andere gebruikers kunnen rapporteren en blokkeren.
8. **Communityrichtlijnen**: Er moeten duidelijke richtlijnen zijn voor respectvolle interacties binnen de app.
9. **Gebruikersbeoordelingen**: Gebruikers moeten de mogelijkheid hebben om interacties met anderen te beoordelen.
10. **Veiligheidsmaatregelen**: Er moeten identiteitsverificatie en veiligheidsfuncties zijn.

### Systeemrequirements voor Authentidate

1. **Authenticatie Systeem**: Implementeer een beveiligd authenticatiesysteem voor gebruikersregistratie en -login.
2. **Profielbeheer Module**: Ontwikkel een systeem voor gebruikers om hun profielen te creëren en te bewerken.
3. **Quiz Matching Algoritme**: Creëer een algoritme dat gebruikers matcht op basis van hun antwoorden op quizzen.
4. **Quiz Management Systeem**: Ontwikkel functionaliteit voor gebruikers om hun eigen quizzen te maken en te beheren.
5. **Berichtensysteem**: Implementeer een veilig systeem voor privéberichten tussen gebruikers.
6. **Privacycontroles**: Ontwikkel een systeem dat gebruikers controle geeft over hun profielprivacy-instellingen.
7. **Rapportage- en Blokkeringsfunctie**: Implementeer functies voor het rapporteren en blokkeren van gebruikers.
8. **Handhaving van Communityrichtlijnen**: Integreer een systeem om de naleving van communityrichtlijnen te waarborgen.
9. **Review en Feedback Systeem**: Ontwikkel een mechanisme voor gebruikers om feedback te geven over interacties.
10. **Veiligheidsfeatures**: Implementeer features voor identiteitsverificatie en andere veiligheidsmaatregelen.

###Use Cases:
UC1: Account beheren
UC2: Gebruiker registreren
UC3: Gebruiker inloggen
UC4: Account verwijderen
UC5: Interesse Managen
UC6: Wachtwoord vergeten
UC7: Matchen
UC8: Foto Insturen
UC9: Vragenlijst Managen
UC10: Matches Managen
UC11: Berichten sturen

## Usecase Desciptions
### Use Case 1: Account Beheren
| Use Case | UC1: Account Beheren |
|:----------------|:--------------------------|
| **Description** | Gebruiker beheert account |
| **Actor** | Gebruiker |
| **Trigger(s)** | De gebruiker navigeert naar de account tab in de app |
| **Pre-Conditions** | - Gebruiker heeft een account & is geverifeerd |
| **Post-Conditions** | - Account is beheert |
| **Steps** | 
| **Actor (User)** | **System** |
| 1. Gebruiker drukt op tab genaamd accont | |
|  | 2. System toont account pagina|
| 3. Gebruiker heeft de mogelijkheid variabelen te weizigen | |
|  4. Gebruiker wijzigt email| |
|  | 5. System controleert of email al in gebruik is|
|  | 6. System stuurt data to db|
| | 7.System geeft succes |
| 8. Gebruiker verlaat account pagina tijdens bewerken | |
|  | 9. System geeft error error |
| **Main success scenario**|1, 2, 3, 4, 5, 6, 7|
| **Alternatieve scenario's**|1, 8 <br> 1, 2, 3, 4, 5, 9|

##UML Diagrammen 📊
Hier staan alle diagrammen met enige toegevoegde waarde voor authentidate allemaal volgens uml specificatie.

###Use Case Diagram:
<img width="794" alt="Screenshot 2023-12-10 at 11 56 22" src="https://github.com/Nah-Nova/Authentidate/assets/56248103/82449ad1-c692-4fd1-aeb3-a5e297d438d6">


Deze requirements zorgen ervoor dat Authentidate zowel aan de verwachtingen van de gebruikers voldoet als technisch robuust en veilig is.
## License

This project is licensed under the [MIT License](LICENSE).
