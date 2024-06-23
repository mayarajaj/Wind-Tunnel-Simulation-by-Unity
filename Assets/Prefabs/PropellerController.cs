using UnityEngine;

public class RotateAroundPivot : MonoBehaviour
{
    public Transform pivotPoint;  // Reference to the pivot point GameObject
    public Vector3 rotationAxis = Vector3.up;  // Axis around which to rotate (default: up axis)
    public float rotationSpeed = 30f;  // Rotation speed in degrees per second

    void Update()
    {
        // Calculate rotation amount based on time and speed
        float rotationAmount = rotationSpeed * Time.deltaTime;

        // Rotate around the pivot point
        transform.RotateAround(pivotPoint.position, rotationAxis, rotationAmount);
    }
}
