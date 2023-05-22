using GameDev.Utilities;
using System;

namespace GameDev.Exercises
{
    class ArraysExercise : Module
    {
        private SpriteManager _spriteManager = new SpriteManager();

        private Sprite _spriteOne = new Sprite(0);
        private Sprite _spriteTwo = new Sprite(1);

        private SpriteTexture _spriteTextureOne = new SpriteTexture("Graphics\\art_star");
        private SpriteTexture _spriteTextureTwo = new SpriteTexture("Graphics\\art_fishbowl");

        /// <summary>
        /// Create function. Initialize objects not related to content here
        /// </summary>
        public override void Create()
        {
            // Add sprites to the SpriteManager
            _spriteManager.AddSprite(_spriteOne);
            _spriteManager.AddSprite(_spriteTwo);

            //*********** Begin Focus Area 1 ***********//
            float[] spritePositions = new float[4];
            spritePositions[0] = 0.0f;
            // Create a one-dimensional array of floats
            
            //*********** End Focus Area 1 ***********//


            //*********** Begin Focus Area 2 ***********//

            // Set the position of each sprite
            //_spriteOne.SetPosition(spritePositions[0], spritePositions[0]);
            //_spriteTwo.SetPosition(spritePositions[0], spritePositions[0]);

            //*********** End Focus Area 2 ***********//


            //*********** Begin Focus Area 3 ***********//

            // Create a two-dimensional array of floats
            
            //*********** End Focus Area 3 ***********//


            //*********** Begin Focus Area 4 ***********//

            // Set the size of each sprite
            //_spriteOne.SetSize(spriteSizes[0, 0], spriteSizes[0, 0]);
            //_spriteTwo.SetSize(spriteSizes[0, 0], spriteSizes[0, 0]);

            //*********** End Focus Area 4 ***********//


            //*********** Begin Focus Area 5 ***********//

            // Create a jagged array of integer arrays


            // Print the contents of jaggedArray
            //for (var a = 0; a < jaggedArray.Length; a++)
            //{
            //    for (var i = 0; i < 2; i++)
            //        for (var j = 0; j < 2; j++)
            //            Console.WriteLine("jaggedArray[" + a + "][" + i + "," + j + "] has a value of " + jaggedArray[a][i, j]);
            //}

            //*********** End Focus Area 5 ***********//

        }

        /// <summary>
        /// Load XNA/MonoGame content here
        /// </summary>
        /// <param name="contentManager">The single instance of ContentManager used in the game</param>
        /// <param name="graphics">The single instance of GraphicsDevice used in the game</param>
        public override void LoadContent()
        {
            // Load sprite textures
            _spriteTextureOne.LoadContent(_contentManager);
            _spriteTextureTwo.LoadContent(_contentManager);

            // Set sprite textures
            _spriteOne.SetSpriteTexture(_spriteTextureOne);
            _spriteTwo.SetSpriteTexture(_spriteTextureTwo);
        }

        /// <summary>
        /// Main rendering code executed here
        /// </summary>
        public override void Render()
        {
            _spriteManager.RenderSprites(_graphicsDevice, DefaultCamera);
        }
    }
}
