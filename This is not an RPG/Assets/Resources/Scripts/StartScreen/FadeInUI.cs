using UnityEngine;
using System.Collections;

public class FadeInUI : MonoBehaviour {

    public GameObject obj;
    public bool isFadeIn=false;
    public float a;

    // Use this for initialization
    void Start ()
    {
        if(obj==null)
        {
            obj = gameObject;
            a = obj.GetComponent<CanvasRenderer>().GetAlpha();
        }
    }


    // Update is called once per frame
    void Update ()
    {

        if (obj != null && a<=1f && isFadeIn)
        {
                obj.GetComponent<CanvasRenderer>().SetAlpha(a);
                a += 0.01f;
        }


    }
}
