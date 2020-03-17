﻿using System.Collections.Generic;

namespace AirForce
{
    internal class Ground : ObjectOnGameField
    {
        public int Width { get; }
        public int Height { get; }

        public Ground()
        {
            ObjectType = ObjectType.Ground;
            Bitmap = Properties.Resources.Ground;
            PositionX = 0;
            PositionY = 750;
            Health = 1000;
            Size = 0;
            Width = 1550;
            Height = 100;
        }

        public override void Move(List<ObjectOnGameField> objectOnGameFieldsList, out List<ObjectOnGameField> createdObjectsList)
        {
            createdObjectsList = new List<ObjectOnGameField>();
        }
    }
}