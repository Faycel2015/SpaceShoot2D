using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] private AudioSource _musicSource;
    [SerializeField] private AudioSource _effectSource;

    public AudioSource MusicSource => _musicSource;
    public AudioSource EffectSource => _musicSource;

    public static Controller Instance;
    public PlayerShip _myShip;
    private Vector3 _leftDownPoint;
    private Vector3 _rightDownPoint;
    private Vector3 _leftUpPoint;
    private Vector3 _rightUpPoint;
    private Vector2 _centerCam;

    public Vector3 LeftDownPoint => _leftDownPoint;
    public Vector3 RightDownPoint => _rightDownPoint;
    public Vector3 LeftUpPoint => _leftUpPoint;
    public Vector3 RightUpPoint => _rightUpPoint;
    public Vector2 CenterCam => _centerCam;

    private void Awake()
    {
        Instance = this;
    }
    public void UpdateCameraSettings()
    {
        var cameraMain = Camera.main;
        if (cameraMain != null)
        {
            _centerCam = cameraMain.transform.position;
            float distance = cameraMain.farClipPlane;
            _leftDownPoint = cameraMain.ScreenToWorldPoint(new Vector3(0, 0, distance));
            _leftUpPoint = cameraMain.ScreenToWorldPoint(new Vector3(0, cameraMain.pixelHeight, distance));
            _rightUpPoint = cameraMain.ScreenToWorldPoint(new Vector3(cameraMain.pixelWidth, cameraMain.pixelHeight, distance));
            _rightDownPoint = cameraMain.ScreenToWorldPoint(new Vector3(cameraMain.pixelWidth, 0, distance));
        }
    }
}
