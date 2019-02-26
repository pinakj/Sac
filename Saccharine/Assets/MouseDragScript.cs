using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseDragScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 screenPoint;
    private Vector3 offset;

    [SerializeField] private GameObject order1;
    [SerializeField] private GameObject order2;
    [SerializeField] private GameObject order3;
    [SerializeField] private GameObject order4;
    [SerializeField] private GameObject order5;
    [SerializeField] private GameObject order6;
    [SerializeField] private GameObject order7;
    [SerializeField] private GameObject order8;
    [SerializeField] private GameObject order9;
    [SerializeField] private GameObject order10;
    [SerializeField] private GameObject order11;
    [SerializeField] private GameObject order12;

    private List<GameObject> O1;
    private List<GameObject> O2;
    private List<GameObject> O3;

    private int points;


    public GameObject answer1;
    public GameObject answer2;
    public GameObject answer3;
    public GameObject answer4;

    public GameObject candy1;
    public GameObject candy2;
    public GameObject candy3;
    public GameObject candy4;
    void Start()
    {
        O1.Add(order1);
        O1.Add(order2);
        O1.Add(order3);
        O1.Add(order4);
        O2.Add(order5);
        O2.Add(order6);
        O2.Add(order7);
        O2.Add(order8);
        O3.Add(order9);
        O3.Add(order10);
        O3.Add(order11);
        O3.Add(order12);

        points = 0;
    }
    void checkAnswer()
    {
        List<GameObject> tempo1 = O1;
        List<GameObject> tempo2 = O2;
        List<GameObject> tempo3 = O3;

    }
    // Update is called once per frame
    void Update()
    {
        if(answer1.transform.childCount != 0 && answer2.transform.childCount != 0 && answer3.transform.childCount != 0 && answer4.transform.childCount != 0)
        {
            checkAnswer();
        }
        if (Input.GetMouseButtonDown(0))
        {
            Ray mousePos = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(mousePos, Mathf.Infinity);
            if (hit.collider != null)
            {
                //Destroy(hit.collider.gameObject);
                //numImagesActive -= 1;
                if(hit.collider.tag == "1")
                {
                    if (answer1.transform.childCount == 0)

                    {
                        candy1.transform.localScale = new Vector3(1, 1f, 1f);

                        Instantiate(candy1, answer1.transform);

                    }
                    else if (answer2.transform.childCount == 0)

                    {
                        candy1.transform.localScale = new Vector3(1, 1f, 1f);

                        Instantiate(candy1, answer2.transform);

                    }
                    else if (answer3.transform.childCount == 0)
                    {
                        candy1.transform.localScale = new Vector3(1, 1f, 1f);

                        Instantiate(candy1, answer3.transform);

                    }
                    else if (answer4.transform.childCount == 0)
                    {
                        candy1.transform.localScale = new Vector3(1, 1f, 1f);

                        Instantiate(candy1, answer4.transform);

                    }
                }

                else if (hit.collider.tag == "2")
                {
                    if (answer1.transform.childCount == 0)
                    {
                        candy2.transform.localScale = new Vector3(1, 1f, 1f);

                        Instantiate(candy2, answer1.transform);

                    }
                    else if (answer2.transform.childCount == 0)
                    {
                        candy2.transform.localScale = new Vector3(1, 1f, 1f);

                        Instantiate(candy2, answer2.transform);

                    }
                    else if (answer3.transform.childCount == 0)
                    {
                        candy2.transform.localScale = new Vector3(1, 1f, 1f);

                        Instantiate(candy2, answer3.transform);

                    }
                    else if (answer4.transform.childCount == 0)
                    {
                        candy2.transform.localScale = new Vector3(1, 1f, 1f);

                        Instantiate(candy2, answer4.transform);

                    }
                }
                else if (hit.collider.tag == "3")
                {
                    if (answer1.transform.childCount == 0)
                    {
                        candy3.transform.localScale = new Vector3(1, 1f, 1f);

                        Instantiate(candy3, answer1.transform);

                    }
                    else if (answer2.transform.childCount == 0)
                    {
                        candy3.transform.localScale = new Vector3(1, 1f, 1f);

                        Instantiate(candy3, answer2.transform);

                    }
                    else if (answer3.transform.childCount == 0)
                    {
                        candy3.transform.localScale = new Vector3(1, 1f, 1f);

                        Instantiate(candy3, answer3.transform);

                    }
                    else if (answer4.transform.childCount == 0)
                    {
                        candy3.transform.localScale = new Vector3(1, 1f, 1f);

                        Instantiate(candy3, answer4.transform);

                    }
                }
                else if (hit.collider.tag == "4")
                {
                    if (answer1.transform.childCount == 0)
                    {
                        candy4.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);

                        Instantiate(candy4, answer1.transform);

                    }
                    else if (answer2.transform.childCount == 0)

                    {
                        candy4.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);

                        Instantiate(candy4, answer2.transform);

                    }
                    else if (answer3.transform.childCount == 0)
                    {
                        candy4.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);

                        Instantiate(candy4, answer3.transform);

                    }
                    else if (answer4.transform.childCount == 0)

                    {
                        candy4.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);

                        Instantiate(candy4, answer4.transform);

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
