using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSwapner : MonoBehaviour
{
    public GameObject boxPrefabs;

    void Start()
    {
        SwapBox();
    }

    public void SwapBox()
    {
        GameObject boxObject = Instantiate(boxPrefabs);

        boxObject.transform.position = transform.position;
    }
}
