﻿using System.Drawing;
using System.IO;
using BruTileMap;

namespace BruTileDemo
{
    class TileFactory : ITileFactory<Bitmap>
    {
        #region ITileFactory<Bitmap> Members

        public Bitmap GetTile(byte[] bytes)
        {
            return new Bitmap(new MemoryStream(bytes));
        }

        #endregion
    }
}