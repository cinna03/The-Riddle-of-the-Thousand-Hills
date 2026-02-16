Unity Escape Room Game — Technical Overview
1. Introduction
This project presents a 3D escape room game developed using the Unity engine. The primary objective is to engage the player in solving a series of sequential puzzles within a constrained time limit. The game is designed to challenge problem-solving skills, spatial reasoning, and time management.
2. Game Concept
The game environment consists of a single enclosed room containing interactive objects and visual clues. The player must complete five consecutive puzzle layers within an eight-minute timeframe to unlock the exit door.
Completion of each puzzle layer awards the player a single letter. When collected in sequence, the letters form the word NZIZA. Successfully solving all five layers before the timer expires constitutes a victory, whereas failure to complete the puzzles within the allotted time results in a loss.
3. Core Gameplay Loop
The gameplay follows a structured loop designed to provide continuous engagement:
The player navigates and explores the escape room.


A puzzle clue is displayed on the user interface (UI).


The player interacts with the environment to solve the current puzzle layer.


Upon successful completion, a congratulatory message is displayed.


A letter reward is granted and recorded.


Progress is updated.


The next puzzle clue is displayed.


This loop repeats until all five puzzle layers have been completed.
4. Puzzle Layers
The escape room contains five sequential puzzle layers. Each layer is associated with a specific task and letter reward:
Layer
Puzzle Description
Letter Reward
1
Click the King (Mwami) painting
N
2
Place the King painting on the table
Z
3
Flip the painting backward
I
4
Switch the lights to reveal hidden message
Z
5
Flip the painting upside down
A

Completion of the fifth layer triggers the unlocking of the exit door.
5. Timer System
The game features an eight-minute countdown timer displayed at the top of the screen. The timer mechanics are as follows:
If the timer reaches zero, the lose panel is displayed, and game execution is paused.


The countdown actively drives player urgency and ensures that the challenge is time-bound.


6. User Interface (UI) Elements
The UI is managed through a Canvas object containing the following components:
TimerText: Displays the countdown timer.


ProgressText: Shows the current puzzle layer progress (e.g., “2/5 Layers”).


LetterText: Displays letters collected by the player.


ClueText: Provides the current puzzle hint.


CongratsPanel: Shows a success message after completing a puzzle layer or the game.


LosePanel: Displays upon timer expiration.


7. Scene Hierarchy
The scene hierarchy is organized to facilitate interaction and management of game objects:
GameManager


TimerManager


UIManager (optional)


Player


Main Camera


Environment


Room


Table


Lights


ExitDoor


Paintings


MwamiPainting


UmugabekaziPainting


AbiruPainting


Canvas


8. Core Scripts
8.1 GameManager.cs
Responsible for managing the overall game state, including:
Tracking the current puzzle layer.


Managing clues and letter rewards.


Updating player progress.


Handling win and lose conditions.


8.2 TimerManager.cs
Responsible for:
Running the countdown timer.


Triggering the GameManager.LoseGame() method upon timer expiration.


8.3 Layer Scripts
Each puzzle layer has an individual script that communicates with the GameManager. Upon completion, the script invokes:
gameManager.CompleteLayer(layerIndex);

9. How to Run
To execute the game:
Open the project in Unity.


Open the Main Scene.


Press Play.


Follow on-screen clues to solve puzzles sequentially.


Escape the room before the timer reaches zero.


10. Required Object Setup
10.1 Paintings
Must have a Collider component (BoxCollider recommended).


Must have the corresponding layer script attached.


Must reference the GameManager object.


10.2 GameManager
Inspector assignments required:
ClueText


LetterText


ProgressText


CongratsPanel


CongratsText


LosePanel


ExitDoor


The Main Camera must be tagged as MainCamera.
11. Win and Lose Conditions
11.1 Win Condition
All five puzzle layers are completed.


Collected letters form the word NZIZA.


The exit door unlocks.


11.2 Lose Condition
The timer reaches zero.


The lose panel is displayed, halting game execution.
