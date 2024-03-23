using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory_Cutscene : MonoBehaviour
{
    public float interval;
    public GameObject Image_1, Image_2, Image_3, Image_4, Button_1, Title_Victory;

 

    // Start is called before the first frame update
    void Awake()
    {
        // interval = Random.Range(0f, 2f);
        
        Image_1.gameObject.SetActive(true);
        
    }
    void Start()
    {
        // interval = Random.Range(0f, 2f);

        Image_1.gameObject.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.time);

        if (Time.time >= 3f)
        {
            Image_1.gameObject.SetActive(true);
            if (Time.time >= 6f)
            {
                Image_1.gameObject.SetActive(false);
                Image_2.gameObject.SetActive(true);

                if (Time.time >= 9f)
                {
                    Image_1.gameObject.SetActive(false);
                    Image_2.gameObject.SetActive(false);
                    Image_3.gameObject.SetActive(true);

                    if (Time.time >= 9f)
                    {
                        Image_1.gameObject.SetActive(false);
                        Image_2.gameObject.SetActive(false);
                        Image_3.gameObject.SetActive(false);
                        Image_4.gameObject.SetActive(true);

                        Title_Victory.gameObject.SetActive(true);
                        Button_1.gameObject.SetActive(true);
                    }
                }


            }
        }

    }
}
