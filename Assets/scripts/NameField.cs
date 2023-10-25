using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class NameField : MonoBehaviour
{
    public Text ttext;
    public InputField inputField;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       string Username = inputField.text;

       ttext.text= "hello"+Username;

    }
}
