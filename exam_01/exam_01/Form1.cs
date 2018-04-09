using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //匿名類型
            var student = new { school = "泰山國小", name = "Kitty", age = 9 };

            var Products = new[] { new { type="軟體",name = "AVG" },
            new { type="硬體", name="鍵盤"},
            new {type="硬體", name="滑鼠"}
            };

            var Product = from p in Products
                          where p.type == "硬體"
                          select p;
            MessageBox.Show(Product.ToList().First().name);

        }
    }
}
