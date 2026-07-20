
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private float speed = 10f;

    public Animator animator;

    void Start()
    {
        
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            animator.Play("WalkRight");

        }else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            animator.Play("WalkLeft");

        }else if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            animator.Play("WalkFWD");

        }else if ( Input.GetKey(KeyCode.DownArrow)){
            
            transform.Translate(Vector3.back * Time.deltaTime * speed);
            animator.Play("WalkBWD");
            
        }else
        {
            animator.Play("IdleNormal");
        }

        
        
    }
}
    

    

