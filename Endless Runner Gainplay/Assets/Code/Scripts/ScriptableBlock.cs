using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Enums;

[CreateAssetMenu(fileName = "New Block", menuName = "Block")]
public class ScriptableBlock : ScriptableObject
{
    public Material material;
    public Vector3 position;
    public BlockColor blockColor;

    public ScriptableBlock()
    {
        //GameObject.material = material??
        //transform.position = position
        //blockColor = blockColor
    }

    public void HandleCollision(GameObject other)
    {
        Debug.Log("Block Collision with: " + other.name);

        // Add collision behavior based on blockColor
        switch (blockColor)
        {
            case BlockColor.Green:
                //adds a new lane
                break;

            case BlockColor.Red:
                //destroys all obstacles visible in lane
                break;

            case BlockColor.Grey:
                //neutral obstacle (does nothing except block)
                break;

            case BlockColor.Orange:
                //randomly moves to another adjacent lane at the moment the player moves to another lane
                break;

            case BlockColor.Blue:
                //moves in a predictable pattern
                break;


            default:
                // Default collision behavior
                break;
        }
    }
}
