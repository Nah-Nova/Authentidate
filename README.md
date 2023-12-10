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
- **User Matching**: Implement Matching screen with swipe actions etc like tinder
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

## Uitgewerkte Features:
- **User Authentication**: Implement secure user authentication and registration.
- **Profile Creation**: Enable users to create detailed profiles with photos and interests. (Minimal Version)
- **User Matching**: Implement Matching screen with swipe actions etc like tinder
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
Hieronder volgt een uitbreiding van Use Case 1/11 en een sjabloon

### Use Case [Nummer]: [Titel]
| Use Case | UC[Nummer]: [Titel] |
|:----------------|:--------------------------|
| **Description** | [Korte beschrijving van wat de use case inhoudt] |
| **Actor** | [De primaire actor, meestal de gebruiker of het systeem] |
| **Trigger(s)** | [Wat initieert de use case?] |
| **Pre-Conditions** | [Voorwaarden voordat de use case begint] |
| **Post-Conditions** | [De staat van het systeem na voltooiing van de use case] |
| **Steps** | 
| **Actor (User)** | **System** |
| 1. [Actie door de gebruiker] | |
|  | 2. [Reactie van het systeem] |
| [Verdere stappen...] | |
| **Main Success Scenario** | [Beschrijving van het pad voor het succesvol afronden van de use case] |
| **Alternative Scenarios** | [Beschrijving van alternatieve paden] |
| **Extensions** |
| [Extensiepunt] | [Beschrijving van de extensie] |

### Use Case 1: Account Beheren (Uitgebreid)
| Use Case | UC1: Account Beheren |
|:----------------|:--------------------------|
| **Description** | Gebruiker kan accountinstellingen aanpassen, zoals e-mailadres, wachtwoord, en profielinformatie. |
| **Actor** | Geregistreerde gebruiker |
| **Trigger(s)** | De gebruiker kiest ervoor om accountinstellingen aan te passen. |
| **Pre-Conditions** | De gebruiker moet ingelogd en geverifieerd zijn. |
| **Post-Conditions** | De wijzigingen zijn opgeslagen en het account is bijgewerkt. |
| **Steps** | 
| **Actor (User)** | **System** |
| 1. De gebruiker selecteert de optie om accountinstellingen te beheren. | |
|  | 2. Het systeem presenteert de accountinstellingen pagina. |
| 3. De gebruiker kiest een instelling om te wijzigen (bijv. e-mail, wachtwoord). | |
| 4. De gebruiker voert de nieuwe informatie in en bevestigt de wijzigingen. | |
|  | 5. Het systeem valideert en verwerkt de wijzigingen. |
|  | 6. Het systeem slaat de wijzigingen op in de database. |
|  | 7. Het systeem bevestigt dat de wijzigingen succesvol zijn doorgevoerd. |
| **Main Success Scenario** | De gebruiker voltooit het bijwerken van de accountinstellingen succesvol. |
| **Alternative Scenarios** | De gebruiker probeert een reeds bestaande e-mail te gebruiken of verlaat de pagina voordat de wijzigingen zijn opgeslagen. |
| **Extensions** |
| 5a. De ingevoerde e-mail is al in gebruik: | 5a1. Het systeem informeert de gebruiker en vraagt om een ander e-mailadres. |
| 7a. De gebruiker verlaat de pagina voordat de wijzigingen zijn opgeslagen: | 7a1. Het systeem waarschuwt de gebruiker dat de wijzigingen nog niet zijn opgeslagen. |

### Use Case 2: Gebruiker Registreren
| Use Case | UC2: Gebruiker Registreren |
|:----------------|:--------------------------|
| **Description** | Nieuwe gebruiker maakt een account aan op de dating app. |
| **Actor** | Potentiële gebruiker |
| **Trigger(s)** | De potentiële gebruiker selecteert de optie om een nieuw account te registreren. |
| **Pre-Conditions** | De gebruiker heeft de app geïnstalleerd en heeft nog geen account. |
| **Post-Conditions** | Een nieuw gebruikersaccount is aangemaakt en klaar voor gebruik. |
| **Steps** | 
| **Actor (User)** | **System** |
| 1. De gebruiker kiest voor 'Registreren'. | |
|  | 2. Het systeem toont het registratieformulier. |
| 3. De gebruiker vult het registratieformulier in (e-mail, wachtwoord, etc.). | |
|  | 4. Het systeem valideert de ingevoerde gegevens. |
|  | 5. Het systeem creëert het account en slaat de gegevens op. |
|  | 6. Het systeem stuurt een verificatie-e-mail naar de gebruiker. |
| **Main Success Scenario** | De gebruiker voltooit succesvol de registratie en verifieert het account via e-mail. |
| **Alternative Scenarios** | De gebruiker voert een e-mail in die al in gebruik is of voldoet niet aan de wachtwoordcriteria. |

### Use Case 3: Gebruiker Inloggen
| Use Case | UC3: Gebruiker Inloggen |
|:----------------|:--------------------------|
| **Description** | Geregistreerde gebruiker logt in op de app. |
| **Actor** | Geregistreerde gebruiker |
| **Trigger(s)** | De gebruiker selecteert de optie om in te loggen. |
| **Pre-Conditions** | De gebruiker heeft al een account. |
| **Post-Conditions** | De gebruiker heeft toegang tot zijn of haar account op de app. |
| **Steps** | 
| **Actor (User)** | **System** |
| 1. De gebruiker selecteert 'Inloggen'. | |
|  | 2. Het systeem toont het inlogscherm. |
| 3. De gebruiker vult de inloggegevens in. | |
|  | 4. Het systeem valideert de gegevens en geeft de gebruiker toegang tot het account. |
| **Main Success Scenario** | De gebruiker krijgt toegang tot het account na het invoeren van geldige inloggegevens. |
| **Alternative Scenarios** | De inloggegevens zijn onjuist, en het systeem toont een foutmelding. |

### Use Case 4: Account Verwijderen
| Use Case | UC4: Account Verwijderen |
|:----------------|:--------------------------|
| **Description** | Gebruiker verwijdert zijn of haar account permanent uit de app. |
| **Actor** | Geregistreerde gebruiker |
| **Trigger(s)** | De gebruiker selecteert de optie om het account te verwijderen. |
| **Pre-Conditions** | De gebruiker is ingelogd en heeft toegang tot accountinstellingen. |
| **Post-Conditions** | Het account van de gebruiker is niet langer actief en alle gegevens zijn verwijderd. |
| **Steps** | 
| **Actor (User)** | **System** |
| 1. De gebruiker gaat naar accountinstellingen en selecteert 'Account verwijderen'. | |
|  | 2. Het systeem vraagt om bevestiging van de gebruiker. |
| 3. De gebruiker bevestigt de wens om het account te verwijderen. | |
|  | 4. Het systeem verwijdert alle gebruikersgegevens en deactiveert het account. |
| **Main Success Scenario** | Het account wordt succesvol verwijderd na bevestiging van de gebruiker. |
| **Alternative Scenarios** | De gebruiker annuleert het verwijderingsproces. |

### Use Case 5: Interesse Managen
| Use Case | UC5: Interesse Managen |
|:----------------|:--------------------------|
| **Description** | Gebruiker beheert zijn of haar interesses om betere matches te krijgen. |
| **Actor** | Geregistreerde gebruiker |
| **Trigger(s)** | De gebruiker wil interesses toevoegen, verwijderen of bijwerken. |
| **Pre-Conditions** | De gebruiker is ingelogd en heeft een profiel aangemaakt. |
| **Post-Conditions** | De lijst van interesses van de gebruiker is bijgewerkt. |
| **Steps** | 
| **Actor (User)** | **System** |
| 1. De gebruiker gaat naar het profiel en selecteert 'Interesses bewerken'. | |
|  | 2. Het systeem toont de huidige interesses en opties voor het beheer ervan. |
| 3. De gebruiker voegt nieuwe interesses toe of verwijdert bestaande. | |
|  | 4. Het systeem slaat de wijzigingen op. |
| **Main Success Scenario** | De gebruiker werkt de interesses bij voor een betere matchmaking ervaring. |
| **Alternative Scenarios** | De gebruiker besluit geen wijzigingen door te voeren en annuleert het proces. |


### Use Case 6: Wachtwoord Vergeten
| Use Case | UC6: Wachtwoord Vergeten |
|:----------------|:--------------------------|
| **Description** | Gebruiker reset het vergeten wachtwoord om weer toegang te krijgen tot het account. |
| **Actor** | Niet-ingelogde gebruiker |
| **Trigger(s)** | De gebruiker kan niet inloggen vanwege een vergeten wachtwoord. |
| **Pre-Conditions** | De gebruiker heeft reeds een account. |
| **Post-Conditions** | De gebruiker heeft een nieuw wachtwoord ingesteld en kan inloggen. |
| **Steps** | 
| **Actor (User)** | **System** |
| 1. De gebruiker selecteert 'Wachtwoord vergeten?'. | |
|  | 2. Het systeem vraagt om het e-mailadres van de gebruiker. |
| 3. De gebruiker voert het e-mailadres in en verzoekt om een reset link. | |
|  | 4. Het systeem stuurt een wachtwoord reset link naar het opgegeven e-mailadres. |
| 5. De gebruiker klikt op de link en voert een nieuw wachtwoord in. | |
|  | 6. Het systeem valideert en slaat het nieuwe wachtwoord op. |
| **Main Success Scenario** | De gebruiker stelt met succes een nieuw wachtwoord in en krijgt toegang tot het account. |
| **Alternative Scenarios** | Het opgegeven e-mailadres komt niet overeen met een bestaand account. |

### Use Case 7: Matchen
| Use Case | UC7: Matchen |
|:----------------|:--------------------------|
| **Description** | Gebruiker krijgt matches voorgesteld op basis van overeenkomstige antwoorden op quizzen. |
| **Actor** | Geregistreerde gebruiker |
| **Trigger(s)** | De gebruiker heeft een quiz ingevuld of een profiel bijgewerkt. |
| **Pre-Conditions** | De gebruiker is ingelogd en heeft quizzen ingevuld. |
| **Post-Conditions** | De gebruiker heeft een lijst met potentiële matches. |
| **Steps** | 
| **Actor (User)** | **System** |
|  | 1. Het systeem gebruikt de antwoorden op de quiz om compatibele matches te vinden. |
| 2. De gebruiker bekijkt de voorgestelde matches. | |
| 3. De gebruiker kiest ervoor om een 'like' te geven of verder te gaan. | |
|  | 4. Bij wederzijdse 'likes' stelt het systeem een match vast. |
| **Main Success Scenario** | Gebruikers worden gematcht en kunnen beginnen met communiceren. |
| **Alternative Scenarios** | Geen matches gevonden of de gebruiker kiest ervoor niemand te 'liken'. |

### Use Case 8: Foto Insturen
| Use Case | UC8: Foto Insturen |
|:----------------|:--------------------------|
| **Description** | Gebruiker voegt foto's toe aan het profiel om zichzelf visueel te presenteren. |
| **Actor** | Geregistreerde gebruiker |
| **Trigger(s)** | De gebruiker wil foto's toevoegen aan het profiel. |
| **Pre-Conditions** | De gebruiker is ingelogd en heeft toegang tot het profiel. |
| **Post-Conditions** | Foto's zijn toegevoegd aan het gebruikersprofiel. |
| **Steps** | 
| **Actor (User)** | **System** |
| 1. De gebruiker selecteert de optie om foto's toe te voegen. | |
|  | 2. Het systeem opent de fotogalerij of camera. |
| 3. De gebruiker kiest een foto en uploadt deze. | |
|  | 4. Het systeem valideert de foto en voegt deze toe aan het profiel. |
| **Main Success Scenario** | De foto wordt succesvol toegevoegd aan het profiel van de gebruiker. |
| **Alternative Scenarios** | De foto voldoet niet aan de communityrichtlijnen en wordt afgewezen. |

### Use Case 9: Vragenlijst Managen
| Use Case | UC9: Vragenlijst Managen |
|:----------------|:--------------------------|
| **Description** | Gebruiker maakt of wijzigt een persoonlijke vragenlijst voor matching doeleinden. |
| **Actor** | Geregistreerde gebruiker |
| **Trigger(s)** | De gebruiker wil een vragenlijst maken of bijwerken. |
| **Pre-Conditions** | De gebruiker is ingelogd en heeft een profiel. |
| **Post-Conditions** | Een nieuwe of bijgewerkte vragenlijst is opgeslagen in het profiel van de gebruiker. |
| **Steps** | 
| **Actor (User)** | **System** |
| 1. De gebruiker selecteert de optie om een vragenlijst te managen. | |
|  | 2. Het systeem toont de bestaande vragenlijst of opties voor een nieuwe. |
| 3. De gebruiker voegt vragen toe, verwijdert ze of wijzigt ze. | |
|  | 4. Het systeem slaat de wijzigingen op in de vragenlijst. |
| **Main Success Scenario** | De gebruiker heeft succesvol een vragenlijst gecreëerd of bijgewerkt. |
| **Alternative Scenarios** | De gebruiker annuleert de wijzigingen of slaat ze niet op. |

### Use Case 10: Matches Managen
| Use Case | UC10: Matches Managen |
|:----------------|:--------------------------|
| **Description** | Gebruiker beheert de lijst van huidige matches en communicatie. |
| **Actor** | Geregistreerde gebruiker |
| **Trigger(s)** | De gebruiker wil interactie hebben met de huidige matches. |
| **Pre-Conditions** | De gebruiker is ingelogd en heeft een lijst van matches. |
| **Post-Conditions** | De gebruiker heeft de interacties met matches bijgewerkt. |
| **Steps** | 
| **Actor (User)** | **System** |
| 1. De gebruiker opent de lijst van matches. | |
|  | 2. Het systeem toont alle huidige matches. |
| 3. De gebruiker selecteert een match om te communiceren of te verwijderen. | |
|  | 4. Het systeem voert de actie uit zoals aangegeven door de gebruiker. |
| **Main Success Scenario** | De gebruiker beheert de matches en begint of beëindigt communicatie. |
| **Alternative Scenarios** | De gebruiker kan geen beslissing nemen en verlaat de lijst. |

### Use Case 11: Berichten Sturen
| Use Case | UC11: Berichten Sturen |
|:----------------|:--------------------------|
| **Description** | Gebruiker stuurt berichten naar een match om communicatie te starten of voort te zetten. |
| **Actor** | Geregistreerde gebruiker |
| **Trigger(s)** | De gebruiker wil communiceren met een match. |
| **Pre-Conditions** | De gebruiker is gematcht met een andere gebruiker en beide hebben toegang tot de berichtenfunctie. |
| **Post-Conditions** | Bericht(en) is/zijn verzonden en ontvangen door de match. |
| **Steps** | 
| **Actor (User)** | **System** |
| 1. De gebruiker selecteert een match om mee te communiceren. | |
|  | 2. Het systeem opent de chat met de geselecteerde match. |
| 3. De gebruiker typt een bericht en verzendt dit. | |
|  | 4. Het systeem verzendt het bericht naar de match. |
| **Main Success Scenario** | De communicatie wordt succesvol gestart of voortgezet tussen de gebruiker en de match. |
| **Alternative Scenarios** | Het bericht kan niet worden verzonden door technische problemen. |

## UML Diagrammen 📊
Hier staan alle diagrammen met enige toegevoegde waarde voor authentidate allemaal volgens uml specificatie.

### Use Case Diagram:
<img width="794" alt="Screenshot 2023-12-10 at 11 56 22" src="https://github.com/Nah-Nova/Authentidate/assets/56248103/82449ad1-c692-4fd1-aeb3-a5e297d438d6">


Deze requirements zorgen ervoor dat Authentidate zowel aan de verwachtingen van de gebruikers voldoet als technisch robuust en veilig is.
## License

This project is licensed under the [MIT License](LICENSE).
