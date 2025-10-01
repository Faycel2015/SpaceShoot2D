using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] private AudioSource _musicSource;
    [SerializeField] private AudioSource _effectSource;

    public AudioSource MusicSource => _musicSource;
    public AudioSource EffectSource => _musicSource;

    public static Controller Instance;

    private void Awake()
    {
        Instance = this;
    }
}
