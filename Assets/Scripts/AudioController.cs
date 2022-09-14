using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSourceMusicaDeFundo;
    public AudioClip[] musicasDeFundo;
    // Start is called before the first frame update
    void Start()
    {
       AudioClip audioSourceMusicaDeFundoDessaFase = musicasDeFundo[1];
       audioSourceMusicaDeFundo.clip = audioSourceMusicaDeFundoDessaFase;
       audioSourceMusicaDeFundo.loop = true;
       audioSourceMusicaDeFundo.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
