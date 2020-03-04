﻿namespace AirForce
{
    internal class ChaserShip : Ship
    {
        public ChaserShip(int positionX, int positionY)
        {
            PositionX = positionX;
            PositionY = positionY;
            Health = 1;
            Size = 80;
        }

        public bool IsIntersection(int positionX, int positionY, int size)
        {
            return GetDistanceToObject(positionX, positionY) <= (Size + size) / 2;
        }

        public void TakeDamage<T>()
        {
            switch (typeof(T).ToString())
            {
                case "AirForce.PlayerShip":
                    DestroyShip();
                    break;
                case "AirForce.Ground":
                case "AirForce.Meteor":
                    DestroyShip();
                    break;
            }
        }
    }
}