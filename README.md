# Water Sorting Puzzle

A Windows desktop implementation of the classic **Water Sort Puzzle** game.  
The goal is to **sort colors** so that each vial contains **only one color** (or is empty).

## Features

- **Drag & drop gameplay** (pour from one vial to another)
- **Valid move rules**:
  - can pour only if the destination has space
  - can pour only onto the same color (or into an empty vial)
  - pours **as many consecutive segments of the same color as possible** in one move
- **Difficulty modes** with limited undos:
  - Easy / Medium / Hard (different number of empty vials and undo limit)
- **Undo** (limited by difficulty)
- **Scoring system** + **Best Score** persisted between runs
- **Customizable settings**:
  - difficulty (Easy/Medium/Hard)
  - number of vials
  - maximum segments per vial
  - Light/Dark color theme
- **New Game**, **Next Puzzle**, **Surrender**

## Tech Stack

- **C#**
- **Windows Forms (WinForms)**
- **.NET 8 (Windows)**

## Requirements

- Windows 10/11
- **.NET 8 SDK** (or Visual Studio 2022 with .NET desktop development)

## How to Run

### Visual Studio
1. Open `WaterSortingPuzzle.sln`
2. Set the WinForms project as Startup Project (if needed)
3. Run (F5)
