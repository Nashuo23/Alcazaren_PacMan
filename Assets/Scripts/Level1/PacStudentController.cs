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
    // to default right
    private Vector3 lastInput = Vector3.right;
    private Vector3 currentInput = Vector3.zero;

    

    
}