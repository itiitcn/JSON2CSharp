using JSON2CSharp.Properties;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace JSON2CSharp
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 执行JS
        /// </summary>
        /// <param name="sExpression">参数体</param>
        /// <param name="sCode">JavaScript代码的字符串</param>
        /// <returns></returns>
        private string ExecuteScript(string sExpression, string sCode)
        {
            MSScriptControl.ScriptControl scriptControl = new MSScriptControl.ScriptControl();
            scriptControl.UseSafeSubset = true;
            scriptControl.Language = "JScript";
            scriptControl.AddCode(sCode);
            try
            {
                string str = scriptControl.Eval(sExpression).ToString();
                return str;
            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }
            return null;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            JSON2CC();
        }

        public void JSON2CC()
        {
            if (string.IsNullOrEmpty(this.txtJSON.Text)) return;
            string fun = string.Format(@"JSON2CC('{0}')", this.txtJSON.Text.Trim().Replace("\n", ""));
            string result = ExecuteScript(fun, Resources.JSON2CSharp);
            txtCSharp.Text = result;
        }


        public void Format()
        {
            if (string.IsNullOrEmpty(this.txtJSON.Text)) return;
            string fun = string.Format(@"JSONFormat('{0}')", this.txtJSON.Text.Trim().Replace("\n", ""));
            string result = ExecuteScript(fun, Resources.JSONFormat);
            txtJSON.Text = result;
        }

        private void htnFormat_Click(object sender, EventArgs e)
        {
            Format();
        }


        private void txtJSON_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                Format();
                JSON2CC();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCSharp.Text = "";
            txtJSON.Text = "";
        }

        private void btnCopyCSharp_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCSharp.Text))
            {
                Clipboard.SetDataObject(txtCSharp.Text);
                Toast.MakeText(this, "Successful", 2000).Show();
            }
        }
    }
}
