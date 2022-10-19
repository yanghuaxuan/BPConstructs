using Terraria;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameInput;
using Microsoft.Xna.Framework;
using log4net;

namespace BPConstructs.Contents
{
    internal class BPContainerPanel : UIPanelPlus
    {
        Tile[,] tiles;
        Vector2 _thumbnailPos;
        ThumbnailImage thumbnail;

        public BPContainerPanel(Tile[,] _tiles)
        {
            Width.Set(100f, 0f);
            Height.Set(100f, 0f);
            tiles = _tiles;
            _thumbnailPos = new Vector2(0f, 0f);
            thumbnail = new ThumbnailImage(tiles, new Vector2(100, 100));
            this.Append(thumbnail);
        }

        public Vector2 thumbnailPos
        {
            get
            {
                return _thumbnailPos;
            }
            set
            {
                _thumbnailPos = value;
            }
        }

        // private void CreateThumbnail(Tile[,] tiles, Vector2 startPos, SpriteBatch sb)
        // {
        //     int thumbnailWidth = 100;
        //     int thumbnailHeight = 100;
        //     int tileWidth = tiles.GetLength(0);
        //     int tileHeight = tiles.GetLength(1);
        //     float scale = 1.0F;
        //     Vector2 offset = new Vector2();

        //     if (tileWidth > thumbnailWidth || tileHeight > thumbnailHeight)
        //     {
        //         if (tileHeight > tileWidth)
        //         {
        //             scale = (float)thumbnailWidth / tileHeight;
        //             offset.X = (thumbnailWidth - tileWidth * scale);
        //         }
        //         else
        //         {
        //             scale = (float)thumbnailWidth / tileWidth;
        //             offset.Y = (thumbnailHeight - tileHeight * scale) / 2;
        //         }
        //     }

        //     CopyModeUI.DrawPreview(sb, tiles, startPos, 0.2f);
        // }
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.End();
            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.LinearClamp, DepthStencilState.None, RasterizerState.CullCounterClockwise, null, Main.UIScaleMatrix);
            PlayerInput.SetZoom_UI();

            LogManager.GetLogger("BPConstructs").Info("Left Pixels: " + base.Left.Pixels);

            base.Draw(spriteBatch);

            spriteBatch.End();
            spriteBatch.Begin();
        }
    }
}
