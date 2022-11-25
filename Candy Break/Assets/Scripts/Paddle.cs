using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Configuration Paramaters
    [SerializeField] float minX = -10f;
    [SerializeField] float maxX = 10f;

    [SerializeField] float screenWidthInUnits = 16f;

    private Camera mainCam;

    // Start is called before the first frame update
    void Start()
    {
        mainCam = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePaddle();
    }

    private void MovePaddle()
    {
        Vector3 mousePosInUnits = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePosInUnits.x, minX, maxX);
        transform.position = paddlePos;
    }
}
