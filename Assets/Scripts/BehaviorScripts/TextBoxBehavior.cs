using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxBehavior : MonoBehaviour
{
    public GameObject textBox;
    //public Button clickAway;
    public bool clearAll;
    public AudioSource talkingSound;

    public bool fireMeetsFire;
    public GameObject textFireMeetsFire;
    public bool waterMeetsFire;
    public GameObject textWaterMeetsFire;
    public bool earthWindMeetsFire;
    public GameObject textEarthWindMeetFire;

    public bool fireMeetsWater;
    public GameObject textFireMeetsWater;
    public bool waterMeetsWater;
    public GameObject textWaterMeetsWater;
    public bool earthWindMeetsWater;
    public GameObject textEarthWindMeetWater;

    public bool fireWMeetsEarth;
    public GameObject textFireWaterMeetEarth;
    public bool earthMeetsEarth;
    public GameObject testEarthMeetsEarth;
    public bool windMeetsEarth;
    public GameObject textWindMeetsEarth;

    public bool fireMeetsWind;
    public GameObject textFireMeetsWind;
    public bool waterMeetsWind;
    public GameObject textWaterMeetsWind;
    public bool earthMeetsWind;
    public GameObject textEarthMeetsWind;
    public bool windMeetsWind;
    public GameObject textWindMeetsWind;


    public bool waterWalksOnFire;
    public GameObject textWaterWalksOnFire;
    public bool earthWalksOnFire;
    public GameObject textEarthWalksOnFire;
    public bool windWalksOnFire;
    public GameObject textWindWalksOnFire;

    public bool fireWalksOnWater;
    public GameObject textFireWalksOnWater;
    public bool earthWalksOnWater;
    public GameObject textEarthWalksOnWater;
    public bool windWalksOnWater;
    public GameObject textWindWalksOnWater;

    public bool fireWalksOnEarth;
    public GameObject textFireWalksOnEarth;
    public bool waterWalksOnEarth;
    public GameObject textWaterWalksOnEarth;
    public bool windWalksOnEarth;
    public GameObject textWindWalksOnEarth;

    // Start is called before the first frame update
    void Start()
    {
        textBox.SetActive(false);
        ClearTextBox();
        //clickAway.onClick.AddListener(() => ClearTextBox());
    }

    private void FixedUpdate()
    {
        if (clearAll == true)
        {
            ClearTextBox();
            clearAll = false;
        }

        if (fireMeetsFire == true)
        {
            textFireMeetsFire.SetActive(true);
            textBox.SetActive(true);
            talkingSound.Play();
        }
        if (waterMeetsFire == true)
        {
            textWaterMeetsFire.SetActive(true);
            textBox.SetActive(true);
            talkingSound.Play();
        }
        if (earthWindMeetsFire == true)
        {
            textEarthWindMeetFire.SetActive(true);
            textBox.SetActive(true);
            talkingSound.Play();
        }

        if (fireMeetsWater == true)
        {
            textFireMeetsWater.SetActive(true);
            textBox.SetActive(true);
            talkingSound.Play();
        }
        if (waterMeetsWater == true)
        {
            textWaterMeetsWater.SetActive(true);
            textBox.SetActive(true);
            talkingSound.Play();
        }
        if (earthWindMeetsWater == true)
        {
            textEarthWindMeetWater.SetActive(true);
            textBox.SetActive(true);
            talkingSound.Play();
        }

        if (fireWMeetsEarth == true)
        {
            textFireWaterMeetEarth.SetActive(true);
            textBox.SetActive(true);
            talkingSound.Play();
        }
        if (earthMeetsEarth == true)
        {
            testEarthMeetsEarth.SetActive(true);
            textBox.SetActive(true);
            talkingSound.Play();
        }
        if (windMeetsEarth == true)
        {
            textWindMeetsEarth.SetActive(true);
            textBox.SetActive(true);
            talkingSound.Play();
        }

        if (fireMeetsWind == true)
        {
            textFireMeetsWind.SetActive(true);
            textBox.SetActive(true);
            talkingSound.Play();
        }
        if (waterMeetsWind == true)
        {
            textWaterMeetsWind.SetActive(true);
            textBox.SetActive(true);
            talkingSound.Play();
        }
        if (earthMeetsWind == true)
        {
            textEarthMeetsWind.SetActive(true);
            textBox.SetActive(true);
            talkingSound.Play();
        }
        if (windMeetsWind == true)
        {
            textWindMeetsWind.SetActive(true);
            textBox.SetActive(true);
            talkingSound.Play();
        }


        if (waterWalksOnFire == true)
        {
            textWaterWalksOnFire.SetActive(true);
            textBox.SetActive(true);
            talkingSound.Play();
        }
        if (earthWalksOnFire == true)
        {
            textEarthWalksOnFire.SetActive(true);
            textBox.SetActive(true);
            talkingSound.Play();
        }
        if (windWalksOnFire == true)
        {
            textWindWalksOnFire.SetActive(true);
            textBox.SetActive(true);
            talkingSound.Play();
        }

        if (fireWalksOnWater == true)
        {
            textFireWalksOnWater.SetActive(true);
            textBox.SetActive(true);
            talkingSound.Play();
        }
        if (earthWalksOnWater == true)
        {
            textEarthWalksOnWater.SetActive(true);
            textBox.SetActive(true);
            talkingSound.Play();
        }
        if (windWalksOnWater == true)
        {
            textWindWalksOnWater.SetActive(true);
            textBox.SetActive(true);
            talkingSound.Play();
        }

        if (fireWalksOnEarth == true)
        {
            textFireWalksOnEarth.SetActive(true);
            textBox.SetActive(true);
            talkingSound.Play();
        }
        if (waterWalksOnEarth == true)
        {
            textWaterWalksOnEarth.SetActive(true);
            textBox.SetActive(true);
            talkingSound.Play();
        }
        if (windWalksOnEarth == true)
        {
            textWindWalksOnEarth.SetActive(true);
            textBox.SetActive(true);
            talkingSound.Play();
        }
    }

    void ClearTextBox()
    {
        AllBoolsFalse();
        AllPanelsFalse();
    }
    void AllBoolsFalse()
    {
        fireMeetsFire = false;
        fireMeetsWater = false;
        fireWMeetsEarth = false;
        fireMeetsWind = false;

        waterMeetsFire = false;
        waterMeetsWater = false;
        waterMeetsWind = false;

        earthWindMeetsFire = false;
        earthWindMeetsWater = false;
        earthMeetsEarth = false;
        earthMeetsWind = false;

        windMeetsEarth = false;
        windMeetsWind = false;


        waterWalksOnFire = false;
        earthWalksOnFire = false;
        windWalksOnFire = false;

        fireWalksOnWater = false;
        earthWalksOnWater = false;
        windWalksOnWater = false;

        fireWalksOnEarth = false;
        waterWalksOnEarth = false;
        windWalksOnEarth = false;
    }

    void AllPanelsFalse()
    {
        textBox.SetActive(false);

        textFireMeetsFire.SetActive(false);
        textWaterMeetsFire.SetActive(false);
        textEarthWindMeetFire.SetActive(false);

        textFireMeetsWater.SetActive(false);
        textWaterMeetsWater.SetActive(false);
        textEarthWindMeetWater.SetActive(false);

        textFireWaterMeetEarth.SetActive(false);
        testEarthMeetsEarth.SetActive(false);
        textWindMeetsEarth.SetActive(false);

        textFireMeetsWind.SetActive(false);
        textWaterMeetsWind.SetActive(false);
        textEarthMeetsWind.SetActive(false);
        textWindMeetsWind.SetActive(false);


        textWaterWalksOnFire.SetActive(false);
        textEarthWalksOnFire.SetActive(false);
        textWindWalksOnFire.SetActive(false);

        textFireWalksOnWater.SetActive(false);
        textEarthWalksOnWater.SetActive(false);
        textWindWalksOnWater.SetActive(false);

        textFireWalksOnEarth.SetActive(false);
        textWaterWalksOnEarth.SetActive(false);
        textWindWalksOnEarth.SetActive(false);
    }
}
