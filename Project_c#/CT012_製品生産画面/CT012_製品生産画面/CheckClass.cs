using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT012_製品生産画面
{
    class CheckClass
    {

        //////////////////////////////////////////////////
        //使用部品の残数計算チェック処理                //
        //////////////////////////////////////////////////
        public Boolean Check_OuputValues(int intOutputConsumeNumber1, string strOutputPartsNo1, int intOutputPartsNumber1, int intOutputConsumeNumber2, string strOutputPartsNo2, int intOutputPartsNumber2, int intOutputConsumeNumber3, string strOutputPartsNo3, int intOutputPartsNumber3){


            ////使用部品コード１の計算（使用数が空白なら無視）
            if (intOutputConsumeNumber1 != 0){
                //部品登録NO１の残数から、使用部品１の消費数を減算
                intOutputPartsNumber1 = intOutputPartsNumber1 - intOutputConsumeNumber1;
                //計算式が０以下ならエラー
                if (intOutputPartsNumber1 < 0) { return false; }
            }

            
            ////使用部品コード２の計算（使用数が空白なら無視）
            if (intOutputConsumeNumber2 != 0){
                //部品登録NOが１と同じなら、残数を代入
                if (strOutputPartsNo1 == strOutputPartsNo2) { intOutputPartsNumber2 = intOutputPartsNumber1; }
                //部品登録NO２の残数から、使用部品２の消費数を減算
                intOutputPartsNumber2 = intOutputPartsNumber2 - intOutputConsumeNumber2;
                //計算式が０以下ならエラー
                if (intOutputPartsNumber2 < 0) { return false; }
            }

            /////使用部品コード３の計算
            if (intOutputConsumeNumber3 != 0){
                //部品登録NO１、２と同じなら、２の残数取得
                //部品登録NO１、または２のみの場合は、１から残数取得
                if (strOutputPartsNo3 == strOutputPartsNo2 && strOutputPartsNo3 == strOutputPartsNo1) { intOutputPartsNumber3 = intOutputPartsNumber2; }
                if (strOutputPartsNo3 == strOutputPartsNo2) { intOutputPartsNumber3 = intOutputPartsNumber2; }
                if (strOutputPartsNo3 == strOutputPartsNo1) { intOutputPartsNumber3 = intOutputPartsNumber1; }
                //部品登録NO３の残数から、使用部品３の消費数を減算
                intOutputPartsNumber3 = intOutputPartsNumber3 - intOutputConsumeNumber3;
                //計算式が０以下ならエラー
                if (intOutputPartsNumber3 < 0) { return false; }
            }

            //問題なければ、TRUEをかえす
            return true;
        }

    }
}
