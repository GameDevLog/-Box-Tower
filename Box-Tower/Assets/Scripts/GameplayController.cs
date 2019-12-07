using UnityEngine;

public class GameplayController : MonoBehaviour
{
    public static GameplayController instance;

    public BoxSwapner boxSwapner;

    [HideInInspector]
    public BoxScript currentBox;

    public CameraFollow cameraScript;
    private int moveCount;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        boxSwapner.SwapBox();
    }

    void Update()
    {
        DetectInput();
    }

    void DetectInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentBox.DropBox();
        }
    }
}
