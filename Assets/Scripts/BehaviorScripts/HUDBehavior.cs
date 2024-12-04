using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HUDBehavior : MonoBehaviour
{
    public globalsBehavior globalsBehavior;
    public TMP_Text currentElement;
    public GameObject poweredUp;
    public GameObject[] charackters;
    //public GameObject[] symbols;
    public GameObject elementWheel;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject chr in charackters)
        {
            chr.SetActive(false);
        }
        /*foreach (GameObject symbol in symbols)
        {
            symbol.SetActive(false);
        }*/

        charackters[globalsBehavior.element].SetActive(true);
        //symbols[globalsBehavior.element].SetActive(true);

        poweredUp.SetActive(false);
        TurnTheElementWheel();
    }

    // Update is called once per frame
    void Update()
    {
        currentElement.text = globalsBehavior.element.ToString("0");
        if (Input.GetKeyDown(KeyCode.S))
        {
            ChangeElement();
            TurnTheElementWheel();
        }

        if (globalsBehavior.fireCharged == true || globalsBehavior.waterCharged == true || globalsBehavior.earthCharged == true || globalsBehavior.windCharged == true)
        {
            poweredUp.SetActive(true);
        }else
        {
            poweredUp.SetActive(false);
        }
    }

    void ChangeElement()
    {
        globalsBehavior.element = globalsBehavior.element + 1;
        globalsBehavior.fireCharged = false;
        globalsBehavior.waterCharged = false;
        globalsBehavior.earthCharged = false;
        globalsBehavior.windCharged = false;

        foreach (GameObject chr in charackters)
        {
            chr.SetActive(false);
        }
        /*foreach (GameObject symbol in symbols)
        {
            symbol.SetActive(false);
        }*/
    

            if (globalsBehavior.element == globalsBehavior.elementBlocker)
            {
                globalsBehavior.element = 0;
            }
        charackters[globalsBehavior.element].SetActive(true);
        //symbols[globalsBehavior.element].SetActive(true);

    }

    void TurnTheElementWheel()
    {
        if (globalsBehavior.element == 0)
        {
            elementWheel.transform.eulerAngles = new Vector3(0, 0, 135);
        }
        if (globalsBehavior.element == 1)
        {
            elementWheel.transform.eulerAngles = new Vector3(0, 0, -135);
        }
        if (globalsBehavior.element == 2)
        {
            elementWheel.transform.eulerAngles = new Vector3(0, 0, 45);
        }
        if (globalsBehavior.element == 3)
        {
            elementWheel.transform.eulerAngles = new Vector3(0, 0, -45);
        }
    }
}
