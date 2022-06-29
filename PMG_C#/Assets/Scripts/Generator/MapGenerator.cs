using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PMG.Generator
{
    public abstract class MapGenerator // �� ��ĺ� ���� �������� ���̽�.
    {
        public int[,] map;
        public int width, height, length;

        public void SetMapSize(int w, int h)// ���� �迭 Ư���� [y, x]���·� ��ǥ �迭��.
        {
            width = w;
            height = h;
            length = width * height;
            map = new int[height, width];
        }
        public abstract void Generate();



    }

}