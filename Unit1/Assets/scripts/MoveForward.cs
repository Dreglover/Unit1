using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePl : MonoBehaviour
{
    [SerializeField] private float speed = 40.0f;
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);  
    }
}