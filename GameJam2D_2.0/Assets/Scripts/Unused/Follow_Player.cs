using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Player : MonoBehaviour
{
    public GameObject Target;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Area();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Area")
        {
            Area();
        }
    }

    void Area()
    {
        transform.position = Vector2.MoveTowards(transform.position, Target.transform.position, 3 * Time.deltaTime);
    }
}
