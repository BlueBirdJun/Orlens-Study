using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Common.Helpers
{
    public class TenbytenHelper
    {

        /// <summary>
        /// 이미지 경로 만들기
        /// </summary>
        /// <param name="itemid"></param>
        /// <param name="urlpath"></param>
        /// <param name="imgname"></param>
        /// <returns></returns>
        public static string GetImagePath(int itemid, string urlpath, string imgname)
        {
            string imgpath = string.Empty;

            imgpath = $"{urlpath}{MakeImageForder(itemid)}/{imgname}";

            return imgpath;
        }

        private static string MakeImageForder(int itemid)
        {
            string strrt = string.Empty;
            int ilen = (itemid / 10000).ToString().Length;
            int foldernum = (itemid / 10000);
            //Num2Str(CStr(Clng(iitemid) / 10000), 2, "0", "R")

            if (ilen < 2)
            {
                for (int i = 0; i < 2 - ilen; i++)
                {
                    strrt += "0";
                }
            }
            strrt = strrt + foldernum.ToString();
            return strrt;
        }

        public static double GetPrice(double buycash, double sellcash, double orgprice)
        {
            double dbpri = 0;
            dbpri = (10000 - buycash / sellcash * 100 * 100) / 100;
            if (dbpri < 15)
                dbpri = orgprice;
            else
                dbpri = sellcash;

            return dbpri;
        }


        public static string GenerateImageName(string itemid)
        {
            string rt = string.Empty;
            int mod = 9 - itemid.Length;
            string zerostr = string.Empty;
            for (int i = 0; i < mod; i++)
                zerostr += "0";
            rt = zerostr + itemid;
            return rt;
        }
    }
}
