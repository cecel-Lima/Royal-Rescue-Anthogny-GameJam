using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Feather_Move : MonoBehaviour
{
    Animator animator;
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("Run_Feather_2", true);
    }

    // Update is called once per frame
    void Update()
    {
        FeatherSway();
    }

    void FeatherSway()
    {
        Vector2 position = transform.position;

        if (Input.anyKey != true)
        {
            animator.SetBool("Run_Feather_2", true);
        }

        else
        {
            animator.SetBool("Run_Feather_2", true);
        }

        transform.position = position;
    }
}
