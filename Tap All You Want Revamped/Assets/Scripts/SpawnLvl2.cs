using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnLvl2 : MonoBehaviour
{
    public RulesLvl2 rule_script;
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
        if (level_count == 1)
        {
            threebythree_background.gameObject.SetActive(true);
            if (object_number_started == false)
            {
                number_of_object = 9;
                object_number_started = true;
            }
            //upper left 3 by 3
            if (number_of_object == 9)
            {
                object_type = Random.Range(0, 3);
                if (object_type == 0)
                {
                    Instantiate(rubber_ducky, new Vector3(-1.60000002f, 2.5f, 0f), new Quaternion(-0.499912739f, 0.500087261f, 0.499912739f, 0.500087261f));
                    number_of_object = number_of_object - 1;

                }
                else if (object_type == 1)
                {
                    Instantiate(fish, new Vector3(-1.75f, 2.5f, 0f), new Quaternion(0.5f, 0.5f, 0.5f, -0.5f));
                    number_of_object = number_of_object - 1;
                }
                else if (object_type == 2)
                {
                    Instantiate(stop_sign, new Vector3(-1.5f, 2.5999999f, 0f), new Quaternion(0f, -1f, 0f, 0f));
                    number_of_object = number_of_object - 1;
                }
                else
                {
                    object_type = Random.Range(0, 3);
                }
            }
            //upper mid 3 by 3
            else if (number_of_object == 8)
            {
                object_type = Random.Range(0, 3);
                if (object_type == 0)
                {
                    Instantiate(rubber_ducky, new Vector3(-0.200000003f, 2.5f, 0f), new Quaternion(-0.499912739f, 0.500087261f, 0.499912739f, 0.500087261f));
                    number_of_object = number_of_object - 1;

                }
                else if (object_type == 1)
                {
                    Instantiate(fish, new Vector3(-0.300000012f, 2.5f, 0f), new Quaternion(0.5f, 0.5f, 0.5f, -0.5f));
                    number_of_object = number_of_object - 1;
                }
                else if (object_type == 2)
                {
                    Instantiate(stop_sign, new Vector3(-0.0500000007f, 2.5999999f, 0f), new Quaternion(0f, -1f, 0f, 0f));
                    number_of_object = number_of_object - 1;
                }
                else
                {
                    object_type = Random.Range(0, 3);
                }
            }
            //upper right 3 by 3
            else if (number_of_object == 7)
            {
                object_type = Random.Range(0, 3);
                if (object_type == 0)
                {
                    Instantiate(rubber_ducky, new Vector3(1.29999995f, 2.4000001f, 0f), new Quaternion(-0.499912739f, 0.500087261f, 0.499912739f, 0.500087261f));
                    number_of_object = number_of_object - 1;

                }
                else if (object_type == 1)
                {
                    Instantiate(fish, new Vector3(1.20000005f, 2.5f, 0f), new Quaternion(0.5f, 0.5f, 0.5f, -0.5f));
                    number_of_object = number_of_object - 1;
                }
                else if (object_type == 2)
                {
                    Instantiate(stop_sign, new Vector3(1.47000003f, 2.5999999f, 0f), new Quaternion(0f, -1f, 0f, 0f));
                    number_of_object = number_of_object - 1;
                }
                else
                {
                    object_type = Random.Range(0, 3);
                }
            }
            //mid left 3 by 3
            else if (number_of_object == 6)
            {
                object_type = Random.Range(0, 3);
                if (object_type == 0)
                {
                    Instantiate(rubber_ducky, new Vector3(-1.60000002f, 1f, 0f), new Quaternion(-0.499912739f, 0.500087261f, 0.499912739f, 0.500087261f));
                    number_of_object = number_of_object - 1;

                }
                else if (object_type == 1)
                {
                    Instantiate(fish, new Vector3(-1.79999995f, 1f, 0f), new Quaternion(0.5f, 0.5f, 0.5f, -0.5f));
                    number_of_object = number_of_object - 1;
                }
                else if (object_type == 2)
                {
                    Instantiate(stop_sign, new Vector3(-1.5f, 1.10000002f, 0f), new Quaternion(0f, -1f, 0f, 0f));
                    number_of_object = number_of_object - 1;
                }
                else
                {
                    object_type = Random.Range(0, 3);
                }
            }
            //mid mid 3 by 3
            else if (number_of_object == 5)
            {
                object_type = Random.Range(0, 3);
                if (object_type == 0)
                {
                    Instantiate(rubber_ducky, new Vector3(-0.150000006f, 1f, 0f), new Quaternion(-0.499912739f, 0.500087261f, 0.499912739f, 0.500087261f));
                    number_of_object = number_of_object - 1;

                }
                else if (object_type == 1)
                {
                    Instantiate(fish, new Vector3(-0.300000012f, 1f, 0f), new Quaternion(0.5f, 0.5f, 0.5f, -0.5f));
                    number_of_object = number_of_object - 1;
                }
                else if (object_type == 2)
                {
                    Instantiate(stop_sign, new Vector3(-0.0500000007f, 1.04999995f, 0f), new Quaternion(0f, -1f, 0f, 0f));
                    number_of_object = number_of_object - 1;
                }
                else
                {
                    object_type = Random.Range(0, 3);
                }
            }
            //mid right 3 by 3
            else if (number_of_object == 4)
            {
                object_type = Random.Range(0, 3);
                if (object_type == 0)
                {
                    Instantiate(rubber_ducky, new Vector3(1.39999998f, 0.899999976f, 0f), new Quaternion(-0.499912739f, 0.500087261f, 0.499912739f, 0.500087261f));
                    number_of_object = number_of_object - 1;

                }
                else if (object_type == 1)
                {
                    Instantiate(fish, new Vector3(1.20000005f, 1f, 0f), new Quaternion(0.5f, 0.5f, 0.5f, -0.5f));
                    number_of_object = number_of_object - 1;
                }
                else if (object_type == 2)
                {
                    Instantiate(stop_sign, new Vector3(1.45000005f, 1.04999995f, 0f), new Quaternion(0f, -1f, 0f, 0f));
                    number_of_object = number_of_object - 1;
                }
                else
                {
                    object_type = Random.Range(0, 3);
                }
            }
            //lower left 3 by 3
            else if (number_of_object == 3)
            {
                object_type = Random.Range(0, 3);
                if (object_type == 0)
                {
                    Instantiate(rubber_ducky, new Vector3(-1.70000005f, -0.5f, 0f), new Quaternion(-0.499912739f, 0.500087261f, 0.499912739f, 0.500087261f));
                    number_of_object = number_of_object - 1;

                }
                else if (object_type == 1)
                {
                    Instantiate(fish, new Vector3(-1.79999995f, -0.5f, 0f), new Quaternion(0.5f, 0.5f, 0.5f, -0.5f));
                    number_of_object = number_of_object - 1;
                }
                else if (object_type == 2)
                {
                    Instantiate(stop_sign, new Vector3(-1.5f, -0.449999988f, 0f), new Quaternion(0f, -1f, 0f, 0f));
                    number_of_object = number_of_object - 1;
                }
                else
                {
                    object_type = Random.Range(0, 3);
                }
            }
            //lower mid 3 by 3
            else if (number_of_object == 2)
            {
                object_type = Random.Range(0, 3);
                if (object_type == 0)
                {
                    Instantiate(rubber_ducky, new Vector3(-0.200000003f, -0.5f, 0f), new Quaternion(-0.499912739f, 0.500087261f, 0.499912739f, 0.500087261f));
                    number_of_object = number_of_object - 1;

                }
                else if (object_type == 1)
                {
                    Instantiate(fish, new Vector3(-0.300000012f, -0.5f, 0f), new Quaternion(0.5f, 0.5f, 0.5f, -0.5f));
                    number_of_object = number_of_object - 1;
                }
                else if (object_type == 2)
                {
                    Instantiate(stop_sign, new Vector3(-0.0500000007f, -0.449999988f, 0f), new Quaternion(0f, -1f, 0f, 0f));
                    number_of_object = number_of_object - 1;
                }
                else
                {
                    object_type = Random.Range(0, 3);
                }
            }
            //lower right 3 by 3
            else if (number_of_object == 1)
            {
                object_type = Random.Range(0, 3);
                if (object_type == 0)
                {
                    Instantiate(rubber_ducky, new Vector3(1.39999998f, -0.5f, 0f), new Quaternion(-0.499912739f, 0.500087261f, 0.499912739f, 0.500087261f));
                    number_of_object = number_of_object - 1;

                }
                else if (object_type == 1)
                {
                    Instantiate(fish, new Vector3(1.20000005f, -0.5f, 0f), new Quaternion(0.5f, 0.5f, 0.5f, -0.5f));
                    number_of_object = number_of_object - 1;
                }
                else if (object_type == 2)
                {
                    Instantiate(stop_sign, new Vector3(1.45000005f, -0.449999988f, 0f), new Quaternion(0f, -1f, 0f, 0f));
                    number_of_object = number_of_object - 1;
                }
                else
                {
                    object_type = Random.Range(0, 3);
                }
            }
            }
    }
}
