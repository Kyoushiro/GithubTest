using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigatetoScene : MonoBehaviour {

    [SerializeField] string sceneToNavigateTo;

    public void Navigate()
    {
        SceneManager.LoadScene(sceneToNavigateTo);
    }
}
