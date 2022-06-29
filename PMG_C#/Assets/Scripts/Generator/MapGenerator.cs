using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PMG.Generator
{
    public abstract class MapGenerator // 각 방식별 레벨 생성기의 베이스.
    {
        public int[,] map;
        public int width, height, length;

        public void SetMapSize(int w, int h)// 이중 배열 특성상 [y, x]형태로 좌표 배열함.
        {
            width = w;
            height = h;
            length = width * height;
            map = new int[height, width];
        }
        public abstract void Generate();



    }

}