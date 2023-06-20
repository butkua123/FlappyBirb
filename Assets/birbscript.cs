using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birbscript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public LogicScript logic;
    public float flapStrength;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {  
            myRigidBody.velocity = Vector2.up * flapStrength;
        } 

        if (transform.position.y > 16.5 || transform.position.y < -17)
        {
            logic.gameOver();
            birdIsAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
