using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneUIManagerScript : MonoBehaviour
{
    public Button button_scene;
    public string scene_master_text;

    // Start is called before the first frame update
    void Start()
    {
        button_scene.onClick.AddListener(onButtonBackToMasterClicked);
    }

    private void onButtonBackToMasterClicked()
    {
        SceneManager.LoadScene(scene_master_text);
    }

}
