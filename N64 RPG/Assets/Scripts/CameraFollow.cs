using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject protagonist_2;
    public Vector3 offset;

    void Start()
    {
        protagonist_2 = GameObject.Find("protagonist_2");
        // Debug.Log(protagonist_2.transform.position);
        offset = transform.position - protagonist_2.transform.position;
        // Debug.Log(offset);
    }

    void Update()
    {
        transform.position = protagonist_2.transform.position + offset;
    }
}
