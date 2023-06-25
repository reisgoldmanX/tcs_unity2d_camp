using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    int jump_power = 35;
    public Rigidbody2D player_physics;
    public int coin_count = 0;
    private bool canJump;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        canJump = true;
        // Use tags to achieve the same thing for coins



    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        canJump = false;   
    }

    void start()
    {

    }

    void Update()
    {
        bool rightKey = Input.GetKey(KeyCode.RightArrow);
        bool leftKey = Input.GetKey(KeyCode.LeftArrow);
        bool spaceKey = Input.GetKey(KeyCode.Space);

        if (rightKey)
        {
            player_physics.AddForce(Vector2.right, ForceMode2D.Impulse);
        }

        if (leftKey)
        {
            player_physics.AddForce(Vector2.left, ForceMode2D.Impulse);
        }

        if (spaceKey && canJump)
        {
            player_physics.AddForce(Vector2.up * jump_power, ForceMode2D.Impulse);
        }

 
    }
}
