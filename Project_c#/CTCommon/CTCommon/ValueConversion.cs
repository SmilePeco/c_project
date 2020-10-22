using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCommon {
    public class ValueConversion {

        //////////////////////////////////////////////////
        //文字列→数値変換処理                          //
        //////////////////////////////////////////////////
        public int IntFromString(string ChangeBefore) {

            int ChangeAfter;

            if (ChangeBefore == "") { ChangeAfter = 0; } else { ChangeAfter = Convert.ToInt32(ChangeBefore); }

            return ChangeAfter;


        }


    }
}
