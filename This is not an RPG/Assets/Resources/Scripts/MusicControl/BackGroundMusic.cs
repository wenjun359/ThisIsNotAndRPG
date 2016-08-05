using UnityEngine;
using System.Collections;

public class BackGroundMusic : MonoBehaviour {

    void Awake ()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

}
