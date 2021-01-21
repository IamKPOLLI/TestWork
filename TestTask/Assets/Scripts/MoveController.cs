using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class MoveController : MonoBehaviour
{
    [SerializeField] private Text _speedLabel;
    [SerializeField] private Camera _camera;
    public Vector2 startMarker;
    public Vector2 endMarker;
    public float speed;
    private Queue<Vector2> _points; 
   

    

    



    void Start()
    {
        ChangeSpeed(1f);
        startMarker = transform.position;
        endMarker = transform.position;
        _points = new Queue<Vector2>();
    }


    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
           _points.Enqueue(_camera.ScreenToWorldPoint(Input.mousePosition));
        }



        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, endMarker, step);

        if(transform.position.x == endMarker.x && transform.position.y == endMarker.y && _points.Count != 0)
        {
            endMarker = _points.Dequeue();
        }
    }

   public void ChangeSpeed(float new_speed)
    {
        speed = new_speed;
        _speedLabel.text = new_speed.ToString();
    }

}
