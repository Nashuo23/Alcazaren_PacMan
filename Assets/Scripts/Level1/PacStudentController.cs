using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    //for movement speed
    public float moveSpeed = 5f;
    //for eating sound
    public AudioClip pacEatsPellet;
    //for moving sound
    public AudioClip pacMove;
    // for particle effect
    public ParticleSystem moveEffects;
    // to default right
    private Vector3 lastInput = Vector3.right;
    private Vector3 currentInput = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        //to start facing to the right
        lastInput = Vector3.right;
        currentInput = Vector3.zero;
    }
    
    
    // Update is called once per frame
    // void Update()
    // {
    //     MoveInputs;
    //     if(!Tweener.TweenExists(transform))
    //     {
    //         ToMove();
    //     }

    // }

    // void MoveInputs()
    // {
    //     // for the w,a,s,d key movemement inputs
    //     if (Input.GetKeyDown(KeyCode.W)) lastInput = Vector3.up;
    //     if (Input.GetKeyDown(KeyCode.A)) lastInput = Vector3.left;
    //     if (Input.GetKeyDown(KeyCode.S)) lastInput = Vector3.down;
    //     if (Input.GetKeyDown(KeyCode.D)) lastInput = Vector3.right;
    // }

    // void ToMove()
    // {
    //     Vector3 startPos = transform.position;
    //     Vector3 endPos = startPos + lastInput * moveDistance;

    //     float distance = Vector3.Distance(startPos, endPos);
    //     float duration = distance / moveSpeed;

    //     bool moveStart = Tweener.AddTween(transform, startPos, endPos, duration);
    //     if (moveStart)
    //     {
    //         currentInput = lastInput;
    //     }
    // }
    
}