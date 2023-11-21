﻿using Library;
using System;

namespace Lab_rab_3
{
    public abstract class MazeGame
    {
        public Maze Create()
        {
            Maze maze = CreateMaze();

            Room room1 = CreateRoom(1);

            Room room2 = CreateRoom(2);

            Door door = CreateDoor(room1, room2);

            room1.SetSide(Direction.North, new Wall());
            room1.SetSide(Direction.East, door);
            room1.SetSide(Direction.South, new Wall());
            room1.SetSide(Direction.West, new Wall());

            room2.SetSide(Direction.North, new Wall());
            room2.SetSide(Direction.East, new Wall());
            room2.SetSide(Direction.South, new Wall());
            room2.SetSide(Direction.West, door);

            maze.AddRoom(room1);
            maze.AddRoom(room2);

            return maze;
        }

        public virtual Room CreateRoom(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), number, "Число должно быть положительным.");
            }

            if (number == null)
            {
                throw new ArgumentNullException(nameof(number));
            }
            Room room = new Room(number);

            return room;
        }

        public virtual Door CreateDoor(Room room1, Room room2)
        {
            if (room1 == null)
            {
                throw new ArgumentNullException(nameof(room1));
            }

            if (room2 == null)
            {
                throw new ArgumentNullException(nameof(room2));
            }

            return new Door(room1, room2);
        }

        public virtual Wall CreateWall()
        {
            return new Wall();
        }

        public virtual Maze CreateMaze()
        {
            return new Maze();
        }
    }
}
