using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MouseDragScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 screenPoint;
    private Vector3 offset;

    private int points;

    private float timer = 30f;

    public GameObject orderManager;
    private ManageOrders mo;

    public GameObject answer1;
    public GameObject answer2;
    public GameObject answer3;
    public GameObject answer4;

    public GameObject candy1;
    public GameObject candy2;
    public GameObject candy3;
    public GameObject candy4;
    public Text text;
    List<string> childs;
    void Start()
    {

        mo = orderManager.GetComponent<ManageOrders>();
        points = 0;
        childs = new List<string>();
    }
    void checkAnswer()
    {
        List<string> tempMO1 = mo.o1string;
        List<string> tempMO2 = mo.o2string;
        List<string> tempMO3 = mo.o3string;

        //TO DO: check which order is right
        print(childs[0]);
        print(childs[1]);
        print(childs[2]);
        print(childs[3]);

        print(tempMO1[0]);
        print(tempMO1[1]);
        print(tempMO1[2]);
        print(tempMO1[3]);

      

        if ((childs[0] == tempMO1[0] && childs[1] == tempMO1[1] && childs[2] == tempMO1[2] && childs[3] == tempMO1[3]) )
        {
            Debug.Log("perf");
            foreach (Transform child in answer1.transform)
            {
                Destroy(child.gameObject);
            }
            foreach (Transform child in answer2.transform)
            {
                Destroy(child.gameObject);
            }
            foreach (Transform child in answer3.transform)
            {
                Destroy(child.gameObject);
            }
            foreach (Transform child in answer4.transform)
            {
                Destroy(child.gameObject);
            }
            childs.Clear();

            timer += 2.5f;

            mo.makeInitialOrders("1");
        }
        else if ((childs[0] == tempMO2[0] && childs[1] == tempMO2[1] && childs[2] == tempMO2[2] && childs[3] == tempMO2[3]))
        {
            Debug.Log("perf");
            foreach (Transform child in answer1.transform)
            {
                Destroy(child.gameObject);
            }
            foreach (Transform child in answer2.transform)
            {
                Destroy(child.gameObject);
            }
            foreach (Transform child in answer3.transform)
            {
                Destroy(child.gameObject);
            }
            foreach (Transform child in answer4.transform)
            {
                Destroy(child.gameObject);
            }
            childs.Clear();
            timer += 2.5f;

            mo.makeInitialOrders("2");


        }
        else if ((childs[0] == tempMO3[0] && childs[1] == tempMO3[1] && childs[2] == tempMO3[2] && childs[3] == tempMO3[3]))
        {
            Debug.Log("perf");
            foreach (Transform child in answer1.transform)
            {
                Destroy(child.gameObject);
            }
            foreach (Transform child in answer2.transform)
            {
                Destroy(child.gameObject);
            }
            foreach (Transform child in answer3.transform)
            {
                Destroy(child.gameObject);
            }
            foreach (Transform child in answer4.transform)
            {
                Destroy(child.gameObject);
            }
            childs.Clear();
            timer += 2.5f;

            mo.makeInitialOrders("3");

        }
        else
        {
            List<string> tempChild = childs;
            tempChild.Sort();
            bool isTrue = false;

            List<string> tempans1 = tempMO1;
            tempans1.Sort();
            int cnt = 0;
            for (int i = 0; i < 4; i++)
            {
                if (tempChild[i] == tempans1[i])
                {
                    isTrue = true;
                    cnt += 1;
                }
            }

            if (isTrue == true && cnt == 4)
            {
                print("is pk");
                foreach (Transform child in answer1.transform)
                {
                    Destroy(child.gameObject);
                }
                foreach (Transform child in answer2.transform)
                {
                    Destroy(child.gameObject);
                }
                foreach (Transform child in answer3.transform)
                {
                    Destroy(child.gameObject);
                }
                foreach (Transform child in answer4.transform)
                {
                    Destroy(child.gameObject);
                }
                childs.Clear();
                timer += 0.5f;

                mo.makeInitialOrders("1");


            }

            else
            {

                List<string> tempans2 = tempMO2;
                tempans2.Sort();
                int cnt2 = 0;
                for (int i = 0; i < 4; i++)
                {
                    if (tempChild[i] == tempans2[i])
                    {
                        isTrue = true;
                        cnt2 += 1;
                    }
                }

                if (isTrue == true && cnt2 == 4)
                {
                    print("is pk");
                    foreach (Transform child in answer1.transform)
                    {
                        Destroy(child.gameObject);
                    }
                    foreach (Transform child in answer2.transform)
                    {
                        Destroy(child.gameObject);
                    }
                    foreach (Transform child in answer3.transform)
                    {
                        Destroy(child.gameObject);
                    }
                    foreach (Transform child in answer4.transform)
                    {
                        Destroy(child.gameObject);
                    }
                    childs.Clear();
                    timer += 0.5f;

                    mo.makeInitialOrders("2");

                }


                else 
                {
                    List<string> tempans3 = tempMO3;
                    tempans3.Sort();
                    int cnt3 = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        if (tempChild[i] == tempans3[i])
                        {
                            isTrue = true;
                            cnt3 += 1;
                        }
                    }

                    if (isTrue == true && cnt3 == 4)
                    {
                        print("is pk");
                        foreach (Transform child in answer1.transform)
                        {
                            Destroy(child.gameObject);
                        }
                        foreach (Transform child in answer2.transform)
                        {
                            Destroy(child.gameObject);
                        }
                        foreach (Transform child in answer3.transform)
                        {
                            Destroy(child.gameObject);
                        }
                        foreach (Transform child in answer4.transform)
                        {
                            Destroy(child.gameObject);
                        }
                        childs.Clear();
                        timer += 0.5f;

                        mo.makeInitialOrders("3");

                    }

                    else
                    {
                        print("Fail");
                        childs.Clear();
                        timer -= 1.5f;

                        foreach (Transform child in answer1.transform)
                        {
                            Destroy(child.gameObject);
                        }
                        foreach (Transform child in answer2.transform)
                        {
                            Destroy(child.gameObject);
                        }
                        foreach (Transform child in answer3.transform)
                        {
                            Destroy(child.gameObject);
                        }
                        foreach (Transform child in answer4.transform)
                        {
                            Destroy(child.gameObject);
                        }
                    }

                }
            }


            
        }

        //RESET GAME


    }

    public void removeThis()
    {
        childs.RemoveAt(childs.Count-1);
        if(answer4.transform.childCount > 0)
        {
            foreach (Transform child in answer4.transform)
            {
                GameObject.Destroy(child.gameObject);
            }
        }
        else if(answer3.transform.childCount > 0)
        {
            foreach (Transform child in answer3.transform)
            {
                GameObject.Destroy(child.gameObject);
            }
            print("Third spot is occupied");
        }
        else if(answer2.transform.childCount > 0)
        {
            foreach (Transform child in answer2.transform)
            {
                GameObject.Destroy(child.gameObject);
            }
            print("Second spot is occupied");
        }
        else if(answer1.transform.childCount > 0)
        {
            foreach (Transform child in answer1.transform)
            {
                GameObject.Destroy(child.gameObject);
            }
            print("First spot is occupied");
        }

    }
    // Update is called once per frame
    void Update()
    {

        timer -= Time.deltaTime;
        text.text = "" + (int)timer;
        if (timer < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
        if (answer1.transform.childCount != 0 && answer2.transform.childCount != 0 && answer3.transform.childCount != 0 && answer4.transform.childCount != 0)
        {
            checkAnswer();
        }
        if (Input.GetMouseButtonDown(0))
        {
            Ray mousePos = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(mousePos, Mathf.Infinity);
            if (hit.collider != null)
            {
                //numImagesActive -= 1;
                if (hit.collider.tag == "1")
                {
                    if (answer1.transform.childCount == 0)

                    {
                        candy1.transform.localScale = new Vector3(1, 1f, 1f);

                        Instantiate(candy1, answer1.transform);
                        childs.Add("1");


                    }
                    else if (answer2.transform.childCount == 0)

                    {
                        candy1.transform.localScale = new Vector3(1, 1f, 1f);

                        Instantiate(candy1, answer2.transform);
                        childs.Add("1");


                    }
                    else if (answer3.transform.childCount == 0)
                    {
                        candy1.transform.localScale = new Vector3(1, 1f, 1f);

                        Instantiate(candy1, answer3.transform);
                        childs.Add("1");


                    }
                    else if (answer4.transform.childCount == 0)
                    {
                        candy1.transform.localScale = new Vector3(1, 1f, 1f);

                        Instantiate(candy1, answer4.transform);
                        childs.Add("1");

                    }
                }

                else if (hit.collider.tag == "2")
                {
                    if (answer1.transform.childCount == 0)
                    {
                        candy2.transform.localScale = new Vector3(1, 1f, 1f);

                        Instantiate(candy2, answer1.transform);
                        childs.Add("2");


                    }
                    else if (answer2.transform.childCount == 0)
                    {
                        candy2.transform.localScale = new Vector3(1, 1f, 1f);

                        Instantiate(candy2, answer2.transform);
                        childs.Add("2");


                    }
                    else if (answer3.transform.childCount == 0)
                    {
                        candy2.transform.localScale = new Vector3(1, 1f, 1f);

                        Instantiate(candy2, answer3.transform);
                        childs.Add("2");


                    }
                    else if (answer4.transform.childCount == 0)
                    {
                        candy2.transform.localScale = new Vector3(1, 1f, 1f);

                        Instantiate(candy2, answer4.transform);
                        childs.Add("2");


                    }
                }
                else if (hit.collider.tag == "3")
                {
                    if (answer1.transform.childCount == 0)
                    {
                        candy3.transform.localScale = new Vector3(1, 1f, 1f);

                        Instantiate(candy3, answer1.transform);
                        childs.Add("3");


                    }
                    else if (answer2.transform.childCount == 0)
                    {
                        candy3.transform.localScale = new Vector3(1, 1f, 1f);

                        Instantiate(candy3, answer2.transform);
                        childs.Add("3");


                    }
                    else if (answer3.transform.childCount == 0)
                    {
                        candy3.transform.localScale = new Vector3(1, 1f, 1f);

                        Instantiate(candy3, answer3.transform);
                        childs.Add("3");


                    }
                    else if (answer4.transform.childCount == 0)
                    {
                        candy3.transform.localScale = new Vector3(1, 1f, 1f);

                        Instantiate(candy3, answer4.transform);
                        childs.Add("3");
                    }

                }

                else if (hit.collider.tag == "4")
                {
                    if (answer1.transform.childCount == 0)
                    {
                        candy4.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);

                        Instantiate(candy4, answer1.transform);
                        childs.Add("4");


                    }
                    else if (answer2.transform.childCount == 0)

                    {
                        candy4.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);

                        Instantiate(candy4, answer2.transform);
                        childs.Add("4");


                    }
                    else if (answer3.transform.childCount == 0)
                    {
                        candy4.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);

                        Instantiate(candy4, answer3.transform);
                        childs.Add("4");


                    }
                    else if (answer4.transform.childCount == 0)

                    {
                        candy4.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);

                        Instantiate(candy4, answer4.transform);
                        childs.Add("4");

                    }
                }
            }

            else
            {
                //addImages();
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }

    }


    void OnMouseDown()
    {
       /* screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));*/

    }
    void OnMouseDrag()
    {
        /*Vector3 cursorScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorScreenPoint) + offset;
        transform.position = cursorPosition;*/
    }
}
