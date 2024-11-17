# 2D Warrior Platformer Demo

This is a simple 2D Unity project demonstrating basic gameplay mechanics and character animation. The project features a warrior character that can move left and right, jump, and interact with a basic platform-based world.

## Features

- **Animated Warrior Character**:
  - Fully animated sprite for the warrior.
  - Smooth left and right movement with proper flipping.
  - Jump functionality to navigate platforms.

- **Basic Game World**:
  - Platforms made from textured 2D squares.
  - A clean and minimalistic setup to showcase character mechanics.

- **Camera System**:
  - Dynamic camera that follows the player’s movement.
  - Consistent player and world scaling across different aspect ratios (portrait and landscape).

- **Minimap**:
  - A working minimap that shows the player and surroundings.

## How to Play

1. **Movement**:
   - Move **left** and **right** using the arrow keys or `A` and `D`.
   - Jump using the `Space` key.

2. **Minimap**:
   - Observe the player’s position in the minimap (displayed in the corner).

## Play Online

You can try out the project on **itch.io**:  
[Minimap Demo on itch.io](https://shutafimpro.itch.io/minimap)

## Assignment-Specific Question: Camera View Scaling Issue

In Unity's `Simulator` mode, rotating the device (simulating portrait or landscape) changes how the scene is displayed. 

### Why do objects appear larger in portrait mode?

When the camera is set to an **orthographic projection**, the `orthographicSize` controls the vertical view of the camera. As the aspect ratio changes (e.g., rotating from landscape to portrait), Unity scales the camera's horizontal field of view to fit the new screen width. 

In **portrait mode**, the narrower width means Unity "zooms in" horizontally to keep everything visible. This makes objects appear larger. Conversely, in **landscape mode**, the wider width makes objects appear smaller because more of the scene is visible horizontally.

### Solution to Maintain Object Size:

To ensure objects appear the same size regardless of rotation, we use a script to dynamically adjust the camera's `orthographicSize` based on the current screen aspect ratio.


## License

This project is open source and can be freely used for learning or personal projects. Feel free to expand upon it!
