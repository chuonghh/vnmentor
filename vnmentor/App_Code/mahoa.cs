using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

/// <summary>
/// Summary description for mahoa
/// </summary>
public class mahoa
{
    private static string key = "sfdjf48mdfdf3054";

    /// <summary>

    /// Mã hóa dựa trên thuật toán mã hóa 1 chiều MD5,

    /// Sau khi mã hóa, sử dụng thuật toán encode Base64 để lưu dưới dạng Text

    public static string EncryptUseMD5(string plainText)
    {
        string encrypted = null;
        MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
        byte[] pwdhash = hashmd5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(plainText));
        encrypted = Convert.ToBase64String(pwdhash);
        return encrypted;
    }
    /// <summary>

    /// Mã hóa dựa trên thuật toán mã hóa phức hợp, có thể giải mã sử dụng hàm Decrypt,

    /// Sau khi mã hóa, sử dụng thuật toán encode Base64 để lưu dưới dạng Text

    public static string Encrypt(string plainText)
    {
        string encrypted = null;
        try
        {
            byte[] inputBytes = ASCIIEncoding.ASCII.GetBytes(plainText);
            byte[] pwdhash = null;
            MD5CryptoServiceProvider hashmd5;

            hashmd5 = new MD5CryptoServiceProvider();
            pwdhash = hashmd5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(key));
            hashmd5 = null;
            // Create a new TripleDES service provider

            TripleDESCryptoServiceProvider tdesProvider = new TripleDESCryptoServiceProvider();
            tdesProvider.Key = pwdhash;
            tdesProvider.Mode = CipherMode.ECB;
            encrypted = Convert.ToBase64String(
                  tdesProvider.CreateEncryptor().TransformFinalBlock(inputBytes, 0, inputBytes.Length));
        }
        catch (Exception e)
        {
            string str = e.Message;
            throw;
        }
        return encrypted;
    }
    /// <summary>

    /// Thực hiện giải mã một xâu ký tự

    /// </summary>

    /// <param name="encryptedString">Chuỗi đã mã hóa</param>

    /// <returns></returns>
    public static string Decrypt(string encryptedString)
    {
        string decyprted = null;
        byte[] inputBytes = null;
        try
        {
            inputBytes = Convert.FromBase64String(encryptedString);
            byte[] pwdhash = null;
            MD5CryptoServiceProvider hashmd5;

            hashmd5 = new MD5CryptoServiceProvider();
            pwdhash = hashmd5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(key));
            hashmd5 = null;
            // Create a new TripleDES service provider
            TripleDESCryptoServiceProvider tdesProvider = new TripleDESCryptoServiceProvider();
            tdesProvider.Key = pwdhash;
            tdesProvider.Mode = CipherMode.ECB;
            decyprted = ASCIIEncoding.ASCII.GetString(

                  tdesProvider.CreateDecryptor().TransformFinalBlock(inputBytes, 0, inputBytes.Length));
        }
        catch
        {
            decyprted = "";
            throw;
        }
        return decyprted;
    }

}