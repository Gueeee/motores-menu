using UnityEngine;
using UnityEngine.UI;

public class MenuCursorBehaviour : MonoBehaviour
{
    public Transform target; // Assign the target object in the Inspector
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Return)) {
            Debug.Log("Enter");
        }
        if (target != null)
        {
            Vector3 newPosition = transform.position;
            newPosition.y = target.position.y;
            transform.position = newPosition;
        }
    }
}
