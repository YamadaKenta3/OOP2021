using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SendMail
{
   public class Settings
    {


        private static  Settings instance = null;



        public int Port { get; set; }   //ポート番号
        public string Host { get; set; }    //ホスト名
        public string MailAddr { get; set; }    //メールアドレス
        public string Pass { get; set; }    //パスワード
        public bool Ssl { get; set; }   //SSL



        //コンストラクタ
        private Settings() 
        {
        
        }




        //インスタンスの取得
        public static Settings getInstance() 
        {
            if (instance == null)
            {
                instance = new Settings();

                using (var reader = XmlReader.Create("mailsetting.xml"))
                {


                    var serializer = new DataContractSerializer(typeof(Settings));
                    var readSettings = serializer.ReadObject(reader) as Settings;

                    instance.Host = readSettings.Host;
                    instance.Port = readSettings.Port;
                    instance.Pass = readSettings.Pass;
                    instance.MailAddr = readSettings.MailAddr;
                    instance.Ssl = readSettings.Ssl;

                }
              
            }
            return instance;
        }
        //送信データ登録
        public void setSendConfig(string host, string port, 
                                  string maillAddr, string pass, bool ssl)
        {
           Host = host;
           Pass = pass;
         //  Port = port;
           MailAddr = maillAddr;
           Ssl = ssl;


            var xws = new XmlWriterSettings
            {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = "   ",

            };
            using (var writer = XmlWriter.Create("mailsetting.xml", xws))
            {
                var serializer = new DataContractSerializer(settings.GetType());
                serializer.WriteObject(writer, settings);
            }
        }



        public string sHost()
        {
            return "smtp.gmail.com";
        }
        public string sPort()
        {
            return 587.ToString();
        }
        public string sMailAddr()
        {
            return "infosys01@gmail.com";
        }
        public string sPass()
        {
            return "Infosys2021";
        }
        public bool sSsl()
        {
            return true;
        }


       



    }
}