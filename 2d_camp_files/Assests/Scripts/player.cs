using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class player : MonoBehaviour
{
    private int jump_power = 35;
    public Rigidbody2D player_physics;
    public int coin_count = 0;
    private bool canJump;
    public TextMeshProGUI coin_text;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            canJump = true;
        }
        // Use tags to achieve the same thing for coins

        if (collision.gameObject.CompareTag("Enemy"))
        {
            // kill
            player_physics.AddForce(Vector2.up * 999, ForceMode2D.Impulse);
            coin_count = 0;
            
        }
        if (collision.gameObject.CompareTagI("coin"))
        {
            coin_count++;
            Destroy(collision.gameObject);
            
        }

        if (collision.gameObject.CompareTag("slow"))
        {
            // to be implmented
        }


    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        canJump = false;
        coin_text.text = "Coin: " + coin_count.ToString();
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
