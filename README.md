Unity Escape Room Game — Overview Game Concept

This is a 3D Unity-based escape room game in which the player must solve five sequential puzzle layers within eight minutes to unlock the exit door.

Each completed puzzle layer awards the player a single letter.

The collected letters, in order, spell N Z I Z A.

Completing all five layers before the timer expires results in a win.

If the timer reaches zero, the player loses.

Core Gameplay Loop

The player explores the room.

A puzzle clue is displayed on screen.

The player solves the current puzzle layer.

A congratulatory message is displayed.

A letter reward is granted.

Progress is updated.

The next clue is displayed.

Repeat until all five layers are completed.

Puzzle Layers Layer Puzzle Description Letter 1 Click the King (Mwami) painting N 2 Place the King painting on the table Z 3 Flip the painting backward I 4 Switch the lights to reveal hidden message Z 5 Flip the painting upside down A

After the fifth layer, the exit door unlocks.

Timer System

Eight-minute countdown.

Displayed at the top of the screen.

If the timer reaches zero:

The lose panel is displayed.

Game execution is paused.

User Interface (UI) Elements

The Canvas contains the following components:

TimerText: Displays the countdown timer.

ProgressText: Shows current layer progress (e.g., “2/5 Layers”).

LetterText: Displays collected letters.

ClueText: Shows the current puzzle hint.

CongratsPanel: Displays a success message after completing a layer or the game.

LosePanel: Displays when time runs out.

Scene Hierarchy

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

Core Scripts GameManager.cs

Responsible for:

Tracking the current puzzle layer.

Managing clues and letters.

Updating progress.

Handling win and lose conditions.

TimerManager.cs

Responsible for:

Running the countdown timer.

Triggering GameManager.LoseGame() when the timer expires.

Layer Scripts

Each puzzle layer has an individual script.

Upon completion, it calls:

gameManager.CompleteLayer(layerIndex);

How to Run

Open the project in Unity.

Open the Main Scene.

Press Play.

Follow the on-screen clues.

Solve the puzzles in order.

Escape before the timer reaches zero.

Required Object Setup Paintings

Must have a Collider (BoxCollider recommended).

Must have the corresponding layer script attached.

Must have a reference to the GameManager.

GameManager

Inspector assignments required:

ClueText

LetterText

ProgressText

CongratsPanel

CongratsText

LosePanel

ExitDoor

Camera

Must be tagged as MainCamera.

Win Condition

All five layers are completed.

The letters form the word NZIZA.

Exit door opens.

Lose Condition

Timer reaches zero.

Lose panel is displayed.
