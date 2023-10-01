using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums : MonoBehaviour
{
    public enum PowerUpType
    {
        Green,      //adds a new lane
        Red         //destroys all obstacles visible in lane
    }

    public enum ObstacleType
    {
        Grey,       //neutral obstacle (does nothing except block)
        Orange,     //randomly moves to another adjacent lane at the moment the player moves to another lane
        Blue        //moves in a predictable pattern
    }

    public enum BlockColor
    {
        //Power Ups
        Green,      //adds a new lane
        Red,        //destroys all obstacles visible in lane

        //Obstacles
        Grey,       //neutral obstacle (does nothing except block)
        Orange,     //randomly moves to another adjacent lane at the moment the player moves to another lane
        Blue        //moves in a predictable pattern
    }
}
