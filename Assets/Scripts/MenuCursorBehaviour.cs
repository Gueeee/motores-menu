using UnityEngine;
using UnityEngine.Events;
using System;

public class MenuCursorBehaviour : MonoBehaviour
{
    public GameObject currentSelectedGameObject;
    public Transform target;
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = currentSelectedGameObject.transform;
    }

    void Update(){
        if (target != null)
        {
            Vector3 newPosition = transform.position;
            newPosition.y = target.position.y;

            transform.position = newPosition;
        }
    } 
}
