using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT012_製品生産画面 {
    public class Calculator {
        public int AddNumber(int x, int y){
            if (x < 0 || y < 0) throw new ApplicationException("0 以上の数値を指定してください");
            return x;
            //return x + y;
          }
}
    }

