using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MasterUIManagerScript : MonoBehaviour
{
    public Button button_scene_1;
    public Button button_scene_2;
    public Button button_scene_3;
    public string scene_1_name_text;
    public string scene_2_name_text;
    public string scene_3_name_text;

    // Start is called before the first frame update
    void Start()
    {
        button_scene_1.onClick.AddListener(onButton1Clicked);
        button_scene_2.onClick.AddListener(onButton2Clicked);
        button_scene_3.onClick.AddListener(onButton3Clicked);
    }

    private void onButton1Clicked()
    {
        SceneManager.LoadScene(scene_1_name_text);
    }

    private void onButton2Clicked()
    {
        SceneManager.LoadScene(scene_2_name_text);

    }

    private void onButton3Clicked()
    {
        SceneManager.LoadScene(scene_3_name_text);
    }

}
