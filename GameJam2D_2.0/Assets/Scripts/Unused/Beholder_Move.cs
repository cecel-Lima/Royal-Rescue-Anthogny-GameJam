using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beholder_Move : MonoBehaviour
{
    Animator animator;
    public float speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("Beholder_Frente", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
