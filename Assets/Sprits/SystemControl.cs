using UnityEngine;
namespace PAYA
{
    /// <summary>
    /// 玩家控制系統
    /// 物件旋轉、發射彈珠
    /// </summary>
    public class SystemControl : MonoBehaviour
    {
        #region 資料
        //gameObject 遊戲物件
        //存放階層面板內或者專案內的物件

        [Header("箭頭")]
        public GameObject arrow;

        [Header("旋轉速度"), Range(0, 500)]
        public float speedTurn = 10.5f;

        [Header("彈珠預製物")]
        public GameObject marble;

        [Header("彈珠可以發射的總數"), Range(0, 100)]
        public int canShootMarbleTotal = 15;
        #endregion

    #region 事件
    #endregion
        #region 方法
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