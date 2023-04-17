﻿using GameEngine;
using System.Runtime.CompilerServices;

namespace MyGame
{
    static class MyGame
    {
        private const int WindowWidth = 800;
        private const int WindowHeight = 600;

        private const string WindowTitle = "My Awesome Game";

        private static void Main(string[] args)
        {
            // Initialize the game.
            Game.Initialize(WindowWidth, WindowHeight, WindowTitle);

            // Create our scene.
            GameScene scene = new GameScene();
            Game.SetScene(scene);

            // Run the game loop.
            Game.Run();



            
            

        }
    }
}