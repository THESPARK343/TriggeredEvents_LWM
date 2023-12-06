using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerScript : MonoBehaviour
{
    public GameObject SelfTarget;
    public PlayableDirector Timeline;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other != null)
        {
            Timeline.Play();
            SelfTarget.SetActive(false);
        }
    }
}
