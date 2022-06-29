using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PMG.Generator;
using System;

namespace PMG
{
    public class MapPrinter : MonoBehaviour
    {
        public MapGenerator mg;

        public GameObject[] Tiles;

        void Start()
        {
            Tiles = Resources.LoadAll<GameObject>("prefabs/Tiles");

            mg = new SquareMapGenerator();
            mg.SetMapSize(30, 30);
            mg.Generate();



            PrintMap();
        }

        void Update()
        {
                
        }

        public void PrintMap()
        {
            for(int i = 0;i < mg.height;i++)
            {
                for(int j = 0;j < mg.width;j++)
                {
                    GameObject tileObject;
                    switch (mg.map[i, j])
                    {
                        case Terrain.GROUND:
                            Debug.Log("Visualizing Tile (" + i + ", " + j + ").");
                            tileObject = Tiles[Array.FindIndex(Tiles, t => t.name == "FloorTile")];
                            break;
                        default:
                            tileObject = Tiles[Array.FindIndex(Tiles, t => t.name == "FloorTile")];
                            break;

                    
                    }
                    GameObject newTile = Instantiate(tileObject, new Vector2(j, -i), Quaternion.identity) as GameObject;
                    newTile.transform.SetParent(this.transform, false);

                }
            }
        }
    }
}