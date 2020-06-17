using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace CT011_部品本登録画面
{
    class CheckClass
    {

        public string Check_DataGridView(){
            //変数定義
            CT011 CT011 = new CT011();

            string test = CT011.dataGridView1[0, 1].Value.ToString();

            return test;

        }

    }
}
