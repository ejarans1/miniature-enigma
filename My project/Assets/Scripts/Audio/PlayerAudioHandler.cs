using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioHandler : MonoBehaviour
{

    public AudioSource footStepAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playFootSStepAudioSource(){
        if(!footStepAudioSource.isPlaying) {
            footStepAudioSource.Play();
        }
    }
    public void stopFootStepAudioSource(){
        footStepAudioSource.Pause();
    }
}
