# 3D Coin Collecting Game 🎮

A simple 3D game built in Unity where the player moves forward automatically, collects coins, avoids barriers and survives as long as possible!

## Features
- 🚶 Automatic forward movement
- 🎯 Steer left and right using **Arrow Keys** or **A/D**
- 🪹 Collect spinning coins to increase your score
- 🚷 Hit barriers to lose health
- ❌ Game Over when health reaches zero
- 📈 Real-time Score and Health UI

## How to Play
- Move left and right with the **Left/Right Arrow keys** or **A/D keys**.
- Collect coins to increase your score.
- Avoid barriers! If you hit too many, you will lose all health and the game will end.

## Project Structure
- `Assets/Scripts/PlayerController.cs` - Handles player movement, coin collection, health reduction, and game over logic.
- `Assets/Scripts/CoinRotation.cs` - Spins the coins and detects when the player collects them.
- `Assets/Prefabs/Coin.prefab` - Coin object with a collider and rotation script.
- `Assets/Prefabs/Barrier.prefab` - Barrier object that reduces player health on collision.
- `Assets/UI/` - Contains Score Text, Health Text, and Game Over Panel.

## Setup Instructions
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/your-repo-name.git
   ```
2. Open the project with **Unity** (recommended version: 2021.3 or later).
3. Load the main scene from `Assets/Scenes/`.
4. Hit **Play** and enjoy!

## Requirements
- Unity 2021.3 LTS or newer
- Basic understanding of Unity (dragging scripts, setting tags, adding colliders)

## Known Issues
- No sound effects yet (Coming Soon!)
- Basic models (can be replaced with better 3D assets)

## Future Improvements
- Add background music and sound effects 🎵
- Add different types of coins with special effects ✨
- Add a main menu and restart button 🔹
- Add player animations for better feel 🎬

## License
This project is open-source and free to use for learning purposes!
