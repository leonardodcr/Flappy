using UnityEngine;

public class WallMovement : MonoBehaviour
{
    Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector3(transform.position.x, Random.Range(-1.5f, 1.5f), transform.position.z);
        Invoke("DestroyMe", 5.0f);
    }

    void Update()
    {
        if (PlayerMovement.alive)
        {
            _rb.velocity = Vector2.left * 6;
        }
        else if (IsInvoking("DestroyMe"))
        {
            _rb.velocity = Vector2.zero;
            CancelInvoke("DestroyMe");
        }
    }

    void DestroyMe()
    {
        Destroy(gameObject);
    }
}
