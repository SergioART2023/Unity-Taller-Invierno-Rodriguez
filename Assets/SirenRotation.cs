using UnityEngine;

public class SirenRotation : MonoBehaviour
{
    public float rotationSpeed = 180f; 

    void Update()
    {
        float angle = rotationSpeed * Time.deltaTime;

        
        foreach (Transform light in transform)
        {
            light.Rotate(0f, angle, 0f, Space.Self);
        }
    }
}