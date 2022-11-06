using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.FormMain;
using static WindowsFormsApp1.Student;

///////////////////////////////////////////
///学习使用委托  20221103               ///
///////////////////////////////////////////

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Student student=new Student();
            Student.Id = 1;
            Student.Name = "张三";
            Student.Say();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Mydelegate1 my1 = new Mydelegate1(Say);

            Mydelegate1 my1 = Say;
            my1("第二个");

            //Mydelegate1 my1 = x => { } ;
            //my1("第二个");

            //MyDelegate my = new MyDelegate(Say);
            MyDelegate my =Say;
            my();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student.EditAge(int.Parse(textBox1.Text));
            MessageBox.Show("年龄改为了：" + Student.GetAge());

        }
    }
    public class Student
    {
        public delegate void MyDelegate();
        public delegate void Mydelegate1(string msg);
        public static string Name
        {
            get;
            set;
        }
        private static int Age
        {
            get;
            set;
        }

        public static int Id
        {
            get;
            set;
        }
        public static void EditAge(int age)
        {
            if (age>0 && age<150)
            {
                Age = age;
            }
            else
            {
                MessageBox.Show("年龄应该在0-15之间");
            }
            
        }
        public static int GetAge()
        {
            return Age;
        }
        public static void Say()
        {
            MessageBox.Show("老师好！");
        }
        public static void Say(string msg)
        {
            MessageBox.Show(msg);
        }

    }


}
