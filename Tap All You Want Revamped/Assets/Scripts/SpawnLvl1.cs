using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnLvl1 : MonoBehaviour
{
    public Rules rule_script;
    public bool is_starting;
    public int level_count = 0;
    public Image twobytwo_background;
    public Image threebythree_background;
    public GameObject rubber_ducky;
    public GameObject fish;
    public GameObject stop_sign;
    public int number_of_object;
    int spawn_object;
    int object_type;
    bool object_number_started = false;
    public bool is_playing = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        is_starting = rule_script.start_game;
        if (is_starting == true)
        {
            is_starting = false;
            rule_script.start_game = false;
            is_playing = true;
            level_count = level_count + 1;
        }
        if(level_count == 1)
        {
            twobytwo_background.gameObject.SetActive(true);
            if (object_number_started == false)
            {
                number_of_object = 4;
                object_number_started = true;
            }
            //upper left 2 by 2
            if(number_of_object == 4)
            {
                object_type = Random.Range(0, 3);
                if(object_type==0)
                {
                    Instantiate(rubber_ducky, new Vector3(-0.899999976f, 1.60000002f, 0f), new Quaternion(-0.499912739f, 0.500087261f, 0.499912739f, 0.500087261f));
                    number_of_object = number_of_object - 1;
                        
                }
                else if (object_type==1)
                {
                    Instantiate(fish, new Vector3(-1f, 1.70000005f, 0f),new Quaternion(0.5f, 0.5f, 0.5f, -0.5f));
                    number_of_object = number_of_object - 1;
                }
                else if (object_type==2)
                {
                    Instantiate(stop_sign, new Vector3(-0.800000012f, 1.79999995f, 0f),new Quaternion(0f, -1f, 0f, 0f));
                    number_of_object = number_of_object - 1;
                }
                else
                {
                    object_type = Random.Range(0, 3);
                }
            }
            //upper right 2 by 2
            else if (number_of_object == 3)
            {
                object_type = Random.Range(0, 3);
                if (object_type == 0)
                {
                    Instantiate(rubber_ducky, new Vector3(0.600000024f, 1.60000002f, 0f),new Quaternion(-0.499912739f, 0.500087261f, 0.499912739f, 0.500087261f));
                    number_of_object = number_of_object - 1;

                }
                else if (object_type == 1)
                {
                    Instantiate(fish, new Vector3(0.5f, 1.70000005f, 0f),new Quaternion(0.5f, 0.5f, 0.5f, -0.5f));
                    number_of_object = number_of_object - 1;
                }
                else if (object_type == 2)
                {
                    Instantiate(stop_sign, new Vector3(0.75999999f, 1.79999995f, 0f),new Quaternion(0f, -1f, 0f, 0f));
                    number_of_object = number_of_object - 1;
                }
                else
                {
                    object_type = Random.Range(0, 3);
                }
            }
            //lower left 2 by 2
            else if (number_of_object == 2)
            {
                object_type = Random.Range(0, 3);
                if (object_type == 0)
                {
                    Instantiate(rubber_ducky, new Vector3(-0.899999976f, 0f, 0f),new Quaternion(-0.499912739f, 0.500087261f, 0.499912739f, 0.500087261f));
                    number_of_object = number_of_object - 1;

                }
                else if (object_type == 1)
                {
                    Instantiate(fish, new Vector3(-1f, 0.200000003f, 0f),new Quaternion(0.5f, 0.5f, 0.5f, -0.5f));
                    number_of_object = number_of_object - 1;
                }
                else if (object_type == 2)
                {
                    Instantiate(stop_sign, new Vector3(-0.800000012f, 0.200000003f, 0f),new Quaternion(0f, -1f, 0f, 0f));
                    number_of_object = number_of_object - 1;
                }
                else
                {
                    object_type = Random.Range(0, 3);
                }
            }
            //lower right 2 by 2
            else if (number_of_object == 1)
            {
                object_type = Random.Range(0, 3);
                if (object_type == 0)
                {
                    Instantiate(rubber_ducky, new Vector3(0.699999988f, 0f, 0f),new Quaternion(-0.499912739f, 0.500087261f, 0.499912739f, 0.500087261f));
                    number_of_object = number_of_object - 1;

                }
                else if (object_type == 1)
                {
                    Instantiate(fish, new Vector3(0.5f, 0.100000001f, 0f),new Quaternion(0.5f, 0.5f, 0.5f, -0.5f));
                    number_of_object = number_of_object - 1;
                }
                else if (object_type == 2)
                {
                    Instantiate(stop_sign, new Vector3(0.800000012f, 0.200000003f, 0f),new Quaternion(0f, -1f, 0f, 0f));
                    number_of_object = number_of_object - 1;
                }
                else
                {
                    object_type = Random.Range(0, 3);
                }
            }
        }
        if (level_count == 2)
        {
            threebythree_background.gameObject.SetActive(true);
            twobytwo_background.gameObject.SetActive(false);
            number_of_object = 9;
        }
    }
}
