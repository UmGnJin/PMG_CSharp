using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PMG.Generator
{
    public class SquareMapGenerator : MapGenerator
    {
        public override void Generate()
        {
            
            for(int i = 0;i < height;i++)
            {
                //Debug.Log(i);
                for(int j = 0;j < width;j++)
                {
                    //Debug.Log("Set Tile on " + i + ", " + j + ".");
                    map[i, j] = Terrain.GROUND;
                }
            }
        }
    }
}