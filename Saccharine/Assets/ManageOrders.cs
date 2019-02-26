using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ManageOrders : MonoBehaviour
{
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

    [SerializeField] private GameObject candy1;
    [SerializeField] private GameObject candy2;
    [SerializeField] private GameObject candy3;
    [SerializeField] private GameObject candy4;

    private string orderString;

    public float delay;

    public float timer;

    public List<string> o1string;
    public List<string> o2string;
    public List<string> o3string;

    [SerializeField]
    private List<GameObject> o1;
    [SerializeField]
    private List<GameObject> o2;
    [SerializeField]
    private List<GameObject> o3;
    [SerializeField]
    private List<GameObject> candies;



    // Start is called before the first frame update
    void Start()
    {
        timer = 30f;

        delay = 3.0f;

        o1string = new List<string>();
        o2string = new List<string>();
        o3string = new List<string>();





        candy1.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        candy2.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        candy3.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        candy4.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);

        makeInitialOrders("123");


    }

    public void makeInitialOrders(string num)
    {
        if (num == "1")
        {
            for (int i = 0; i < 4; i++)
            {
                candy1.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                candy2.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                candy3.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                candy4.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);

                foreach (Transform child in o1[i].transform)
                {
                    Destroy(child.gameObject);
                }

                int index = Random.Range(0, 4);
                Instantiate(candies[index], o1[i].transform);
                string tag = (candies[index].gameObject.tag);
                o1string[i] = tag;
                
            }
        }
        else if (num == "2")
        {


            for (int i = 0; i < 4; i++)
            {
                candy1.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                candy2.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                candy3.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                candy4.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);

                int index = Random.Range(0, 4);

                foreach (Transform child in o2[i].transform)
                {
                    Destroy(child.gameObject);
                }

                Instantiate(candies[index], o2[i].transform);
                string tag = (candies[index].gameObject.tag);
                o2string[i] = tag;

            }
        }
        else if (num == "3")
        {


            for (int i = 0; i < 4; i++)
            {
                candy1.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                candy2.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                candy3.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                candy4.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);

                int index = Random.Range(0, 4);


                foreach (Transform child in o3[i].transform)
                {
                    Destroy(child.gameObject);
                }

                Instantiate(candies[index], o3[i].transform);
                string tag = (candies[index].gameObject.tag);
                o3string[i] = tag;

            }
        }


        else if(num == "123")
        {
           for (int i = 0; i < 4; i++)
            {
                candy1.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                candy2.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                candy3.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                candy4.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);

                foreach (Transform child in o1[i].transform)
                {
                    Destroy(child.gameObject);
                }

                int index = Random.Range(0, 4);
                Instantiate(candies[index], o1[i].transform);
                string tag = (candies[index].gameObject.tag);
                o1string.Add(tag);
                
            }

            for (int i = 0; i < 4; i++)
            {
                candy1.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                candy2.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                candy3.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                candy4.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);

                int index = Random.Range(0, 4);

                foreach (Transform child in o2[i].transform)
                {
                    Destroy(child.gameObject);
                }

                Instantiate(candies[index], o2[i].transform);
                string tag = (candies[index].gameObject.tag);
                o2string.Add(tag);

            }

            for (int i = 0; i < 4; i++)
            {
                candy1.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                candy2.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                candy3.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                candy4.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);

                int index = Random.Range(0, 4);


                foreach (Transform child in o3[i].transform)
                {
                    Destroy(child.gameObject);
                }

                Instantiate(candies[index], o3[i].transform);
                string tag = (candies[index].gameObject.tag);
                o3string.Add(tag);

            }

        }
    }


    // Update is called once per frame
    void Update()
    {
       
    }
    IEnumerator makeOrder()
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);

        }
    }
}
