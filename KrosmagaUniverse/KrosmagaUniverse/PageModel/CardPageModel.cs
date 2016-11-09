using KrosmagaUniverse.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreshMvvm;

namespace KrosmagaUniverse.PageModel
{
    [ImplementPropertyChanged]
    public class CardPageModel : FreshBasePageModel
    {
        private CardModel _selectedItem;

        public List<CardModel> Cards { get; set; }

        public CardPageModel()
        {
           
        }

        public override void Init(object initData)
        {
            base.Init(initData);

            Cards = new List<CardModel>();
            Cards.Add(new CardModel { Name = "Betty Boubz", Description = "", ImagePath = "betty_boubz.png" });
            Cards.Add(new CardModel { Name = "clara_byne", Description = "", ImagePath = "clara_byne.png" });
            Cards.Add(new CardModel { Name = "criblage", Description = "", ImagePath = "criblage.png" });
            Cards.Add(new CardModel { Name = "dernier_recours", Description = "", ImagePath = "dernier_recours.png" });
            Cards.Add(new CardModel { Name = "detournement", Description = "", ImagePath = "detournement.png" });
            Cards.Add(new CardModel { Name = "eksa_soth", Description = "Asparagus pee stink.", ImagePath = "eksa_soth.png" });
            Cards.Add(new CardModel { Name = "esquive", Description = "Broccoli donice with fruit.", ImagePath = "esquive.png" });
            Cards.Add(new CardModel { Name = "fantome_cra", Description = "Avocadoing taste better.", ImagePath = "fantome_cra.png" });
            Cards.Add(new CardModel { Name = "fleche_chercheuse", Description = "Tvomit.", ImagePath = "fleche_chercheuse.png" });
            Cards.Add(new CardModel { Name = "fleche_criblante", Description = "Ases your pee stink.", ImagePath = "fleche_criblante.png" });
            Cards.Add(new CardModel { Name = "fleche_d_immolation", Description = "esn’t play nice with fruit.", ImagePath = "fleche_d_immolation.png" });
            Cards.Add(new CardModel { Name = "fleche_de_recul", Description = "Avonothing taste better.", ImagePath = "fleche_de_recul.png" });
            Cards.Add(new CardModel { Name = "fleche_destructrice", Description = "e vomit.", ImagePath = "fleche_destructrice.png" });
            Cards.Add(new CardModel { Name = "fleche_explosive", Description = "Ases your pee stink.", ImagePath = "fleche_explosive.png" });
            Cards.Add(new CardModel { Name = "fleche_percante", Description = "Bro’t play nice with fruit.", ImagePath = "fleche_percante.png" });
            Cards.Add(new CardModel { Name = "fleche_tempete", Description = "Avocothing taste better.", ImagePath = "fleche_tempete.png" });
            Cards.Add(new CardModel { Name = "guy_yomtella", Description = "Tastes.", ImagePath = "guy_yomtella.png" });
            Cards.Add(new CardModel { Name = "harcelement", Description = "Asparagur pee stink.", ImagePath = "harcelement.png" });
            Cards.Add(new CardModel { Name = "jems_blond", Description = "Broccoliay nice with fruit.", ImagePath = "jems_blond.png" });
            Cards.Add(new CardModel { Name = "lebolas", Description = "Avocado maktaste better.", ImagePath = "lebolas.png" });
            Cards.Add(new CardModel { Name = "lucie_fhair", Description = "Tastes ", ImagePath = "lucie_fhair.png" });
            Cards.Add(new CardModel { Name = "oeil_de_lynx", Description = "Asparaour pee stink.", ImagePath = "oeil_de_lynx.png" });
            Cards.Add(new CardModel { Name = "patty_ceriz", Description = "Broccollay nice with fruit.", ImagePath = "patty_ceriz.png" });
            Cards.Add(new CardModel { Name = "robin_des_landes", Description = "Av nothing taste better.", ImagePath = "robin_des_landes.png" });
            Cards.Add(new CardModel { Name = "tireur_d_elite", Description = "Tastit.", ImagePath = "tireur_d_elite.png" });
        }
        public CardModel SelectedItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                _selectedItem = value;

                if (_selectedItem == null)
                    return;

                SelectedItem = null;
            }
        }

   
    }
}
