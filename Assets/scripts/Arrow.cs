using UnityEngine;

public class Arrow : MonoBehaviour
{
    [SerializeField] private float speed;

    public void launch (Vector2 direction)
    {
        GetComponent<Rigidbody2D>().linearVelocity = direction * speed;
    }

    private void OnCollisionEnter2D()
    {
        Destroy(gameObject);
    }

}
