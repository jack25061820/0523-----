using UnityEngine;
namespace PAYA
{
    /// <summary>
    /// ���a����t��
    /// �������B�o�g�u�]
    /// </summary>
    public class SystemControl : MonoBehaviour
    {
        #region ���
        //gameObject �C������
        //�s�񶥼h���O���Ϊ̱M�פ�������

        [Header("�b�Y")]
        public GameObject arrow;

        [Header("����t��"), Range(0, 500)]
        public float speedTurn = 10.5f;

        [Header("�u�]�w�s��")]
        public GameObject marble;

        [Header("�u�]�i�H�o�g���`��"), Range(0, 100)]
        public int canShootMarbleTotal = 15;
        #endregion

    #region �ƥ�
    #endregion
        #region ��k
        private void turnCharacter()
        {

        }
        private void ShootMarble()
        {

        }
        private void RecycleMarble()
        {

        }

        #endregion
    }
}