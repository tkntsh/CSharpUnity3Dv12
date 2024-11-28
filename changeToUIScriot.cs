using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class changeToUIScriot : MonoBehaviour
{
    public Button backButton;
    // Start is called before the first frame update
    void Start()
    {
        backButton.onClick.AddListener(() => viewUIMenu());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void viewUIMenu()
    {
        SceneManager.LoadScene("UI");
    }
}
