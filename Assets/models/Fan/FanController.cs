using UnityEngine;

public class FanController : MonoBehaviour
{
    public float rotationSpeed = 100f; 

    void Update()
    {
    
        
           transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);

    }
}
