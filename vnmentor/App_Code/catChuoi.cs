using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

/// <summary>
/// Summary description for CatChuoi
/// </summary>
public class CatChuoiCtrl
{
    //------------------------  Hàm cắt chuỗi Cắt chuỗi ----------------//
    public string CatChuoi(string Noi_Dung, int length)
    {
        if (String.IsNullOrEmpty(Noi_Dung)) throw new ArgumentNullException(Noi_Dung);
        var words = Noi_Dung.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        if (words[0].Length > length) throw new ArgumentException("");
        var sb = new StringBuilder();

        foreach (var word in words)
        {
            if ((sb + word).Length > length)
                return string.Format("{0} ...", sb.ToString().TrimEnd(' '));
            sb.Append(word + " ");
        }
        return string.Format("{0}", sb.ToString().TrimEnd(' '));// nhỏ hơn length qui định thì ko có dấu ...
    }
}