using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocity;
    bool _alive;
    Rigidbody2D _rb;

    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
        _alive = true;
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && _alive) 
        {
            _rb.velocity = Vector2.up * velocity;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        _alive = false;
    }
}