using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Info : MonoBehaviour {

    public Text info;

    void Start()
    {
        info.color = Color.clear;
    }

	public void InfoT()
    {
        if (info.color == Color.clear)
        {
            info.color = Color.white;
        }else
        {
            info.color = Color.clear;
        }
    }
	
	
}
