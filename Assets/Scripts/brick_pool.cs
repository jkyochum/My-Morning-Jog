using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brick_pool : MonoBehaviour {

    //array size
    public int colPoolSize = 10;
    //object to instantiate
    public GameObject columnPrefab;
    //how often to instantiate object
    public float spawnRate = 4f;
    //random positions along y-axis to position column
    public float colMin = -1f;
    public float colMax = 3.5f;

    //array of columns
    private GameObject[] columns;
    //how much time has passed since object spawn
    private float timeSinceLastSpawn;
    //position offscreen where prefab will spawn
    private Vector2 objPoolPos = new Vector2(-10f, 0f);
    //fixed position where columns instantiate
    private float spawnXPosition = 10f;
    //keeping track of which column is active
    private int currentCol = 0;

	// Use this for initialization
	void Start () {
        //making new array of empty game objects with 10 empty spaces
        columns = new GameObject[colPoolSize];

        for (int i = 0; i < colPoolSize; i++)
        {
            //for each available slot           what to spawn, where to spawn
            columns[i] = (GameObject)Instantiate(columnPrefab, objPoolPos, Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
        //adding the time since last spawn to current timer
        timeSinceLastSpawn += Time.deltaTime;

        //if the game is active                 //and time since last spawn is greater than 4 seconds
        if(game_controller.instance.gameOver == false && timeSinceLastSpawn>=spawnRate)
        {
            //reset timer
            timeSinceLastSpawn = 0;
            //creating random position for y-axis
            float spawnYPosition = Random.Range(colMin, colMax);

            //current column from the array position position
            columns[currentCol].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            //incrementing the array
            currentCol++;
            if(currentCol>=colPoolSize)
            {
                //if array is inccremented over MAX then start over
                currentCol = 0;
            }
        }
	}
}
