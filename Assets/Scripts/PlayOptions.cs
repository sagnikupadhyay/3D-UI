using TMPro;
using UnityEngine;

namespace SRock
{
    public class PlayData
    {

    }

    public class PlayOptions : MonoBehaviour
    {
        public void SetFontColor_Yellow(TextMeshProUGUI textMesh)
        {
            textMesh.color = Color.yellow;
        }

        public void SetFontColor_White(TextMeshProUGUI textMesh)
        {
            textMesh.color = Color.white;
        }

        public void StartGame()
        {
            /*if(sceneName != ""){
				//StartCoroutine(LoadAsynchronously(sceneName));
				//SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
			}*/
        }

        public void QuitGame()
        {
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #else
			Application.Quit();
            #endif
        }
    }
}
