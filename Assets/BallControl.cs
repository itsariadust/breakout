using UnityEngine;
using UnityEngine.SceneManagement;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D rb2d;
    void GoBall()
    {
        float rand = Random.Range(0, 2);
        if (rand < 1)
        {
            rb2d.AddForce(new Vector2(20, -15));
        }
        else
        {
            rb2d.AddForce(new Vector2(-20, -15));
        }
    }
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2);
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.CompareTag("Player"))
        {
            Vector2 vel;
            vel.x = (rb2d.velocity.x / 1) + (coll.collider.attachedRigidbody.velocity.x / 1);
            vel.y = (rb2d.velocity.y / 1) + (coll.collider.attachedRigidbody.velocity.y / 1);
            rb2d.velocity = vel;
        }
    }
    void ResetBall()
    {
        rb2d.velocity = Vector2.zero;
        transform.position = Vector2.down;
    }
    void RestartGame()
    {
        ResetBall();
        Invoke("GoBall", 1);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
