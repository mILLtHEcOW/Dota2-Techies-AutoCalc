using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechiesClac
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormTechiesCalc());            
        }
    }

    public static class ClacData
    {

        //伤害基准为150，如等级1数值为2，等级1炸弹伤害为2*150 = 300，如果配备A杖则加1，如等级3配备A杖伤害为 (4+1)*150 = 750;
        public static int skillLevel = 2;
        public static int equipA = 0;
        public static int bombDamageBase = 150;
        public static double resistance = 0.25f;

        public static int DamageResult(int bombNumber) //伤害计算公式
        {
            return Convert.ToInt32((skillLevel + equipA) * bombDamageBase * bombNumber * (1 - resistance));
        }

        
    }
}
