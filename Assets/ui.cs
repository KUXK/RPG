using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ui : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] Slider hp;
    [SerializeField] Slider mana;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        hp.value = hp.maxValue;
        mana.value = mana.maxValue * 0.7f ;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L)) panel.SetActive(true);
        if (Input.GetKeyUp(KeyCode.L)) panel.SetActive(false);
        mana.value = mana.value + 0.001f;
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            mana.value = mana.value * 0.3f;
        }
    }
}
