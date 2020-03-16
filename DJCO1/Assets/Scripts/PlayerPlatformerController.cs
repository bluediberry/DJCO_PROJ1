using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatformerController : PhysicsObject {

    public float maxSpeed = 10;
    public float jumpTakeOffSpeed = 30;
    const float Move_Delta = 0.01f;    // Place at top of script - change to whatever value is comfortable
    [SerializeField] private GameObject graphic;
    [SerializeField] private Animator animator;
    private SpriteRenderer spriteRenderer;
    public TimerScript timer;

    // Use this for initializati
    void Awake () 
    {
        spriteRenderer = GetComponent<SpriteRenderer> ();
        animator = GetComponent<Animator> ();
    }

    protected override void ComputeVelocity()
    {
        Vector2 move = Vector2.zero;

        move.x = Input.GetAxis ("Horizontal");

        if (Input.GetButtonDown ("Jump") && grounded) {
            velocity.y = jumpTakeOffSpeed;
        } else if (Input.GetButtonUp ("Jump")) 
        {
            if (velocity.y > 0) {
                velocity.y = velocity.y * 0.5f;
            }
        }

         // If we have movement, set our flip - else keep our last flipped state
  
            if (Mathf.Abs(move.x) > Move_Delta)
            {
                transform.localScale = move.x > Move_Delta ? new Vector2(0.3008129f, 0.290336f) : new Vector2(-0.3008129f, 0.290336f);

            }



        /* if (Mathf.Abs(move.x) > Move_Delta )
          {
             transform.localScale = move.x > Move_Delta ? new Vector2(0.3008129f, 0.290336f) : new Vector2(-0.3008129f, 0.290336f);

         }*/

  
            animator.SetBool("grounded", grounded);
            animator.SetFloat("velocityX", Mathf.Abs(velocity.x) / maxSpeed);
        
        targetVelocity = move * maxSpeed;
    }

}