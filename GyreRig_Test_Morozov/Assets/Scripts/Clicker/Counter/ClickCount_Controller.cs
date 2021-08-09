using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Controllers
{
    public class ClickCount_Controller : MonoBehaviour
    {
        [Header("Зависимости")]
        [SerializeField] Models.ClickCount_Model myModel;

        public void Raise(int raisingValue)
        {
            myModel.Raise(raisingValue);
        }
    }
}
