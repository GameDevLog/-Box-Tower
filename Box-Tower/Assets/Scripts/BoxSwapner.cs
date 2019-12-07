using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSwapner : MonoBehaviour
{
    public GameObject boxPrefabs;

    public void SpawnBox()
    {
        GameObject boxObject = Instantiate(boxPrefabs);

        boxObject.transform.position = transform.position;
    }
}
