using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Views
{
    public class ClickCount_View : MonoBehaviour
    {
        [Header("�����������")]

        [SerializeField] Models.ClickCount_Model myModel;
        
        [Tooltip("��������� ����, � ������� ������������ ���������� ������")]
        [SerializeField] UnityEngine.UI.Text text;

         public void UpdateShownValue ()
        {
            text.text = $"{myModel.Value}";
        }
        void Start()
        {
            UpdateShownValue();
        }
    }
}
