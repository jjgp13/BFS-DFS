using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickDFS : MonoBehaviour {

    public GameObject controller;

    void OnMouseDown()
    {
        StartCoroutine (controller.GetComponent<bfsAlgorithm>().dfs());
    }
}
