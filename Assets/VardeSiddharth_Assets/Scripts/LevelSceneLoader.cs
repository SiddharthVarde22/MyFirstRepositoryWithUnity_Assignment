using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSceneLoader : MonoBehaviour
{
    public Button scene1Button, scene2Button, scene3Button;
    public string scene1Name, scene2Name, scene3Name;

    // Start is called before the first frame update
    void Start()
    {
        scene1Button.onClick.AddListener(Scene1ButtonPressed);
        scene2Button.onClick.AddListener(Scene2ButtonPressed);
        scene3Button.onClick.AddListener(Scene3ButtonPressed);
    }

    void Scene1ButtonPressed()
    {
        SceneManager.LoadScene(scene1Name);
    }

    void Scene2ButtonPressed()
    {
        SceneManager.LoadScene(scene2Name);
    }

    void Scene3ButtonPressed()
    {
        SceneManager.LoadScene(scene3Name);
    }
}
