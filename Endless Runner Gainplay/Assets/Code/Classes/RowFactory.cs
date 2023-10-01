using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Enums;
using Random = UnityEngine.Random;

public class RowFactory
{
    //Random random = new Random();
    /*
    public Row CreateRow()
    {
        List<BaseBlockData> blocks = new List<BaseBlockData>();

        for(int i  = 0; i < 25; i++)
        {
            if(generateRandomNumber(100) > 35)
            {
                CreateBlock(BlockType.PowerUp, i);
            }
            else
            {
                CreateBlock(BlockType.Obstacle, i);
            }
        }

        Row newRow = new Row();
        return newRow;
    }

    private BaseBlockData CreateBlock(BlockType type, int objPosition)
    {
        BaseBlockData block = new BaseBlockData();

        switch (type)
        {
            case BlockType.PowerUp:
                
                return block;

            case BlockType.Obstacle:
                //destroys all obstacles visible in lane
                return block;
     
        }
        return null;
    }*/

    /*private BlockColor GenerateBlockColor()
    {
        
    }*/

    private int generateRandomNumber(int value)
    {
        int randomNr = Random.Range(0, value);
        return randomNr;
    }

    public enum BlockType
    {
        PowerUp,
        Obstacle
    }
}
