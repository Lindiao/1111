using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour {

    public string sceneName = "";
    public int sceneId = 0;

    public void GoTo()
    {
        if (sceneName == "")
        {
            Game.screen().FadeAndGo(sceneId);
            //SceneManager.LoadScene(sceneId);
        }
        else
        {
            Game.screen().FadeAndGo(sceneName);
            //SceneManager.LoadScene(sceneName);
        }
    }
}
