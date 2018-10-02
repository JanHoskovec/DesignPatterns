using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiasseVehicule
{
    public class ConstructeurLiasseVehiculeDoc : ConstructeurLiasseVehicule
    {
        public ConstructeurLiasseVehiculeDoc()
        {
            liasse = new LiasseDoc();
        }

        public override void construitBonDeCommande(string nomClient)
        {
            string document = "<DOC>Bon de commande Client : " + nomClient + "</DOC>";
            liasse.ajouteDocument(document);
        }

        public override void construitDemandeImmatriculation(string nomDemandeur)
        {
            string document = "<DOC>Demande d'immatriculation Demandeur : " + nomDemandeur + "</DOC>";
            liasse.ajouteDocument(document);
        }
    }
}
