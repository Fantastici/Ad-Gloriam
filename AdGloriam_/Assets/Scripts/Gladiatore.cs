using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gladiatore : MonoBehaviour
{
    public float jumpForce;
    private Rigidbody2D rb;
    public bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    public Animator animator;
    public bool IsJumping;
    public bool doubleAllowed = false;
    public bool isDead = false;
    public bool IsAttacking;
   //private ScoreManager theScoreManager;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        //theScoreManager = FindObjectOfType<ScoreManager>();

    }
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
    }
    void Update()
    {
        if (isGrounded)
        {
            doubleAllowed = true;
        }
        if (isGrounded == true && Input.GetButtonDown("jump"))
        {
            Jump();
        }else if(doubleAllowed && Input.GetButtonDown("jump"))
        {
            Jump();
            doubleAllowed = false;
        }
        AttackInput();
        HandleAttacks();
        resetValues();
        

        RunAnimations();
    }
    public void Die()
    {
        isDead = true;
        FindObjectOfType<marmoScript>().SetVelocity(0,0);
        FindObjectOfType<bgScript>().SetVelocity(0, 0);
       // FindObjectOfType<column>().SetVelocity();
        animator.SetTrigger("Dead");
        
        //theScoreManager.scoreIncreasing = false;
    }
    /*public IEnumerator pausa(float x)
    {
        yield return new WaitForSeconds(x);
    }*/
    public  bool IsDead()
    {
        if (isDead)
        {
            return true;
        } else
            return false;

    }
    void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
    }
    void AttackInput()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            IsAttacking = true;

        }
    }
   
    void HandleAttacks()
    {
        if (IsAttacking)
        {
            animator.SetTrigger("Attack");
            AttackSound.Attack();


        }
    }
    public void Damage()
    {
        animator.SetTrigger("Hurt");
        
    }
    void resetValues()
    {
        IsAttacking = false;
    }
    void RunAnimations()
    {
        /*
        private void OnTriggerEnter2D(Collider2D other)
        {
            FindObjectOfType<LifeCount>().LoseLife();
        }
        */
        if (rb.velocity.y > 0)
        {
            animator.SetBool("IsJumping", true);
        }
        if (rb.velocity.y < 0)
        {
            animator.SetBool("IsJumping", false);
            animator.SetBool("IsFalling", true);
        }
        if (isGrounded == true)
        {
            animator.SetBool("IsFalling", false);
        }
        
       


    }
    /* public float speed = 5f;
     public float JumpForce = 1;
     private float horizontalmove = 0f;
     private Rigidbody2D rigidBody;
     public bool isGrounded = false;
     public bool IsJumping;
     public Animator animator;
     // Start is called before the first frame update
     void Start()
     {
         rigidBody = GetComponent<Rigidbody2D>();
         animator = GetComponent<Animator>();
     }

     // Update is called once per frame
     void Update()
     {
         horizontalmove = Input.GetAxis("Horizontal");
         rigidBody.velocity = new Vector2(horizontalmove * speed, rigidBody.velocity.y);
         if (horizontalmove < 0)
         {
             transform.eulerAngles = new Vector3(0, 180, 0);

         }
         else if (horizontalmove > 0)
         {
             transform.eulerAngles = new Vector3(0, 0, 0);

         }
         if (Input.GetButtonDown("jump") && Mathf.Abs(rigidBody.velocity.y) < 0.001f)
         {
             rigidBody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
         }

         RunAnimations();
     }

     void RunAnimations()
     {
         animator.SetFloat("Running", Mathf.Abs(horizontalmove));
         animator.SetBool("IsJumping", IsJumping);
     }*/
}

