using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static bool start = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            float move;
            move = 0.3f * Time.deltaTime;
            transform.position += new Vector3(0, 0, move);
        }
    }
}
