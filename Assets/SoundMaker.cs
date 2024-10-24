using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMaker : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject manager;
    [SerializeField] List<AudioClip> audioClips;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (manager.GetComponent<Manager>().isMove == true)
        {
            GetComponent<AudioSource>().PlayOneShot(audioClips[0]);
            manager.GetComponent<Manager>().isMove = false;
        }
        if (manager.GetComponent<Manager>().isWin == true)
        {
            GetComponent<AudioSource>().PlayOneShot(audioClips[1]);
            //manager.GetComponent<Manager>().isMove = false;
        }
        if (manager.GetComponent<Manager>().isLost == true)
        {
            GetComponent<AudioSource>().PlayOneShot(audioClips[2]);
            //manager.GetComponent<Manager>().isMove = false;
        }
    }
}
