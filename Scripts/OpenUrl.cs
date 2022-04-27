using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenUrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void linkdin()
    {
        Application.OpenURL("http://linkedin.com");
    }
    public void git()
    {
        Application.OpenURL("https://github.com");
    }
    public void certificate()
    {
        Application.OpenURL("https://drive.google.com");
    }

}
