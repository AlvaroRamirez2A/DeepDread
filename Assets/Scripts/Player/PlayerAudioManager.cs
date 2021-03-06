using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioManager : MonoBehaviour
{
    public AudioClip Escalar;
    public AudioClip Rodar;
    public AudioClip Salto;
    public AudioClip Caer;
    public AudioClip Paso;
    public AudioClip Aire;
    public AudioClip Hit;
    public AudioClip Pipe;
    public AudioClip Dolor1;
    public AudioClip Dolor2;
    public AudioClip Curar;
    private Dictionary<string,AudioClip> soundDict = new Dictionary<string, AudioClip>();
    private GlobalAudioManager audioManager;

    void Awake()
    {
        soundDict.Add("escalar", Escalar);
        soundDict.Add("rodar", Rodar);
        soundDict.Add("saltar", Salto);
        soundDict.Add("caer", Caer);
        soundDict.Add("paso", Paso);
        soundDict.Add("aire", Aire);
        soundDict.Add("hit", Hit);
        soundDict.Add("pipe", Pipe);
        soundDict.Add("dolor1", Dolor1);
        soundDict.Add("dolor2", Dolor2);
        soundDict.Add("curar", Curar);

        audioManager = FindObjectOfType<GlobalAudioManager>();
    }

    public void AudioPlay(string audio)
    {
        string[] str = audio.Split('_');

        audioManager.AudioPlay(soundDict[str[0]], float.Parse(str[1]), str[2] == "1", transform.position);
    }    
}
