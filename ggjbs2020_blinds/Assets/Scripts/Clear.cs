using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clear : MonoBehaviour
{
    Text text;
    float speed = 0.01f;
    float alfa;
    float red, green, blue;
    bool clearflag;
    // Start is called before the first frame update
    void Start()
    {
        //  this.text = this.GetComponent<Text>();
        text = GetComponent<Text>();
        red = this.GetComponent<Text>().color.r;
        green = this.GetComponent<Text>().color.g;
        blue = this.GetComponent<Text>().color.b;
        alfa = this.GetComponent<Text>().color.a;
        clearflag = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (clearflag == true)
        {
            GetComponent<Text>().color = new Color(red, green, blue, alfa);
            alfa += speed;
        }
        text.color = new Color(red, green, blue, alfa);
    }
}
