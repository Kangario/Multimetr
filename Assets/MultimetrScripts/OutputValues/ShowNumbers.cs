using TMPro;
using UnityEngine;
namespace Multimetr
{
    public class ShowNumbers : MonoBehaviour , IShowNumbers
    {
        private GameObject panelMultimetr;
        private GameObject panelCanvas;
        public void Start()
        {
            panelMultimetr = OutputTextCounter.outputText;
            panelCanvas = OutputCanvasCounter.outputTextCanvas;
            EventsMultimetr.OnShowValues += ShowValues;
        }
        public void ShowValues(MultimetrValues values, TypeValue typeValue)
        {
            panelCanvas.GetComponent<TMP_Text>().text = values.ToString();
            switch (typeValue)
            {
                case TypeValue.resistance:
                    panelMultimetr.GetComponent<TMP_Text>().text = values.resistance.ToString();
                    break;
                case TypeValue.currentStrangth:
                    panelMultimetr.GetComponent<TMP_Text>().text = values.currentStrangth.ToString();
                    break;
                case TypeValue.voltageDC:
                    panelMultimetr.GetComponent<TMP_Text>().text = values.voltageDC.ToString();
                    break;
                case TypeValue.voltageAC:
                    panelMultimetr.GetComponent<TMP_Text>().text = values.voltageAC.ToString();
                    break;
                default:
                    panelMultimetr.GetComponent<TMP_Text>().text = "0";
                    break;
            }
        }

    }
}
