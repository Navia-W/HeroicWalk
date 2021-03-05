using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    private int _currentScene = 0;

    /// <summary>
    ///Call to load scene based on index in the build settings. Will delete previous scene.
    /// </summary>
    public void GoToScene(int SceneIndex)
    {
        if (_currentScene == SceneIndex)
            return;

        SceneManager.LoadSceneAsync(SceneIndex, mode: LoadSceneMode.Single);
        _currentScene = SceneIndex;
    }


    /// <summary>
    /// Reloads the current active scene
    /// </summary>
    public void ReloadScene()
    {
        SceneManager.LoadSceneAsync(_currentScene, mode: LoadSceneMode.Single);
    }
}
