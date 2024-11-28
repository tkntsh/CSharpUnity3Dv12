using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class changeToARScene : MonoBehaviour
{
    public Button modelViewButton;
    // Start is called before the first frame update
    void Start()
    {
        modelViewButton.onClick.AddListener(() => viewARCarModel());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void viewARCarModel()
    {
        SceneManager.LoadScene("arModelScene");
    }
}
