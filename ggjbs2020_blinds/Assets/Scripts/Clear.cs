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
    bool hitpipeflag;
    // Start is called before the first frame update
    public HitPipe hitpipe;
    AudioSource audioSource;
    void Start()
    {
        //  this.text = this.GetComponent<Text>();
        text = GetComponent<Text>();
        red = this.GetComponent<Text>().color.r;
        green = this.GetComponent<Text>().color.g;
        blue = this.GetComponent<Text>().color.b;
        alfa = this.GetComponent<Text>().color.a;
        clearflag = false;
        hitpipeflag = false;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //hitpipe.clearflag;
        if (hitpipe.clearflag == true)
        {
            GetComponent<Text>().color = new Color(red, green, blue, alfa);
            alfa += speed;
            audioSource.Play();
        }
        text.color = new Color(red, green, blue, alfa);
    }
}
