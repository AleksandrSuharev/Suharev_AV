using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NewBehaviourScript : MonoBehaviour
{
    public GameObject obj;
    int c = 0;
    public void deactivate()
    {
        if (c % 2 == 0)
        {
            obj.SetActive(false);
            c+=1;
        }
        else
        {
            obj.SetActive(true);
            c+=1;
        }
    }
}
