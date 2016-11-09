using ControleurJSON.JSON;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ControleurJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            ControleurGererDB _controleurGererDB = new ControleurGererDB();
            KrosCard aCard = new KrosCard();
            List<KrosCard> cardsToAdd = new List<KrosCard>();
            List<KrosListCardText> cardsTextToAdd = new List<KrosListCardText>();
            //On populate la base
            string[] fileJSONKrosKardPaths = Directory.GetFiles(@"C:\Users\paren\Documents\visual studio 2015\Projects\KrosmagaUniverse\cards_data\data\");

            Console.WriteLine("Test ParseJsonToCard \n \n");
            foreach (var jsonFilePath in fileJSONKrosKardPaths)
            {
                var json = System.IO.File.ReadAllText(jsonFilePath);
                cardsToAdd.Add(_controleurGererDB.ParseJsonToKrosCard(json));
                Console.WriteLine(aCard.ToString());
            }

            Console.WriteLine("\n \n Test EN XML to DB \n \n");


            string[] fileXMLPaths = Directory.GetFiles(@"C:\Users\paren\Documents\Visual Studio 2015\Projects\KrosmagaUniverse\cards_data\texts\EN", "*.xml");



            KrosListCardText aCardText = new KrosListCardText();
            XmlSerializer serializer = new XmlSerializer(typeof(KrosListCardText));
            KrosListCardText listCardText = new KrosListCardText();
            foreach (var xmlFilePath in fileXMLPaths)
            {
                using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
                {
                    listCardText.listKrosCard.AddRange(((KrosListCardText)serializer.Deserialize(fileStream)).listKrosCard);
                }

            }

         
                //string xmlString = System.IO.File.ReadAllText(xmlFilePath);
                //XmlDocument doc = new XmlDocument();
                //doc.LoadXml(xmlString);

            //string jsonFromXML = JsonConvert.SerializeXmlNode(doc);
            //cardsTextToAdd.Add(_controleurGererDB.ParseJsonToKrosCardText(jsonFromXML));

            //  }

            Console.WriteLine("\n \n Partie DB : \n \n");



            SQLiteConnection m_dbConnection;
            string dbName = "KrosDB.db";

            m_dbConnection = new SQLiteConnection(@"Data Source="+dbName+";Version=3;");
            m_dbConnection.Open();

            CreateAllTable(m_dbConnection);
            FillAllTable(m_dbConnection, cardsToAdd, listCardText.listKrosCard);

         

            string sqlSelectKrosCard = "select * from KrosCard";
            SQLiteCommand commandSelect = new SQLiteCommand(sqlSelectKrosCard, m_dbConnection);
            SQLiteDataReader reader = commandSelect.ExecuteReader();

            while (reader.Read())
                Console.WriteLine("Id: " + reader["Id"] + "\tCardType: " + reader["CardType"]+'\n');

            Console.ReadLine();

            m_dbConnection.Close();
            GC.Collect();
            File.Delete(dbName);
         

            Console.ReadLine();
        }

        private static void FillAllTable(SQLiteConnection m_dbConnection, List<KrosCard> cardsToAdd, List<KrosCardText> cardsTextToAdd)
        {
           
            foreach (var card in cardsToAdd)
            {

                string sqlInsertKrosCard = "insert into KrosCard (Id, CardType,CostAP,Life,Attack,MouvementPoint,IsToken,Rarity,GodType,Extension) values "
                                                    + "(" + card.Id + ",'"
                                                          + card.CardType + "',"
                                                          + card.CostAP + ","
                                                          + card.Life + ","
                                                          + card.Attack + ","
                                                          + card.MovementPoint + ","
                                                          + (card.IsToken == true ? 1 : 0) + ","
                                                          + card.Rarity + ","
                                                          + card.GodType + ","
                                                          + card.Extension + ")";
                SQLiteCommand command = new SQLiteCommand(sqlInsertKrosCard, m_dbConnection);
                command.ExecuteNonQuery();
            }

            foreach (var cardText in cardsTextToAdd)
            {
                //Valeur de base CardID = 0
                string sqlInsertKrosCard = "insert into KrosCardText (Id, CardType,CostAP,Life,Attack,MouvementPoint,IsToken,Rarity,GodType,Extension) values "
                                                    + "(" + cardText.CardId + ",'"
                                                          + cardText.Name + "',"
                                                          + cardText.Descr + ","
                                                          + cardText.idLanguage + ","
                                                         + ")";
                SQLiteCommand command = new SQLiteCommand(sqlInsertKrosCard, m_dbConnection);
                command.ExecuteNonQuery();
            }


        }

        private static void CreateAllTable(SQLiteConnection m_dbConnection)
        {
            try
            {
                string sqlCreateKrosCard = "CREATE TABLE `KrosCard` ("
                       + "`Id`	INTEGER UNIQUE,"
                       + "`CardType`	TEXT,"
                       + "`CostAP`	INTEGER,"
                       + "`Life`	INTEGER,"
                       + "`Attack`	INTEGER,"
                       + "`MouvementPoint`	INTEGER,"
                       + "`IsToken`	INTEGER,"
                       + "`Rarity`	INTEGER,"
                       + "`GodType`	INTEGER,"
                       + "`Extension`	INTEGER,"
                       + "PRIMARY KEY(`Id`)"
                       + ")";


                SQLiteCommand commandCreateKrosCard = new SQLiteCommand(sqlCreateKrosCard, m_dbConnection);
                commandCreateKrosCard.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            

             string sqlCreateKrosCardText = "CREATE TABLE `KrosCardText` ("
                                        + "`CardId`	INTEGER UNIQUE,"
                                        + "`Name`	TEXT,"
                                        + "`Descr`	TEXT,"
                                        + "`idLanguage`	INTEGER"
                                        + ")";


           SQLiteCommand commandlCreateKrosCardText = new SQLiteCommand(sqlCreateKrosCardText, m_dbConnection);
           commandlCreateKrosCardText.ExecuteNonQuery();

        }
    }
}
