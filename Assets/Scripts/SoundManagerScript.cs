using UnityEngine;

#nullable enable

public class SoundManagerScript : MonoBehaviour
{
  public static SoundManagerScript instance = default!;

  [SerializeField]
  AudioSettings audioSettings = default!;

  AudioSource? audioSource;

  public void PlayNpcDeath()
  {
    var volume = LocalPrefs.GetSFXVolume();

    if (audioSource != null)
    {
      audioSource.PlayOneShot(
        audioSettings.GetRandomNpcDeathAudioClip(),
        volume
      );
    }
  }

  public void PlaySwordHit()
  {
    var volume = LocalPrefs.GetSFXVolume();

    if (audioSource != null)
    {
      audioSource.PlayOneShot(
        audioSettings.GetRandomSwordHitAudioClip(),
        volume
      );
    }
  }

  public void PlaySwordSwing()
  {
    var volume = LocalPrefs.GetSFXVolume();

    if (audioSource != null)
    {
      audioSource.PlayOneShot(
        audioSettings.GetRandomSwordSwingAudioClip(),
        volume
      );
    }
  }

  void Awake()
  {
    instance = this;
  }

  void Start()
  {
    audioSource = GameManagerScript.instance.GetPlayer?.
      transform.Find("AudioSource").GetComponent<AudioSource>();
  }
}
