using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Tp1_42014C_A20
{
    public class Rectangle : Figures
    {
        #region Attributs

        /// <summary>
        /// Attribue de type Color, représente la couleur de la bordure du rectangle.
        /// </summary>
        private Color _couleurBordure;
        /// <summary>
        /// Attribue de type Color, représente la couleur de remplissage du rectangle.
        /// </summary>
        private Color _couleurRemplissage;

        #endregion

        #region Get/Set

        /// <summary>
        /// Get/set permet de récupérer ou de modifier la couleur de remplissage du rectangle.
        /// </summary>
        public Color CouleurRemplissage
        {
            get { return _couleurRemplissage; }
            set { _couleurRemplissage = value; }
        }

        /// <summary>
        /// Get/set permet de modifié ou de récupérer la couleur de la bordure du rectangle.
        /// </summary>
        public Color CouleurBordure
        {
            get { return _couleurBordure; }
            set { _couleurBordure = value; }
        }

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur permet de créé un rectangle. Prend en paramètre la couleur de la bordure, la couleur de remplissage,
        /// le point de départ, le point de fin et la largeur du trait.
        /// </summary>
        /// <param name="pCouleurBordure">Color représente la couleur de la bordures.</param>
        /// <param name="pCouleurRemplissage">Color représente la couleur de remplissage.</param>
        /// <param name="pPointDepart">Point représente le point de départ.</param>
        /// <param name="pPointFin">Point représente le point de fin.</param>
        /// <param name="pLargeurTrait">int représente la largeur du trait.</param>
        public Rectangle(Color pCouleurBordure, Color pCouleurRemplissage, Point pPointDepart, Point pPointFin, int pLargeurTrait)
        {
            CouleurBordure = pCouleurBordure;
            CouleurRemplissage = pCouleurRemplissage;
            PointDepart = pPointDepart;
            PointFin = pPointFin;
            LargeurTrait = pLargeurTrait;
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Méthode qui permet d'afficher le rectangle dans l'élément graphique passé en paramètre.
        /// </summary>
        /// <param name="pGraphics">L'élément graphique dans lequel afficher le rectangle</param>
        public void Afficher(Graphics pGraphics)
        {
            Size tailleRectangle = new Size(PointFin.X - PointDepart.X,PointFin.Y - PointDepart.Y);
            pGraphics.FillRectangle(new SolidBrush(CouleurRemplissage), new System.Drawing.Rectangle(PointDepart, tailleRectangle));
            pGraphics.DrawRectangle(new Pen(CouleurBordure, LargeurTrait), new System.Drawing.Rectangle(PointDepart, tailleRectangle));
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
