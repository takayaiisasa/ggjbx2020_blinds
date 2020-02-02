using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField]
    AudioClip[] audioClip;

    public static SoundManager Instance
    {
        get { return instance; }
    }

    private static SoundManager instance = null;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;

            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip[0];
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    { 
    }
}
