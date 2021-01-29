using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{
    
    public int vidamaxima = 10;
    public int VidaAtual;
    public BarraVida barravida;

    public Animator animator;
    public float axis;
    public Vector2 velocidade;
    public bool ladoDireito = true;

    public float MaxVelocidade = 10;


    // public float Speed;
    public float JumpForce;
    // public float move;
   
    public bool isJumping;
    public bool doubleJump;
    private Rigidbody2D rig;
    private Animator anim;
    private SpriteRenderer sprite;
    // bool facingRight = true;
   
    // Start is called before the first frame update
    void Start() {
        animator = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
         VidaAtual = vidamaxima;
         barravida.VidaMaxima(vidamaxima);
    }

    void FixedUpdate () {
        axis = Input.GetAxis("Horizontal");
        if (axis > 0 && !ladoDireito)
        {
            Vire();
        }
        if (axis < 0 && ladoDireito)
        {
            Vire();
        }

        velocidade = new Vector2 (axis * MaxVelocidade, GetComponent<Rigidbody2D>().velocity.y);

        animator.SetFloat ("Velocidade", Mathf.Abs (axis));

        GetComponent<Rigidbody2D>().velocity = velocidade;
	}

    // Update is called once per frame
    void Update() {

        if(Input.GetKeyDown(KeyCode.C))
        {
            Dano(1);
        }

        Jump();
    }

    void Vire() {
        ladoDireito = !ladoDireito;
            
        Vector2 novoScale = new Vector2 (transform.localScale.x * -1, transform.localScale.y);

        transform.localScale = novoScale;
    }

    void Dano(int dano){
     VidaAtual -= dano;
     barravida.ControleVida(VidaAtual);
    }

   void Jump()  {

        
         if(Input.GetButtonDown("Jump") ) {
            if(!isJumping){
                 rig.AddForce(new Vector2 (0f, JumpForce), ForceMode2D.Impulse);    
                doubleJump = true;
          }
         else{
                if(doubleJump){
                  rig.AddForce(new Vector2 (0f, JumpForce), ForceMode2D.Impulse);    
                     doubleJump = false;
                 }
           }
            
         }
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.layer == 8){
            isJumping = false;
        }
    }

     void OnCollisionExit2D(Collision2D collision){
        if(collision.gameObject.layer == 8){
            isJumping = true;
        }
    }




}
    