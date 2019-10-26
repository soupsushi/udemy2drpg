using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public Rigidbody2D theRB;
    public float moveSpeed;
    public Animator myAni;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * moveSpeed;

        myAni.SetFloat("moveX", theRB.velocity.x);
        myAni.SetFloat("moveY", theRB.velocity.y); 

        if(Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 ||
           Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            myAni.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
            myAni.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
        }

    }
}
