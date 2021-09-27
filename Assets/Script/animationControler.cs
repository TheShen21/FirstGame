using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationControler : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = animator.GetBool(isWalkingHash);   
        bool fowardPressed = Input.GetKey("w");
        bool backwardPressed = Input.GetKey("s");
        bool leftPressed = Input.GetKey("a");
        bool rightPressed = Input.GetKey("d");
        
        //foward animation
        if (!isWalking && fowardPressed)
        {
            animator.SetBool(isWalkingHash, true);

        }
        
        //backward animation
        if (!isWalking && backwardPressed)
        {
            animator.SetBool(isWalkingHash, true);

        }
        //left animation
        if (!isWalking && leftPressed)
        {
            animator.SetBool(isWalkingHash, true);

        }
        
        //right animation
        if (!isWalking && rightPressed)
        {
            animator.SetBool(isWalkingHash, true);

        }
        if (isWalking && !fowardPressed && !backwardPressed && !leftPressed &&!rightPressed)
        {
            animator.SetBool(isWalkingHash, false);

        }

    }
}
