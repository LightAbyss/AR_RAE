using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebLink : MonoBehaviour{
    public void OpenLink(string link){
        Application.OpenURL(link);
    }
}
