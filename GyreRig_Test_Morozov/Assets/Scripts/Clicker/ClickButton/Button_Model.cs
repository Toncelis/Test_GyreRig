using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Models
{
    public class Button_Model : MonoBehaviour
    {
        [Tooltip("��������, �� ������� ������������� ������� ��� �����")]
        [SerializeField] private int raisingValue;
        /// <summary>
        /// ��������, �� ������� ������������� ������� ��� �����
        /// </summary>
        public int RaisingValue => raisingValue;
    }
}
