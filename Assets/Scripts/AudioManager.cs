using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioSource CoinSound;
    public AudioSource ExplosionSound;

    public void Coin()
    {
        CoinSound.Play();

    }
    public void Explosion()
    {
        ExplosionSound.Play();
    }


}
