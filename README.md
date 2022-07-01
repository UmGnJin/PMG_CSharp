# PMG_CSharp
Procedual Map Generation Project


#Note
Cellular Automata(CA)
- Generate map with random 0 or 1(floor and wall).
- Make map smoother
  - Rule
  - Select a tile.
  - Get neighbor tile info(wall or floor). Neighbor tile = 8 dir tiles.
    - Replacing example
    - If 5 or more neighbor tiles are wall, replace the selected tile to wall.
    - Else if 3 or less neighbor tiles are wall, replace the selected tile to floor.
- Map smoothing can be repeated as needed.

To-do list
- 각 수치별 조정을 통해 각각의 변화가 바닥/전체 타일 비율에 미치는 영향을 기록한다.
- 다른 smoothing 방법(ex-이웃 기준 변경)을 시험해 본다.
- 기존 코드에서 runtime을 줄일 수 있도록 최적화하고, 다른 방식의 CA와 비교한다.
- CA 프로젝트를 해당 프로젝트에 병합한다.
- 레벨의 각 구역을 구분하는 알고리즘 적용해 보기(ex - flood fill)


https://www.researchgate.net/publication/228919622_Cellular_automata_for_real-time_generation_of
