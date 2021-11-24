using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static bool alive;
    public float velocity;
    Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        alive = true;
    }

    void Update()
    {
        if (alive && (_rb.position.y < -6 || _rb.position.y > 6))
        {
            KillPlayer();
        }

        if ((Input.GetButtonDown("Jump") || PhoneJumpInput()) && alive) 
        {
            _rb.velocity = Vector2.up * velocity;
        }
    }

    bool PhoneJumpInput()
    {
        return Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began;
    }

    void KillPlayer()
    {
        alive = false;
        ScoreKeeper.gameOver = true;
        Destroy(gameObject, 5f);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        KillPlayer();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        ScoreKeeper.scoreValue++;
    }
}