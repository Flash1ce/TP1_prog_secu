using System;
using System.Collections.Generic;
using System.Drawing;

namespace Tp1_42014C_A20
{
    public class Ligne : Figures
    {
        #region Attributs

        /// <summary>
        /// Attribue de type Color, représente la couleur de la ligne.
        /// </summary>
        private Color _couleur;

        #endregion

        #region Get/Set

        /// <summary>
        /// Get/set permet de modifier ou de récupérer la couleur de la ligne.
        /// </summary>
        public Color Couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur. Prend en paramètre la couleur, le point de départ, le point de fin et la largeur du trait.
        /// </summary>
        /// <param name="pCouleur">Color représente la couleur de la ligne.</param>
        /// <param name="pPointDepart">Point représente le point de départ de la ligne.</param>
        /// <param name="pPointFin">Point représente le point de fin de la ligne.</param>
        /// <param name="pLargeurTrait">int représente la largeur du trait de la ligne</param>
        public Ligne(Color pCouleur, Point pPointDepart, Point pPointFin, int pLargeurTrait)
        {
            Couleur = pCouleur;
            PointDepart = pPointDepart;
            PointFin = pPointFin;
            LargeurTrait = pLargeurTrait;
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Méthode qui permet d'afficher la ligne dans l'élément graphique passé en paramètre.
        /// </summary>
        /// <param name="pGraphics">L'élément graphique dans lequel afficher la ligne</param>
        public void Afficher(Graphics pGraphics)
        {
            pGraphics.DrawLine(new Pen(Couleur, LargeurTrait), PointDepart, PointFin);
        }

        /// <summary>
        /// Permet de calculer l'aire et de la retrourner.
        /// </summary>
        /// <param name="pHauteur">La hauteur de la forme.</param>
        /// <param name="pLargeur">La largeur de la forme.</param>
        /// <returns>Retourne un double de l'aire de la forme.</returns>
        public double CalculerAire(double pHauteur, double pLargeur)
        {
            return (pLargeur * pHauteur);
        }

        #endregion

    }
}