using System.Collections.Generic;
using UnityEngine;
namespace Multimetr
{
    public class MultimetrController : MonoBehaviour, IMultimetrController
    {
        [SerializeField] private List<KeyValue> angels;
        private bool onSwitcher = false;
        private float scroll = 0;
        private GameObject switcher;
        private CircularCounter indexAngel = new CircularCounter(5);
        public void Update()
        {
            CheckMousePosition();
            RotateSwitcher();
        }
        public void RotateSwitcher()
        {
            if (onSwitcher)
            {
                scroll = Input.GetAxis("Mouse ScrollWheel") * 10;
                if (scroll != 0)
                {
                    if (scroll > 0)
                    {
                        indexAngel.Increment();
                    }
                    else if (scroll < 0)
                    {
                        indexAngel.Decrement();
                    }
                    switcher.transform.localEulerAngles = new Vector3(0, 0, angels[indexAngel.CurrentValue - 1].value);
                    EventsMultimetr.TurnSwithcer(angels[indexAngel.CurrentValue - 1].type);
                }
            }
        }
        public void CheckMousePosition()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject.tag == "Switcher")
                {
                    onSwitcher = true;
                    switcher = hit.transform.gameObject;
                }
                else
                {
                    onSwitcher = false;
                }
            }
        }
    }
}