using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaterialSkin.Controls
{
    public partial class Toast : MaterialForm
    {
        public int time;
        public Form BaseForm;

        public Toast()
        {
            InitializeComponent();
        }


        public static Toast MakeText(Form form, string Message, int time)
        {
            if (form == null)
                return null;
            Toast toast = new Toast();
            toast.SetMessage(Message);
            toast.BaseForm = form;
            int Left= form.Left;
            int Top = form.Top;
            int x, y;
            x = Left + form.Width / 2 - toast.Width/2;
            y = Top + form.Height / 2 - toast.Height-2;
            toast.time = time;
            toast.Left = x;
            toast.Top = y;
            
            return toast;
        }


        public new void Show() 
        {
            this.timer1.Interval = time;
            this.timer1.Start();
            base.Show(BaseForm);
        }




        int RowNum = 30;   //每行显示的字数
        //根据内容设置控件大小
        public void SetMessage(string message)
        {
            if (message.Length > RowNum)
            {
                //需要换行
                message = BreakLongString(message, RowNum);
            }

            this.lblMessage.Text = message;
           
            if (lblMessage.Height > 44)
            {
                this.Height = lblMessage.Height;
            }
        }

        public static string BreakLongString(string SubjectString, int lineLength)
        {
            StringBuilder sb = new StringBuilder(SubjectString);
            int offset = 0;
            ArrayList indexList = buildInsertIndexList(SubjectString, lineLength);
            for (int i = 0; i < indexList.Count; i++)
            {
                sb.Insert((int)indexList[i] + offset, '\n');
                offset++;
            }
            return sb.ToString();
        }

        public static bool IsChinese(char c)
        {
            return (int)c >= 0x4E00 && (int)c <= 0x9FA5;
        }

        private static ArrayList buildInsertIndexList(string str, int maxLen)
        {
            int nowLen = 0;
            ArrayList list = new ArrayList();
            for (int i = 1; i < str.Length; i++)
            {
                if (IsChinese(str[i]))
                {
                    nowLen += 2;
                }
                else
                {
                    nowLen++;
                }
                if (nowLen > maxLen)
                {
                    nowLen = 0;
                    list.Add(i);
                }
            }
            return list;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }


    }

}
