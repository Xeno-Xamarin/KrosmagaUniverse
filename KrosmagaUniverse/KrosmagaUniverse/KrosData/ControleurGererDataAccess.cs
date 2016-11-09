using Newtonsoft.Json;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KrosmagaUniverse.KrosData
{
    public class ControleurGererDataAccess
    {
        SQLiteConnection dbConn;
        public ControleurGererDataAccess()
        {
            dbConn = DependencyService.Get<ISQLite>().GetConnection();
            // create the table(s)
            dbConn.CreateTable<KrosCard>();
        }
        public List<KrosCard> GetAllCards()
        {
            return dbConn.Query<KrosCard>("Select * From [KrosCard]");
        }

        internal void FillTheDb()
        {

        }

        public int SaveKrosCard(KrosCard aCard)
        {
            return dbConn.Insert(aCard);
        }
        public int DeleteKrosCard(KrosCard aCard)
        {
            return dbConn.Delete(aCard);
        }
        public int EditKrosCard(KrosCard aCard)
        {
            return dbConn.Update(aCard);
        }

        public KrosCard ParseJsonToKrosCard(string jsonPath)
        {
            KrosCard deserializedCard = new KrosCard();

            deserializedCard = JsonConvert.DeserializeObject<KrosCard>(jsonPath);

            return deserializedCard;
        }

        public KrosCardText ParseJsonToKrosCardText(string jsonPath)
        {
            KrosCardText deserializedCard = new KrosCardText();

            deserializedCard = JsonConvert.DeserializeObject<KrosCardText>(jsonPath);

            return deserializedCard;
        }
    }
}
