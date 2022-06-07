using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level : MonoBehaviour
{
    private Transform hook;
    private Transform pipe;
    private const float PIPE_WIDTH = 3.29f;
    private List<Transform> hookList;
    private float hookspawntimer;
    private float hookspawntimermax;
    private float newhookposition;

    private float pipespawntimer;
    private float pipespawntimermax;
    private float newpipeposition ;

    
    

 

    private void Awake()
    {
        
        newpipeposition = 14.5f;
        hookspawntimermax = 0.5f;
        pipespawntimermax = 0.5f;
        hookList = new List<Transform>();
    }
    // Start is called before the first frame update
    void Start()
    {
        CreateHook(-5f, 0f);
        CreateHook(-5f, 4f);
        CreateHook(-5f, 8f);


        CreatePipe(-5f, 2.5f);
        CreatePipe(-5f, 6.5f);
        CreatePipe(-5f, 10.5f);
    }
    private void CreateHook(float height, float xPosition)
    {
        Transform hook = Instantiate(GameAssets.GetInstance().pfphook);
        hook.position = new Vector3(xPosition, 0f);
        hookList.Add(hook);
        SpriteRenderer pipeSpriteRenderer = hook.GetComponent<SpriteRenderer>();
        pipeSpriteRenderer.size = new Vector2(PIPE_WIDTH, height);
    }

    private void CreatePipe(float height, float xPosition)
    {
        Transform pipe = Instantiate(GameAssets.GetInstance().pfppipe);
        pipe.localScale = new Vector3(0.17395f, 0.14085f);
        pipe.position = new Vector3(xPosition, height);
        
        SpriteRenderer pipeSpriteRenderer = pipe.GetComponent<SpriteRenderer>();
        pipeSpriteRenderer.size = new Vector2(PIPE_WIDTH, height);
    }

  

   

    // Update is called once per frame
    void Update()
    {
        handlehookspawning();
        handlepipespawning();
    }

    private void handlehookspawning()
    {
        hookspawntimer -= Time.deltaTime;
        if (hookspawntimer < 0)
        {
            hookspawntimer += hookspawntimermax;
            CreateHook(-5f, newhookposition);
            newhookposition += 4f;
        }
    }
    private void handlepipespawning()
    {
        hookspawntimer -= Time.deltaTime;
        if (hookspawntimer < 0)
        {
            float randomheight = Random.Range(-5.0f, -2.0f);
            pipespawntimer += pipespawntimermax;
            CreatePipe(randomheight, newpipeposition);
            newpipeposition += 4f;
        }
    }
}

