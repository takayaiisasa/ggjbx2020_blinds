using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPipe : MonoBehaviour
{
    private AudioSource CatchPipe;
    private AudioSource PipeNear;
    private AudioSource PipeFar;
    private bool TrrigerFlag;
    private float Timmer;

    void Start()
    {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        CatchPipe = audioSources[0];
        PipeNear = audioSources[1];
        PipeFar = audioSources[2];
        TrrigerFlag = false;
        Timmer = 0;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (TrrigerFlag == true && timer >= 2)
        {
            TrrigerFlag = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)  // ぶつかったオブジェクトのタグで分岐
        {
            case "goal":
                {
                    CatchPipe.PlayOneShot(CatchPipe.clip);
                    TriggerFlag = true;
                    Timer = 0;
                    break;
                }
            case "close":
                {
                    PipeNear.PlayOneShot(PipeNear.clip);
                    TriggerFlag = true;
                    Timer = 0;
                    break;
                }
            case "far":
                {
                    PipeFar.PlayOneShot(PipeFar.clip);
                    TriggerFlag = true;
                    Timer = 0;
                    break;
                }
        }
    }
}
