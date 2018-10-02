﻿using CatalogueVehicules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiasseVehicule
{
    public class ConstructeurLiasseVehiculeHtml : ConstructeurLiasseVehicule
    {
        public ConstructeurLiasseVehiculeHtml()
        {
            liasse = new LiasseHtml();
        }

        public override void construitBonDeCommande(string nomClient)
        {
            string document = "<HTML>Bon de commande Client : " + nomClient + "</HTML>";
            liasse.ajouteDocument(document);
        }

        public override void construitDemandeImmatriculation(string nomDemandeur)
        {
            string document = "<HTML>Demande d'immatriculation Demandeur : " + nomDemandeur + "</HTML>";
            liasse.ajouteDocument(document);
        }
    }
}
