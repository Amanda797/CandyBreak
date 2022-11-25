using UnityEngine;

public class Level : MonoBehaviour
{
    //paramaters

    //Serialized for debugging
    [SerializeField] int breakableBlocks;

    //cached reference
    SceneLoader sceneloader;

    private void Start()
    {
        sceneloader = FindObjectOfType<SceneLoader>();
    }

    private void Update()
    {
        AdvanceLevel();
    }

    public void CountBlocks()
    {
        breakableBlocks++;
    }

    public void BlockDestroyed()
    {
        breakableBlocks--;
        if (breakableBlocks <= 0)
        {
            sceneloader.LoadNextScene();
        }
    }

    //TODO: REMOVE LATER - TEST ONLY
    void AdvanceLevel()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            sceneloader.LoadNextScene();
        }
    }
    
}
