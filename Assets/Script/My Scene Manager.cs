using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class MySceneManager : MonoBehaviour
{

    public GameObject SourceImage;
    bool imageState = false;

    public void ChangeScene(int val) {
        SceneManager.LoadScene(val);
    }

    public void ShowSource() { 
        imageState = !imageState;
        SourceImage.SetActive(imageState);
    }

}
