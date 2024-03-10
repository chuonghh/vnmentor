using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web;

/// <summary>
/// Summary description for LocDauCtrl
/// </summary>
public class locDau
{
    private readonly string[] VietNamChar = new string[] 
        { 
        "aAeEoOuUiIdDyY", 
        "áàạảãâấầậẩẫăắằặẳẵ", 
        "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ", 
        "éèẹẻẽêếềệểễ", 
        "ÉÈẸẺẼÊẾỀỆỂỄ", 
        "óòọỏõôốồộổỗơớờợởỡ", 
        "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ", 
        "úùụủũưứừựửữ", 
        "ÚÙỤỦŨƯỨỪỰỬỮ", 
        "íìịỉĩ", 
        "ÍÌỊỈĨ", 
        "đ", 
        "Đ", 
        "ýỳỵỷỹ", 
        "ÝỲỴỶỸ",
        };

    public string LocDau(string str)
    {
        //Thay thế và lọc dấu từng char      
        for (int i = 1; i < VietNamChar.Length; i++)
        {
            for (int j = 0; j < VietNamChar[i].Length; j++)
                str = str.Replace(VietNamChar[i][j], VietNamChar[0][i - 1]);
        }
        return str;
    }


    public string Locdau_TiengViet(string chuyendau)
    {

        string stFormD = chuyendau.ToString().Normalize(NormalizationForm.FormD);
        StringBuilder sb = new StringBuilder();
        for (int ich = 0; ich < stFormD.Length; ich++)
        {
            UnicodeCategory uc = CharUnicodeInfo.GetUnicodeCategory(stFormD[ich]);
            if (uc != UnicodeCategory.NonSpacingMark)
            {
                sb.Append(stFormD[ich]);
            }
        }
        sb = sb.Replace('Đ', 'D');
        sb = sb.Replace('đ', 'd');
        sb = sb.Replace('&', ' ');
        sb = sb.Replace('-', ' ');
        //------------  Chuyển ký tự IN thành ký tự thường ---------------------------//
        string str_idm = "";
        foreach (var c in sb.ToString())
        {
            if ((Convert.ToInt32(c) >= 32 &&  Convert.ToInt32(c) <= 47) || (Convert.ToInt32(c) >=58 &&  Convert.ToInt32(c) <= 64) )
            {
                str_idm += "-";
            }
            else
            {
                if (Convert.ToInt32(c) == 44 || Convert.ToInt32(c) == 45 || Convert.ToInt32(c) == 46)
                {
                }
                else
                {
                    str_idm += c.ToString().ToLower();
                }
            }

        }
        //------------  END // Chuyển ký tự IN thành ký tự thường ---------------------------//

        return (str_idm.ToString().Normalize(NormalizationForm.FormD));


    } 




}