using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Controllers
{
    public class Button_Controller : MonoBehaviour
    {
        [Header("Зависимости")]

        [SerializeField] private Models.Button_Model myModel;

        [SerializeField] private ClickCount_Controller counterController;

        public void ClickHappened()
        {
            counterController.Raise(myModel.RaisingValue);
        }
    }
}
