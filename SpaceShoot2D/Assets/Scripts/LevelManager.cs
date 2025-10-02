using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(this);
        SceneManager.LoadScene(1);
    }

}
