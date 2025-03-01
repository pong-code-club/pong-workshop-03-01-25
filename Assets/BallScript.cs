using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour
{
    public Rigidbody MyRigidbody;
    public int blahblaksdhlbkjsdalkjblka;
    public Vector3 BallStartVelocity;
    public float BallStartSpeed;
    public ScoreScript MyScoreScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //MyRigidbody.AddForce(new Vector3(300, 300, 0));
        MyRigidbody.AddForce(new Vector3(BallStartSpeed, BallStartSpeed, 0));
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Lava")
        {
            SceneManager.LoadScene("pong-level-game-objects");
        }
        if (collision.gameObject.name == "Wall")
        {
            MyScoreScript.AddToScore();
        }
    }
}
