using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newTile : MonoBehaviour {

    Material transparent;

    public void colorRender(GameObject cube)
    {
        Renderer cubeRend = cube.GetComponent<Renderer>();
        cubeRend.material = transparent;
        cube.AddComponent<OnMouseOverColor>();
    }

    public GameObject createTile()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.localScale = new Vector3(1, 0.1f, 1);
        return cube;
    }

    void Start()
    {
        transparent = Resources.Load("transparent", typeof(Material)) as Material;

        //Tile 1
        GameObject cube = createTile();
        cube.transform.position = new Vector3(0, 0, 0);
        colorRender(cube);

        //Tile 2
        GameObject cube2 = createTile();
        cube2.transform.position = new Vector3(1, 0, 0);
        colorRender(cube2);

        //Tile 3
        GameObject cube3 = createTile();
        cube3.transform.position = new Vector3(2, 0, 0);
        colorRender(cube3);

        //Tile 4
        GameObject cube4 = createTile();
        cube4.transform.position = new Vector3(-1, 0, 0);
        colorRender(cube4);

        //Tile 5
        GameObject cube5 = createTile();
        cube5.transform.position = new Vector3(-2, 0, 0);
        colorRender(cube5);

        //Tile 6
        GameObject cube6 = createTile();
        cube6.transform.position = new Vector3(-1, 0, -1);
        colorRender(cube6);

        //Tile 7
        GameObject cube7 = createTile();
        cube7.transform.position = new Vector3(0, 0, -1);
        colorRender(cube7);

        //Tile 13
        GameObject cube13 = createTile();
        cube13.transform.position = new Vector3(-2, 0, -1);
        colorRender(cube13);

        //Tile 8
        GameObject cube8 = createTile();
        cube8.transform.position = new Vector3(1, 0, -1);
        colorRender(cube8);

        //Tile 12
        GameObject cube12 = createTile();
        cube12.transform.position = new Vector3(2, 0, -1);
        colorRender(cube12);

        //Tile 9
        GameObject cube9 = createTile();
        cube9.transform.position = new Vector3(-1, 0, 1);
        colorRender(cube9);

        //Tile 10
        GameObject cube10 = createTile();
        cube10.transform.position = new Vector3(0, 0, 1);
        colorRender(cube10);

        //Tile 11
        GameObject cube11 = createTile();
        cube11.transform.position = new Vector3(1, 0, 1);
        colorRender(cube11);

        //Tile 14
        GameObject cube14 = createTile();
        cube14.transform.position = new Vector3(2, 0, 1);
        colorRender(cube14);

        //Tile 15
        GameObject cube15 = createTile();
        cube15.transform.position = new Vector3(-2, 0, 1);
        colorRender(cube15);

        //Tile 16
        GameObject cube16 = createTile();
        cube16.transform.position = new Vector3(-2, 0, 2);
        colorRender(cube16);

        //Tile 17
        GameObject cube17 = createTile();
        cube17.transform.position = new Vector3(-1, 0, 2);
        colorRender(cube17);

        //Tile 18
        GameObject cube18 = createTile();
        cube18.transform.position = new Vector3(0, 0, 2);
        colorRender(cube18);

        //Tile 19
        GameObject cube19 = createTile();
        cube19.transform.position = new Vector3(1, 0, 2);
        colorRender(cube19);

        //Tile 20
        GameObject cube20 = createTile();
        cube20.transform.position = new Vector3(2, 0, 2);
        colorRender(cube20);

        //Tile 21
        GameObject cube21 = createTile();
        cube21.transform.position = new Vector3(-2, 0, -2);
        colorRender(cube21);

        //Tile 22
        GameObject cube22 = createTile();
        cube22.transform.position = new Vector3(-1, 0, -2);
        colorRender(cube22);

        //Tile 23
        GameObject cube23 = createTile();
        cube23.transform.position = new Vector3(0, 0, -2);
        colorRender(cube23);

        //Tile 24
        GameObject cube24 = createTile();
        cube24.transform.position = new Vector3(1, 0, -2);
        colorRender(cube24);

        //Tile 25
        GameObject cube25 = createTile();
        cube25.transform.position = new Vector3(2, 0, -2);
        colorRender(cube25);


        //cube.GetComponent<Renderer>().material.color = new Color(255,0,255);
        //cube.GetComponent<Renderer>().
        cube.AddComponent<OnMouseOverColor>();


    }

}
