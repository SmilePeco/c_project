using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT012_製品生産画面
{
    class Check
    {

        //////////////////////////////////////////////////
        //使用部品１～３の残数計算チェック処理          //
        //残数－使用数＝０ の場合は、FALSE              //
        //OutputParts:残数                              //
        //OutputConsume:使用数                          //
        //////////////////////////////////////////////////
        public Boolean OuputValues(int[] OutputConsume, string[] lblPartsNo, int[] OutputParts){

            //使用部品コード１の計算
            if (OutputConsume[0] != 0){
                OutputParts[0] -= OutputConsume[0];
                if (OutputParts[0] < 0) { return false; }
            }
            
            //使用部品コード２の計算
            if (OutputConsume[1] != 0){
                //部品登録NO２＝１なら、残数を代入
                if (lblPartsNo[0] == lblPartsNo[1]) { OutputParts[1] = OutputParts[0]; }
                OutputParts[1] -= OutputConsume[1];
                if (OutputParts[1] < 0) { return false; }
            }

            ///使用部品コード３の計算
            if (OutputConsume[2] != 0){
                //部品登録NO３＝１かつ２なら、２の残数を代入
                //また、部品登録NO３＝２なら、２の残数。　３＝１なら、１の残数を代入する。
                if (lblPartsNo[2] == lblPartsNo[1] && lblPartsNo[2] == lblPartsNo[0]) { OutputParts[2] = OutputParts[1]; }
                else if (lblPartsNo[2] == lblPartsNo[1]) { OutputParts[2] = OutputParts[1]; }
                else if (lblPartsNo[2] == lblPartsNo[0]) { OutputParts[2] = OutputParts[0]; }
                OutputParts[2] -= OutputConsume[2];
                if (OutputParts[2] < 0) { return false; }
            }
             
            return true;
        }






    }
}
