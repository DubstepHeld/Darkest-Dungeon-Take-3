using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchSceneAfter : MonoBehaviour {
    /*
     * Waits a certain amount of seconds and then loads a new scene.
     */

    public float waitTimeInSeconds = 0;
    public string sceneName;

    // Use this for initialization
    void Start() {
        StartCoroutine(WaitAndLoad());
    }

    IEnumerator WaitAndLoad() {
        yield return new WaitForSeconds(waitTimeInSeconds);
        SceneManager.LoadScene(sceneName);
    }

}
