using UnityEngine;

public class PipeManager : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 2.5f;
    [SerializeField] private float accelerationAddon = 1f;
    [SerializeField] private float maximumMovementSpeed = 10.0f;
    private void Update()
    {
        transform.position += Vector3.left * movementSpeed * Time.deltaTime;
        movementSpeed += accelerationAddon * Time.deltaTime;
        if (movementSpeed > maximumMovementSpeed)
        {
            movementSpeed = maximumMovementSpeed;
        }
    }
}
