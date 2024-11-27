using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Triggeractivationtimeline : MonoBehaviour
{
    
    public PlayableDirector timeline;

    bool has_triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!has_triggered)
        {
            timeline.Play();
            has_triggered = true;
        }
        else
        {
            return;
        }

    }
}


