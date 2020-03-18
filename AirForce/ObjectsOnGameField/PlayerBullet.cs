﻿using System.Collections.Generic;

namespace AirForce
{
    internal class PlayerBullet : GameObject
    {
        public PlayerBullet(int positionX, int positionY)
        {
            ObjectType = ObjectType.PlayerBullet;
            Bitmap = Properties.Resources.PlayerBullet;
            PositionX = positionX;
            PositionY = positionY;
            Health = 1;
            Size = 14;
        }

        public override void Move(List<GameObject> gameObjects, out List<GameObject> createdObjects)
        {
            createdObjects = new List<GameObject>();
            PositionX += 8;
        }
    }
}
