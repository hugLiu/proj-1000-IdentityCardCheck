using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IdentityCardCheck
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            lab_error.Text = CheckIDCard(tb_id.Text );
        }


         public string CheckIDCard(string idNumber)  
        {
      
             string errorMessage="";

            if (idNumber.Length == 18)  
            {
                errorMessage = CheckIDCard18(idNumber);  //18位校核 ，正确返回true，错误返回false
            }  
            else if (idNumber.Length == 15)  
            {
                errorMessage = CheckIDCard15(idNumber);//15位校核，正确返回true，错误返回false
            }  
            else  //身份证号长度不是15或18位
            {
 
                    errorMessage = "身份证号应为18位或15位长度。";
                 
            }
             return errorMessage;
            
           


        }
       

        /// <summary>
        /// 18位身份证号码验证
        /// </summary>
        /// <param name="idNumber"></param>
        /// <returns></returns>
        public string  CheckIDCard18(string idNumber )
        {
            long n = 0;
            if (long.TryParse(idNumber.Remove(17), out n) == false || n < Math.Pow(10, 16) || long.TryParse(idNumber.Replace('x', '0').Replace('X', '0'), out n) == false)
            {
                  return "数字验证失败。" ;//数字验证  
            }
            string address = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91";
            if (address.IndexOf(idNumber.Remove(2)) == -1)
            {
                return "省份位"+idNumber.Remove(2)+"验证失败，前两位应为11|22|35|44|53|12|23|36|45|54|13|31|37|46|61|14|32|41|50|62|15|33|42|51|63|21|34|43|52|64|65|71|81|82|91。";//省份验证  
            }
            string birth = idNumber.Substring(6, 8).Insert(6, "-").Insert(4, "-");
            DateTime time = new DateTime();
            if (DateTime.TryParse(birth, out time) == false)
            {
               return "生日位"+birth+"验证失败。" ;;//生日验证  
            }
            string[] arrVarifyCode = ("1,0,x,9,8,7,6,5,4,3,2").Split(',');
            string[] Wi = ("7,9,10,5,8,4,2,1,6,3,7,9,10,5,8,4,2").Split(',');
            char[] Ai = idNumber.Remove(17).ToCharArray();
            int sum = 0;
            for (int i = 0; i < 17; i++)
            {
                sum += int.Parse(Wi[i]) * int.Parse(Ai[i].ToString());
            }
            int y = -1;
            Math.DivRem(sum, 11, out y);
            Console.WriteLine("Y的理论值: " + y);
            if (arrVarifyCode[y] != idNumber.Substring(17, 1).ToLower())
            {
                return "校验码验证失败，应为"+arrVarifyCode[y]+"。";//校验码验证  
            }
            return "通过校验！";//符合GB11643-1999标准  
        }





  
        /// <summary>  
        /// 15位身份证号码验证  
        /// </summary>  
        private string  CheckIDCard15(string idNumber)  
        {  
            long n = 0;  
            if (long.TryParse(idNumber, out n) == false || n < Math.Pow(10, 14))  
            {  
                 return "数字验证失败。" ;//数字验证  
            }  
            string address = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91";  
            if (address.IndexOf(idNumber.Remove(2)) == -1)  
            {  
                 return "省份位"+idNumber.Remove(2)+"验证失败，前两位应为11|22|35|44|53|12|23|36|45|54|13|31|37|46|61|14|32|41|50|62|15|33|42|51|63|21|34|43|52|64|65|71|81|82|91。";//省份验证  
            }  
            string birth = idNumber.Substring(6, 6).Insert(4, "-").Insert(2, "-");  
            DateTime time = new DateTime();  
            if (DateTime.TryParse(birth, out time) == false)  
            {  
                return "生日位"+birth+"验证失败。" ;//生日验证  
            }
            return "通过校验！";  
        }   

       

        private void tb_id_TextChanged(object sender, EventArgs e)
        {
            
                lab_num.Text =" 已录入字数："+tb_id.Text.Length.ToString();
        }


    }
}
