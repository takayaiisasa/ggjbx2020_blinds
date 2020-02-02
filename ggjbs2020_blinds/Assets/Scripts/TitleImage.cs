using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleImage : MonoBehaviour
{
    Image image;
    float move = 1;
    bool fadeOut;
    float time=0;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        image.color = new Color(1,1,1,1);
        fadeOut = false;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 1.0f)
        {
            move -= 0.3f * Time.deltaTime;
            image.color = new Color(1, 1, 1, move);
            if (move <= 0.2)
            {
                fadeOut = true;
                Door.doorStart = true;
            }
        }
    }
}
