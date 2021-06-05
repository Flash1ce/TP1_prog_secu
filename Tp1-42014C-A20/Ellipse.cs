using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Tp1_42014C_A20
{
    public class Ellipse : Figures
    {
        #region Attributs

        /// <summary>
        /// Attribue de type Color. Représente la couleur de la bordure.
        /// </summary>
        private Color _couleurBordure;
        /// <summary>
        /// Attribue de type Color. Représente la couleur de remplissage de la forme.
        /// </summary>
        private Color _couleurRemplissage;

        #endregion

        #region Get/Set

        /// <summary>
        /// Get/set CouleurRemplissage, permet de modifié ou de récupérer la couleur de remplissage.
        /// </summary>
        public Color CouleurRemplissage
        {
            get { return _couleurRemplissage; }
            set { _couleurRemplissage = value; }
        }
        /// <summary>
        /// Get/set CouleurBordure, permet de modifié ou de récupérer la couleur des bordures.
        /// </summary>
        public Color CouleurBordure
        {
            get { return _couleurBordure; }
            set { _couleurBordure = value; }
        }

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur Ellipse. Prend en paramètre la couleur de la bordure, la couleur de remplissage le point de depart, le point
        /// de fin et la largeur du trait.
        /// </summary>
        /// <param name="pCouleurBordure">Color pCouleurBordure, représente la couleur des bordures.</param>
        /// <param name="pCouleurRemplissage">Color pCouleurRemplissage, représente la couleur de remplissage.</param>
        /// <param name="pPointDepart">Point pPointDepart, représente le point de départ.</param>
        /// <param name="pPointFin">Point pPointFin, représente le point de fin.</param>
        /// <param name="pLargeurTrait">int pLargeurTrait, représente la largeur du trait.</param>
        public Ellipse(Color pCouleurBordure, Color pCouleurRemplissage, Point pPointDepart, Point pPointFin,
            int pLargeurTrait)
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
        /// Méthode qui permet d'afficher l'ellipse dans l'élément graphique passé en paramètre.
        /// </summary>
        /// <param name="pGraphics">L'élément graphique dans lequel afficher l'ellipse</param>
        public void Afficher(Graphics pGraphics)
        {
            Size tailleEllipse = new Size(PointFin.X - PointDepart.X, PointFin.Y - PointDepart.Y);
            pGraphics.FillEllipse(new SolidBrush(CouleurRemplissage),
                new System.Drawing.Rectangle(PointDepart, tailleEllipse));
            pGraphics.DrawEllipse(new Pen(CouleurBordure, LargeurTrait),
                new System.Drawing.Rectangle(PointDepart, tailleEllipse));
        }

        /// <summary>
        /// Méthode qui permet de calculer l'aire d'une ellipse. Merci internet :)
        /// Pour plus d'info, voir un prof de math!
        /// </summary>
        /// <param name="pHauteur">La hauteur de l'ellipse</param>
        /// <param name="pLargeur">La largeur de l'ellipse</param>
        /// <returns>L'aire de l'ellipse</returns>
        public double CalculerAire(double pHauteur, double pLargeur)
        {
            return (Math.PI * (pHauteur / 2) * (pLargeur / 2));
        }

        #endregion
    }
}