using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPipe : MonoBehaviour
{
    private AudioSource CatchPipe;
    private AudioSource PipeNear;
    private AudioSource PipeFar;
    private bool TrrigerFlag;
    private float Timer;
    int count;
    public GameObject goal;
    public bool clearflag;

    void Start()
    {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        CatchPipe = audioSources[0];
        PipeNear = audioSources[1];
        PipeFar = audioSources[2];
        TrrigerFlag = false;
        Timer = 0;
        clearflag = false;
    }

    void Update()
    {
        Timer += Time.deltaTime;
        if (TrrigerFlag == true && Timer >= 1)
        {
            TrrigerFlag = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(TrrigerFlag == false)
        {

            switch (other.gameObject.tag)  // ぶつかったオブジェクトのタグで分岐
            {
                case "goal":
                    {
                        CatchPipe.PlayOneShot(CatchPipe.clip);
                        TrrigerFlag = true;
                        Timer = 0;
                        if (count >= 1)
                        {
                            count--;
                        }
                        else if (count == 0)
                        {
                            Destroy(goal);
                            clearflag = true;
                        }
                        break;
                    }
                case "close":
                    {
                        PipeNear.PlayOneShot(PipeNear.clip);
                        TrrigerFlag = true;
                        Timer = 0;
                        break;
                    }
                case "far":
                    {
                        PipeFar.PlayOneShot(PipeFar.clip);
                        TrrigerFlag = true;
                        Timer = 0;
                        break;
                    }
            }
        }
    }
}
