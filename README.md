# Bullshit Gameshow

This is a console based game, that simulates the rules of the netflix tv show game, bullshit gameshow. 

Welcome to the *Bullshit Gameshow*, a console-based trivia game with a twist! Answer questions correctly to earn points, and if you get a question wrong, try to bluff your way through with the help of some gullible contenders.

## Table of Contents
- [Features](#features)
- [Getting Started](#getting-started)
- [How to Play](#how-to-play)
- [Game Mechanics](#game-mechanics)
- [Dependencies](#dependencies)
- [Contributing](#contributing)


## Features
- *Interactive trivia game*: Answer a variety of questions on different topics.
- *Score tracking*: Keep track of your score as you play.
- *Bullshit your way through*: Even if you get a question wrong, you can still gain points by bluffing your way through with contenders' gullibility.

## Getting Started

### Prerequisites
- .NET SDK installed on your machine.

### Installation
1. Clone the repository:
   sh
   git clone https://github.com/your-username/Bullshit_Gameshow.git
   
2. Navigate to the project directory:
   sh
   cd Bullshit_Gameshow
   
3. Build the project:
   sh
   dotnet build
   

### Running the Game
To start the game, use the following command:
sh
dotnet run


## How to Play
1. Enter your name when prompted.
2. Answer the series of trivia questions. Each question will have multiple-choice options.
3. Enter the number corresponding to your answer.
4. If your answer is correct, you earn a point.
5. If your answer is incorrect, the game will attempt to bluff the way through using the contenders' gullibility.

## Game Mechanics

### Player
The player has:
- A Name
- A Score starting at 0

### Question
Each question has:
- A Text (the question itself)
- A list of Options (the possible answers)
- An Answer (the index of the correct option)

### Contender
Each contender has:
- A Name
- A Gullibility factor (a value between 0 and 1 indicating the likelihood of falling for the bluff)

### Bullshit Mechanic
When the player answers incorrectly, the game checks if any contender's gullibility allows the player to score despite the wrong answer. This is determined randomly based on each contender's gullibility factor.

## Dependencies
- .NET SDK

## Contributing
Contributions are welcome! Please fork the repository and submit a pull request with your changes.

1. Fork the Project
2. Create your Feature Branch (git checkout -b feature/AmazingFeature)
3. Commit your Changes (git commit -m 'Add some AmazingFeature')
4. Push to the Branch (git push origin feature/AmazingFeature)
5. Open a Pull Request

---

Enjoy the game and try not to bullshit too much!

