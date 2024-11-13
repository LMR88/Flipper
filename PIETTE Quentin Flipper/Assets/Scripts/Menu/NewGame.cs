using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using Debug = System.Diagnostics.Debug;
using UnityEngine.UI;


public class NewGame : MonoBehaviour
{ 
    public Animation fade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void ChangeScene(string Level1)
    {
        SceneManager.LoadScene(Level1);
        fade.Play("Fade");
    }
}