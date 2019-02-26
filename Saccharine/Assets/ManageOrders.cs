using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    private float delay;

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = 30f;

        delay = 3.0f;

        candy1.transform.localScale= new Vector3(0.5f,0.5f,0.5f);
        candy2.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        candy3.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        candy4.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);

        makeInitialOrders();

        Instantiate(candy1, order1.transform);
        Instantiate(candy2, order2.transform);
        Instantiate(candy3, order3.transform);
        Instantiate(candy4, order4.transform);

    }

    private void makeInitialOrders()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer % 5 == 0)
        {
            delay -= 0.5f;
        }
    }
    IEnumerator makeOrder()
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);

        }
    }
}
