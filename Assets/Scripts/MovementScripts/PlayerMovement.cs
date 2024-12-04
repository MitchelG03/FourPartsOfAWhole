using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool facingRight;
    public float moveSpeed = 6;

    public bool jump = false;
    public float jumpForce = 400;
    public bool isJumping = false;
    public globalsBehavior globalsBehavior;

    public Animator myAnimatorFire;
    public Animator myAnimatorWater;
    public Animator myAnimatorEarth;
    public Animator myAnimatorWind;

    private Rigidbody2D myRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isJumping == false)
        {
            HandleInput();
            if (Input.GetKeyDown(KeyCode.K))
            {
                globalsBehavior.spawnPoint.transform.position = transform.position;
                Debug.Log("SpawnSet");
            }
        }
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        HandleMovement(horizontal);
        Flip(horizontal);
        Resete();
    }

    void HandleMovement(float horizontal)
    {
        myRigidBody.velocity = new Vector2(horizontal * moveSpeed,myRigidBody.velocity.y);

        if (jump == true)
        {
            myRigidBody.AddForce(new Vector2(0, jumpForce));
            myAnimatorFire.SetBool("isJumping", true);
            myAnimatorWater.SetBool("isJumping", true);
            myAnimatorEarth.SetBool("isJumping", true);
            myAnimatorWind.SetBool("isJumping", true);
        }
        myAnimatorFire.SetFloat("speed", Mathf.Abs(myRigidBody.velocity.x));
        myAnimatorWater.SetFloat("speed", Mathf.Abs(myRigidBody.velocity.x));
        myAnimatorEarth.SetFloat("speed", Mathf.Abs(myRigidBody.velocity.x));
        myAnimatorWind.SetFloat("speed", Mathf.Abs(myRigidBody.velocity.x));
    }

    void HandleInput()
    {
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            isJumping = true;
        }
    }

    public void Flip(float horizontal)
    {
        if (horizontal > 0 && facingRight || horizontal < 0 && !facingRight)
        {
            ChangeDirection();
        }
    }

    public void ChangeDirection()
    {
        facingRight = !facingRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
    void Resete()
    {
        jump = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Floor"))
        {
            isJumping = false;
            myAnimatorFire.SetBool("isJumping", false);
            myAnimatorWater.SetBool("isJumping", false);
            myAnimatorEarth.SetBool("isJumping", false);
            myAnimatorWind.SetBool("isJumping", false);
        }

        if (other.CompareTag("Dead"))
        {
            transform.position = globalsBehavior.spawnPoint.transform.position;
            globalsBehavior.fireCharged = false;
            globalsBehavior.waterCharged = false;
            globalsBehavior.earthCharged = false;
            globalsBehavior.windCharged = false;
        }
    }
}
