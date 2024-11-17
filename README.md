# 2D Warrior Platformer Demo

This is a simple 2D Unity project demonstrating basic gameplay mechanics and character animation. The project features a warrior character that can move left and right, jump, and interact with a basic platform-based world.

## Features

- **Animated Warrior Character**:
  - Fully animated sprite for the warrior.
  - Smooth left and right movement with proper flipping.
  - Jump functionality to navigate platforms.

- **Basic Game World**:
  - Platforms made from textured 2D squares.
  - A simple background representing the environment.
  - A clean and minimalistic setup to showcase character mechanics.

- **Camera System**:
  - Dynamic camera that follows the player’s movement.
  - Consistent player and world scaling across different aspect ratios (portrait and landscape).

- **Minimap**:
  - A working minimap that shows the player and surroundings.
  - Minimap dynamically adjusts to aspect ratio changes.

## How to Play

1. **Movement**:
   - Move **left** and **right** using the arrow keys or `A` and `D`.
   - Jump using the `Space` key.

2. **Minimap**:
   - Observe the player’s position in the minimap (displayed in the corner).

## Setup Instructions

1. Clone the repository or download the project files.
2. Open the project in Unity (version `2021.x` or newer recommended).
3. Play the scene to see the character in action.

## Scripts

### PlayerController.cs
Handles the warrior’s movement and jump mechanics:
- **Move Left/Right**: Adjusts the character’s position based on input.
- **Flip Character**: Ensures the character faces the correct direction when moving.
- **Jump**: Allows the player to jump when grounded.

### CameraFollow.cs
Makes the camera follow the player smoothly:
- Adjusts the camera's position while maintaining a consistent offset.

### DynamicCameraSize.cs
Adjusts the camera's orthographic size dynamically based on the screen's aspect ratio:
- Ensures consistent scaling of elements in both portrait and landscape modes.

### BackgroundFollow.cs
Keeps the background in sync with the camera:
- Creates a seamless environment as the player moves.

## Assets

- **Warrior Character**:
  - Custom sprite with animations for idle, running, and jumping states.
  
- **Textures**:
  - Placeholder textures for platforms and background.

## Future Improvements

- Add more textured platforms and props for an immersive environment.
- Implement additional player mechanics, such as attacking and climbing.
- Enhance the minimap with dynamic markers for obstacles or objectives.
- Introduce enemies and health systems for a basic game loop.

## License

This project is open source and can be freely used for learning or personal projects. Feel free to expand upon it!
