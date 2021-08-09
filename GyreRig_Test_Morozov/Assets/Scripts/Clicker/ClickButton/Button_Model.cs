using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Models
{
    public class Button_Model : MonoBehaviour
    {
        [Tooltip("Значение, на которое увеличивается счетчик при клике")]
        [SerializeField] private int raisingValue;
        /// <summary>
        /// Значение, на которое увеличивается счетчик при клике
        /// </summary>
        public int RaisingValue => raisingValue;
    }
}
