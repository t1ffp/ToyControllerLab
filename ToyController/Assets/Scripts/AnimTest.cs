using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTest : MonoBehaviour
{

    public Animator square;
  

    // Start is called before the first frame update
    void Start()
    {
        square = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            square.SetBool("isPlaying", true);
        }
        else
        {
            square.SetBool("isPlaying", false);
        }
    }


}
