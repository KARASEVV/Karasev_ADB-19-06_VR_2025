using UnityEngine;

public class Based : MonoBehaviour
{
    public int age = 0;
    public float speed = 0;
    public double haight = 0;
    public string name = "Petr";
    public bool IsSet = false;
    public int[] int_array;
    public GameObject cube;
    public Light lamp;
    void Start()
    {
        //print("Все ясно, автору "+age+" лет");
        /*for(int i = 5; i>=0; i--)
        {
            print(i);
        }
        while(age> 10)
        {
            age--;
            print(age);
        }
        do{
            age--;
            print(age);
        }while(age> 10);
        foreach(int a in int_array)
        {
            int t =0;
            t = a*10;
            print(t);
        }*/
    }
    void Awake()
    {
        cube.GetComponent<CubeManager>().name = "Шар";
        //print("Called from Awake");
    }
    void FixedUpdate()
    {
        //Debug.Log("Called from FixedUpdate");
    }
    void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Q)){
            print("Нажата Q");
            IsSet =true;
        }
        if(Input.GetKeyUp(KeyCode.Q)){
            print("Отжата Q");
            IsSet = false;
        }
        if(Input.GetMouseButtonDown(0)){
            print("Отжата mouse");
            IsSet = false;
        }
        if (IsSet)
        {
            print("heh");
        }
    }
}
