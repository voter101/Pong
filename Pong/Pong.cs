#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
using Pong.Ball;
using Pong.Players;
using System.Timers;
#endregion

namespace Pong
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Pong : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D background;
        Texture2D[] score = new Texture2D[6];
        Texture2D[] whoWon = new Texture2D[2];

        float playerSpeed = 8.0f;

        KeyboardState currKeyboard;

        Player left;
        Player right;
        private Overseer overseer;

        BallObject ball;

        public Pong(Player left, Player right, BallObject ball) : base()
        {
            this.left = left;
            this.right = right;
            this.ball = ball;
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            graphics.PreferredBackBufferWidth = 960;
            graphics.PreferredBackBufferHeight = 800;
            graphics.ApplyChanges();
            Vector2 ballPosition = new Vector2(GraphicsDevice.Viewport.TitleSafeArea.X + GraphicsDevice.Viewport.TitleSafeArea.Width / 2, GraphicsDevice.Viewport.TitleSafeArea.Y + GraphicsDevice.Viewport.TitleSafeArea.Height / 2);
            ball.SetStartingParams(ballPosition);
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            ball.loadTextures(Content.Load<Texture2D>("Graphics\\ball"));
            left.loadTextures(Content.Load<Texture2D>("Graphics\\lPaddle"));
            right.loadTextures(Content.Load<Texture2D>("Graphics\\rPaddle"));
            background = Content.Load<Texture2D>("Graphics\\board");
            for (int i = 0; i < 6; i++)
                score[i] = Content.Load<Texture2D>("Graphics\\"+i);
            whoWon[0] = Content.Load<Texture2D>("Graphics\\leftWon");
            whoWon[1] = Content.Load<Texture2D>("Graphics\\rightWon");
            
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            if (left.score < 5 && right.score < 5)
            {
                currKeyboard = Keyboard.GetState();

                HumanPlayer player = (left is HumanPlayer ? (HumanPlayer)left : null);
                if (player != null && currKeyboard.IsKeyDown(player.DownKey))
                    player.position.Y += playerSpeed;

                if (player != null && currKeyboard.IsKeyDown(player.UpKey))
                    player.position.Y -= playerSpeed;

                player = (right is HumanPlayer ? (HumanPlayer)right : null);
                if (player != null && currKeyboard.IsKeyDown(player.DownKey))
                    player.position.Y += playerSpeed;

                if (player != null && currKeyboard.IsKeyDown(player.UpKey))
                    player.position.Y -= playerSpeed;

                if (currKeyboard.IsKeyDown(Keys.R))
                {
                    ball.reset();
                }


                base.Update(gameTime);
            }
            else
            {
                ball.stop();
            }
                
        }

        private void endGame(object sender, ElapsedEventArgs e)
        {
            Exit();
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            // TODO: Add your drawing code here
            spriteBatch.Draw(background, Vector2.Zero, Color.White);
            spriteBatch.Draw(score[left.score], new Rectangle(350, 70, 50, 80), Color.White);
            spriteBatch.Draw(score[right.score], new Rectangle(560, 70, 50, 80), Color.White);
            ball.updateBall(spriteBatch);
            left.updatePlayer(spriteBatch);
            right.updatePlayer(spriteBatch);

            if (left.score == 5)
                spriteBatch.Draw(whoWon[0], new Vector2(240,330), Color.White);
            if (right.score == 5)
                spriteBatch.Draw(whoWon[1], new Vector2(240, 330), Color.White);

            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
