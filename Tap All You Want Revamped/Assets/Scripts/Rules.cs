using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Rules : MonoBehaviour
{
    public SpawnLvl1 spawn_script;
    public Text choose_tap;
    public Image choose_tap_background;
    public Text ready_text;
    public Image game_over_background;
    public Text game_over_text;
    public Image win_image;
    public Text win_text;
    int choosing_property;
    int choosing_object;
    public string property_string;
    public bool start_game = false;
    public bool game_over;
    public bool is_win;
    public int score;
    public GameObject[] rubber_duckys;
    public GameObject[] fishes;
    public GameObject[] stop_signs;
    public bool scene_loadable = false;
    public bool pause = false;
    // Start is called before the first frame update
    void Start()
    {
        ChooseObject();
        Debug.Log(property_string);
        choose_tap.text = property_string;
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    // Update is called once per frame
    void Update()
    {
        rubber_duckys = GameObject.FindGameObjectsWithTag("rubber_ducky");
        fishes = GameObject.FindGameObjectsWithTag("fish");
        stop_signs = GameObject.FindGameObjectsWithTag("stop_sign");
        if (Input.GetMouseButtonDown(0) && spawn_script.level_count == 0)
        {
            Destroy(choose_tap);
            Destroy(choose_tap_background);
            Destroy(ready_text);
            start_game = true;
        }
        if(property_string == "tap all the rubber ducky")
        {
            if(rubber_duckys.Length == 0)
            {
                is_win = true;
            }
            else
            {
                is_win = false;
            }
        }
        else if (property_string == "tap all the fish")
        {
            if (fishes.Length == 0) 
            {
                is_win = true;
            }
            else
            {
                is_win = false;
            }
        }
        else if (property_string == "tap all the stop sign")
        {
            if(stop_signs.Length == 0)
            {
                is_win = true;
            }
            else
            {
                is_win = false;
            }
        }
        else if (property_string == "tap all except rubber ducky")
        {
            if(stop_signs.Length == 0 && fishes.Length == 0) 
            {
                is_win = true;
            }
            else
            {
                is_win = false;
            }
        }
        else if (property_string == "tap all except fish")
        {
            if(rubber_duckys.Length == 0 && stop_signs.Length == 0)
            {
                is_win = true;
            }
            else
            {
                is_win = false;
            }
        }
        else if (property_string == "tap all except stop sign")
        {
            if(rubber_duckys.Length == 0 && fishes.Length == 0)
            {
                is_win = true;
            }
            else
            {
                is_win = false;
            }
        }
        else
        {
            Debug.Log("property_string error");
        }
        if(is_win == true && spawn_script.is_playing == true && game_over == false)
        {
            win_image.gameObject.SetActive(true);
            win_text.gameObject.SetActive(true);
            if(rubber_duckys.Length > 0 || fishes.Length > 0 || stop_signs.Length > 0)
            {
                foreach (GameObject go in rubber_duckys)
                {
                    Destroy(go);
                }
                foreach (GameObject go in fishes)
                {
                    Destroy(go);
                }
                foreach (GameObject go in stop_signs)
                {
                    Destroy(go);
                }
            }
            scene_loadable = true;
            
            if (Input.GetMouseButtonDown(0)&&scene_loadable==true&& pause==true)
            {
                SceneManager.LoadScene("LevelTwo", LoadSceneMode.Single);
            }
            if(Input.GetMouseButtonDown(0)&&pause == false)
            {
                pause = true;
            }
        }
        else
        {
            win_image.gameObject.SetActive(false);
            win_text.gameObject.SetActive(false);
        }
        if(game_over==true)
        {
            game_over_background.gameObject.SetActive(true);
            game_over_text.gameObject.SetActive(true);
            spawn_script.twobytwo_background.gameObject.SetActive(false);
            if (rubber_duckys.Length > 0 || fishes.Length > 0 || stop_signs.Length > 0)
            {
                foreach (GameObject go in rubber_duckys)
                {
                    Destroy(go);
                }
                foreach (GameObject go in fishes)
                {
                    Destroy(go);
                }
                foreach (GameObject go in stop_signs)
                {
                    Destroy(go);
                }
            }
            scene_loadable = true;
            if (Input.GetMouseButtonDown(0)&&scene_loadable==true&& pause == true)
            {
                SceneManager.LoadScene("LevelOne", LoadSceneMode.Single);
            }
            if (Input.GetMouseButtonDown(0) && pause == false)
            {
                pause = true;
            }
        }
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }


    void ChooseObject()
    {
        choosing_property = Random.Range(0, 2);
        if (choosing_property == 0)
        {
            property_string = "tap all the ";
        }
        else if (choosing_property == 1)
        {
            property_string = "tap all except ";
        }
        else
        {
            ChooseObject();
        }
        choosing_object = Random.Range(0, 3);
        if(choosing_object == 0)
        {
            property_string = property_string + "rubber ducky";
        }
        else if(choosing_object == 1)
        {
            property_string = property_string + "fish";
        }
        else if(choosing_object == 2)
        {
            property_string = property_string + "stop sign";
        }
        else
        {
            ChooseObject();
        }
    }
}
