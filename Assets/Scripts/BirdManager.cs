using UnityEngine;
public class BirdManager : MonoBehaviour
{
    private float velocity = 150f;
    new Rigidbody2D rigidbody2D;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.touchCount > 0 || Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.velocity = Vector3.zero;
            rigidbody2D.AddForce(Vector3.up * velocity);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pipe") || other.CompareTag("Ground"))
        {
            GameManager.isBirdDead = true;
        }

        if (other.CompareTag("Score"))
        {
            GameManager.playerScore++;
        }
    }

}