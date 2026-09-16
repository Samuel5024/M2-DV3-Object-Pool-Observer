using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Observer");
    }

    public void PreviousScene()
    {
        SceneManager.LoadScene("ObjectPool");
    }
}
