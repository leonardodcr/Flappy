using UnityEngine;

public class WallMovement : MonoBehaviour
{
    bool _collided;
    Rigidbody2D _rb;

    void Start()
    {
        _collided = false;
        _rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector3(transform.position.x, Random.Range(-1.5f, 1.5f), transform.position.z);
        Destroy(gameObject, 5.0f);
        
        /*
        function Start () {
            Invoke("DestroyMe", 10.0);
        }
        
        function BlahWhatever () {
            if (somethingHappens) {
                CancelInvoke("DestroyMe");
            }
        }
        
        function DestroyMe () {
            Destroy(gameObject);
        }
        */
    }

    void Update()
    {
        // if (collided) {
        //     rb.velocity = Vector2.zero;
        //     return;
        // }

        _rb.velocity = Vector2.left * 6;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        _collided = true;
    }
}
