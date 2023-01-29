using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chao : MonoBehaviour
{

    personagem Player;



    void Start()
    {
        Player = gameObject.transform.parent.gameObject.GetComponent<personagem>();
    }
    
    void OnCollisionEnter2D(Collision2D collisor)
    {
        if (collisor.gameObject.layer == 6)
        {
            Player.IsJumping = false;
        }
    }
    void OnCollisionExit2D(Collision2D collisor)
    {
        if (collisor.gameObject.layer == 6)
        {
            Player.IsJumping = true;
        }
    }
}
