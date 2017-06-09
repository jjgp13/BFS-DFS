using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour {

    public GameObject controller;

    void OnMouseDown()
    {
        StartCoroutine (controller.GetComponent<bfsAlgorithm>().bfs());
    }
}
