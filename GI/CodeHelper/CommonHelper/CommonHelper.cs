using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

namespace CodeHelper
{
    /// <summary>
    /// 公共帮助类
    /// </summary>
    public static class CommonHelper
    {
        /// <summary>
        /// 根据程序集名称获取Assembly对象
        /// </summary>
        /// <param name="assemblyName">程序集名称</param>
        /// <returns>Assembly对象</returns>
        public static Assembly GetAssembly(string assemblyName)
        {
            string filePath = $@"{Assembly.GetExecutingAssembly().Location.Replace($"{Assembly.GetExecutingAssembly().GetName().Name}.dll", assemblyName)}";
            Assembly assembly = Assembly.LoadFrom(filePath);
            return assembly;
        }

        /// <summary>
        /// 对象转为Xml字符串
        /// </summary>
        /// <param name="obj">需要转换的对象</param>
        /// <returns>Xml字符串</returns>
        public static string ObjectToXML(object obj)
        {
            using (StringWriter sw = new StringWriter())
            {
                XmlSerializer serializer = new XmlSerializer(obj.GetType());
                serializer.Serialize(sw, obj);
                return sw.ToString();
            }
        }

        /// <summary>
        /// 计算字符串的MD5值
        /// </summary>
        /// <param name="str">需要计算的字符串</param>
        /// <returns>MD5值</returns>
        public static string CalcMD5(this string str)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            return CalcMD5(bytes);
        }

        /// <summary>
        /// 计算一个byte数组的MD5值
        /// </summary>
        /// <param name="bytes">需要计算的数组</param>
        /// <returns>MD5值</returns>
        public static string CalcMD5(byte[] bytes)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] computeBytes = md5.ComputeHash(bytes);
                string result = "";
                for (int i = 0; i < computeBytes.Length; i++)
                {
                    result += computeBytes[i].ToString("X").Length == 1 ? "0" +
                   computeBytes[i].ToString("X") : computeBytes[i].ToString("X");
                }
                return result;
            }
        }

        /// <summary>
        /// 计算一个文件的MD5值
        /// </summary>
        /// <param name="stream">文件流</param>
        /// <returns>MD5值</returns>
        public static string CalcMD5(Stream stream)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] computeBytes = md5.ComputeHash(stream);
                string result = "";
                for (int i = 0; i < computeBytes.Length; i++)
                {
                    result += computeBytes[i].ToString("X").Length == 1 ? "0" +
                   computeBytes[i].ToString("X") : computeBytes[i].ToString("X");
                }
                return result;
            }
        }

        /// <summary>
        /// 随机生成字符
        /// </summary>
        /// <param name="len">字符长度</param>
        /// <returns>生成的字符串</returns>
        public static string GenerateCaptchaCode(int len)
        {
            char[] data = { 'a', 'c', 'd', 'e', 'f', 'g', 'k', 'm', 'p', 'r', 's', 't', 'w', 'x', 'y', '3', '4', '5', '7', '8', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'M', 'S' };
            StringBuilder sbCode = new StringBuilder();
            Random rand = new Random();
            for (int i = 0; i < len; i++)
            {
                char ch = data[rand.Next(data.Length)];
                sbCode.Append(ch);
            }
            return sbCode.ToString();
        }
    }
}