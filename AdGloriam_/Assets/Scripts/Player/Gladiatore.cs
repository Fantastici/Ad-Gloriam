using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gladiatore : MonoBehaviour
{
    private Vector2 screenBounds;
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
    public bool isColliso = false;
    private float speed=0;
    public bool IsShieldOn = false;
    public bool isOut=false;
    public bool isJump = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    
        

    }
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
    }
    void Update()
    {
       
        if (transform.position.x < screenBounds.x * -2)
        {

            isOut = true;
            
        }
        if (isGrounded)
        {
            doubleAllowed = true;
        }
        if (isGrounded == true && Input.GetButtonDown("jump"))
        {
            Jump();
            /*if (isColliso && rb.velocity.y > 0)
            {
                rb.AddForce(Vector3.right * 1, ForceMode2D.Impulse);
            }
            isColliso = false;*/

        }
        else if(doubleAllowed && Input.GetButtonDown("jump"))
        {
            Jump();
           /* if (isColliso && rb.velocity.y > 0)
            {
                rb.AddForce(Vector3.right * 1, ForceMode2D.Impulse);
            }
            isColliso = false;*/
            doubleAllowed = false;
        }
        
        
        AttackInput();
        HandleAttacks();
        resetValues();
        

        RunAnimations();
    }
    public bool IsOut()
    {
        return isOut;
    }
   /*public float getXiniziale()
    {
        return xIniziale;
    }
    public float getXcorrente()
    {
        return xCorrente;
    }*/
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
    public void setPlayerSpeed(float speed)
    {
        rb.velocity = new Vector2(speed, 0);
    }
    public  bool IsDead()
    {
        if (isDead)
        {
            return true;
        } else
            return false;

    }
    public void aumentaSpeed()
    {
        rb.AddForce(Vector3.right, ForceMode2D.Impulse);
    }
    void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
        
        
    }
   public void setJumpforceaZero()
    {
        jumpForce = 0;
    }
    void AttackInput()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            IsAttacking = true;

        }
    }

    public bool attacking()
    {
        if (IsAttacking)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
   
    void HandleAttacks()
    {
        if (IsAttacking)
        {
            animator.SetTrigger("Attack");
            AttackSound.Attack();
            if (isShieldOn())
            {
                animator.SetTrigger("ShieldOn");
            }


        }
    }
    /*public bool isCollisione()
    {
        return isColliso = true;
    }*/
    public void setShieldFalse()
    {
        IsShieldOn = false;
    }
    public bool isShieldOn()
    {
        if (IsShieldOn)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
  
    public void ShieldOn()
    {
        animator.SetTrigger("ShieldOn");
        IsShieldOn = true;
        
    }
    public void ShieldOff()
    {
        animator.SetTrigger("ShieldOff");
        IsShieldOn = false;
    }
    
    public void Damage()
    {
        animator.SetTrigger("Pain");
        
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
            animator.SetBool("Jumping", true);
        }
        if (rb.velocity.y < 0)
        {
            animator.SetBool("Jumping", false);
            animator.SetBool("Falling", true);
        }
        if (isGrounded)
        {
            animator.SetBool("Falling", false);
            animator.SetTrigger("Grounded");
            
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
       
         animator.SetBool("IsJumping", IsJumping);
     }*/

}

