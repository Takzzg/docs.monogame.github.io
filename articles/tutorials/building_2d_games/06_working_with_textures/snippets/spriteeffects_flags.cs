protected override void Draw(GameTime gameTime)
{
    // Clear the back buffer.
    GraphicsDevice.Clear(Color.CornflowerBlue);

    // Begin the sprite batch to prepare for rendering.
    SpriteBatch.Begin();

    // Draw the texture.
    SpriteBatch.Draw(
        _logo,                              // texture
        new Vector2(                        // position
            Window.ClientBounds.Width,
            Window.ClientBounds.Height) * 0.5f,
        null,                               // sourceRectangle
        Color.White,                        // color
        0.0f,                               // rotation
        new Vector2(                        // origin
            _logo.Width,
            _logo.Height) * 0.5f,
        1.0f,                               // scale
        SpriteEffects.FlipHorizontally |    // effects
        SpriteEffects.FlipVertically,
        0.0f                                // layerDepth
    );

    // Always end the sprite batch when finished.
    SpriteBatch.End();

    base.Draw(gameTime);
}