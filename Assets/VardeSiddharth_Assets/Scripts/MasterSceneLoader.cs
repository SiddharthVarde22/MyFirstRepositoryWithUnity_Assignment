using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MasterSceneLoader : MonoBehaviour
{
    public Button backButton;
    public string masterSceneName;

    // Start is called before the first frame update
    void Start()
    {
        backButton.onClick.AddListener(BackButtonPressed);
    }

    void BackButtonPressed()
    {
        SceneManager.LoadScene(masterSceneName);
    }
}
