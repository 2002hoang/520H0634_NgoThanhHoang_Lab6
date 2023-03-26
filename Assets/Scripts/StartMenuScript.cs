using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartMenuScript : MonoBehaviour {
    
    public FaderScript fader;
    
    IEnumerator ChangeLevel() {
        FaderScript faderScript = GameObject.FindObjectOfType<FaderScript>();
        
        float fadeDuration = faderScript.BeginFade(1);
        
        yield return new WaitForSeconds(fadeDuration);
        
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene");
    }

    void Start() {
        fader.BeginFade(-1);
    }

    public void StartGame() {
        StartCoroutine(ChangeLevel());
    }
    
    public void ExitGame() {
        Application.Quit();
        Debug.Log("out game");
    }

}
