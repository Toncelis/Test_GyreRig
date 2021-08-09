using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Models
{
    public class ClickCount_Model : MonoBehaviour
    {
        [Tooltip("���������� ������, �������� �� ��������� <=> ��������� ��������")]
        [SerializeField] private int value;
        public int Value => value;

        [Header("�����������")]
        [SerializeField] private Views.ClickCount_View myView;

        public void Raise (int raisingValue)
        {
            value += raisingValue;
            myView.UpdateShownValue();
        }

    }
}
