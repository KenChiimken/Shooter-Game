using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    //Player Speed
    public float moveSpeed;
    //rigidBody
    public Rigidbody2D rigidBody;
    //how the player moves
    private Vector3 movementInput;
    //Access Animator to play animations
    public int healthPoints;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        //anim.setfloat("horizontal", movementinput.x);
       // anim.setfloat("vertical", movementinput.y);
        //anim.setfloat("speed", movementinput.sqrmagnitude);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        //{
        //    anim.enabled= true;
        //    anim.SetTrigger("BackwardAnimation");
        //}
        //if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        //{
        //    anim.SetTrigger("ForwardAnimation");
        //    anim.enabled = true;
        //}
        //if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    anim.enabled = true;
        //    anim.SetTrigger("LeftAnimation");
        //}
      //  if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    anim.enabled = true;
        //    anim.SetTrigger("RightAnimation");
        //}
        //if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.W))
        //{
        //    anim.enabled= false;
        //}


    }

    private void FixedUpdate()
    {
        rigidBody.velocity = movementInput * moveSpeed;
    }

    //InputSystem Clicks
    private void OnMove(InputValue inputValue)
    {
        movementInput = inputValue.Get<Vector3>();


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        }
    }

