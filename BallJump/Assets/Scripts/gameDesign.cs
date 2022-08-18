using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameDesign : MonoBehaviour
{
    public GameObject platformPrefab;
    int numPlatform;
    // Start is called before the first frame update
    void Start()
    {
        numPlatform = 200;
        generateLevel(); 
    }

    void generateLevel()
    {
        Vector2 platformVector = new Vector2();
        for(int i=0;i<numPlatform; i++)
        {
            GameObject tempPlatform = Instantiate(platformPrefab);
            platformVector.x = Random.RandomRange(-1.5f, 1.5f);
            platformVector.y += 2f;
            tempPlatform.transform.position = platformVector;

        }
    } 
}
