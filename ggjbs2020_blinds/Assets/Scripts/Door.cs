using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    Vector3 rotation;
    float value = 0;
    public static bool doorStart = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (doorStart)
        {
            if (transform.rotation.y >= -0.7f)
            {
                value -= 0.3f * Time.deltaTime;
                transform.Rotate(new Vector3(0, value, 0));
            }
            else
            {
                Player.start = true;
            }
        }
    }
}
