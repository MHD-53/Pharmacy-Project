using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using Guna.UI2.WinForms;
using System.Drawing;   

namespace Pharmacy_Project
{
    public class TimerHelper
    {
        private static int _secondsPassed = 0;
        private static Guna2HtmlLabel _targetLabel;
        private static Timer _targetTimer;

        // متغيرات لحفظ الأوقات والكلمات 
        private static int _timeForFirstWord;
        private static int _totalTime;
        private static string _secondWord;

        // الالوان
        private static Color _SecondColor = Color.Green;

        public static void ShowTwoMessages(Guna2HtmlLabel label, Timer timer, string firstMsg, Color firstcolor,string secondMsg, Color secondcolor,int firstMsgDuration, int secondMsgDuration)
        {
            _targetLabel = label;
            _targetTimer = timer;
            _secondWord = secondMsg;
            _SecondColor = secondcolor;

            // هنا يتم حساب الأوقات تلقائياً بناءً على ما تحدده 
            _timeForFirstWord = firstMsgDuration;
            _totalTime = firstMsgDuration + secondMsgDuration; // الوقت الإجمالي للاختفاء

            _secondsPassed = 0;
            _targetLabel.Text = firstMsg; // إظهار الكلمة الأولى 
            _targetLabel.ForeColor = firstcolor; // تعيين لون الكلمة الأولى
            _targetLabel.Visible = true;

            //  المؤقت يعمل كل ثانية
            _targetTimer.Stop();
            _targetTimer.Tick -= Timer_Tick;
            _targetTimer.Tick += Timer_Tick;
            _targetTimer.Interval = 1000;
            _targetTimer.Start();
        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            _secondsPassed++;

            // تغيير الكلمة بعد انتهاء وقت الكلمة الأولى
            if (_secondsPassed == _timeForFirstWord)
            {
                _targetLabel.Text = _secondWord;
                _targetLabel.ForeColor = _SecondColor;
            }

            // اخفاء المؤقت بعد انتهاء الوقت الإجمالي
            if (_secondsPassed == _totalTime)
            {
                _targetTimer.Stop();
                _targetLabel.Visible = false;
                _targetTimer.Tick -= Timer_Tick; // تنظيف الذاكرة
            }
        }
    }
}


