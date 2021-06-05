using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Tp1_42014C_A20
{
    public class CalculerPeinture
    {
        #region Attributs

        /// <summary>
        /// Attribue List<Ligne> _lstLignes -> une liste de Lignes.
        /// </summary>
        private List<Ligne> _lstLignes;
        /// <summary>
        /// Attribue List<Rectangle> _lstRectangles -> une liste de rectangles.
        /// </summary>
        private List<Rectangle> _lstRectangles;
        /// <summary>
        /// Attribue List<Ellipse> _lstEllipses -> une liste d'ellipses.
        /// </summary>
        private List<Ellipse> _lstEllipses;
        /// <summary>
        /// Attribue double -> hauteur réelle.
        /// </summary>
        private double _hauteurReelle;
        /// <summary>
        /// Attribue double -> largeur réelle.
        /// </summary>
        private double _largeurReelle;
        /// <summary>
        /// Attribue List<(Color, double)> -> liste de quantité de peinture (aire) pour une couleur.
        /// -> (couleur, quantité)
        /// </summary>
        private List<(Color, double)> _quantitePeintureCouleur;

        #endregion

        #region Constructeurs 

        /// <summary>
        /// Constructeur CalculerPeinture. Assignation d’une valeur aux attribues
        /// en utilisant les accesseurs.
        /// Prend en paramètre une liste de ligne, une liste de rectangles, une
        /// liste d'ellipses, une hauteur et une largeur.
        /// </summary>
        /// <param name="pLstLignes">Liste de type Ligne -> représente la liste de toutes les lignes.</param>
        /// <param name="pLstRectangles">Liste de type Rectangle -> représente la liste de tous les rectangles.</param>
        /// <param name="pLstEllipses">Liste de type Ellipses -> représente la liste de tous les ellipses.</param>
        /// <param name="pHauteurReelle">Variable de type double -> représente la hauteur fournis par l'utilisateur.</param>
        /// <param name="pLargeurReelle">Variable de type double -> représente la largeur fournis par l'utilisateur.</param>
        public CalculerPeinture(List<Ligne> pLstLignes, List<Rectangle> pLstRectangles, List<Ellipse> pLstEllipses, double pHauteurReelle, double pLargeurReelle)
        {
            LstLignes = pLstLignes;
            LstRectangles = pLstRectangles;
            LstEllipses = pLstEllipses;
            HauteurReelle = pHauteurReelle;
            LargeurReelle = pLargeurReelle;
            QuantitePeintureCouleur = new List<(Color, double)>();
        }

        #endregion

        #region Get/Set

        /// <summary>
        /// Get/set LstLignes -> modifie ou récupère la liste de lignes (LstLignes).
        /// </summary>
        public List<Ligne> LstLignes
        {
            get { return _lstLignes; }
            set { _lstLignes = value; }
        }
        /// <summary>
        /// Get/set LstRectangles -> modifie ou récupère la liste de rectangles (LstRectangles).
        /// </summary>
        public List<Rectangle> LstRectangles
        {
            get { return _lstRectangles; }
            set { _lstRectangles = value; }
        }
        /// <summary>
        /// Get/set LstEllipses -> modifie ou récupère la liste d'ellipses (LstEllipses).
        /// </summary>
        public List<Ellipse> LstEllipses
        {
            get { return _lstEllipses; }
            set { _lstEllipses = value; }
        }
        /// <summary>
        /// Get/set HauteurReelle -> modifie ou récupère la hauteur réelle (HauteurReelle).
        /// </summary>
        public double HauteurReelle
        {
            get { return _hauteurReelle; }
            set { _hauteurReelle = value; }
        }
        /// <summary>
        /// Get/set LargeurReelle -> modifie ou récupère la largeur réelle (LargeurReelle).
        /// </summary>
        public double LargeurReelle
        {
            get { return _largeurReelle; }
            set { _largeurReelle = value; }
        }
        /// <summary>
        /// Get/set QuantitePeintureCouleur -> modifie ou récupère la liste de quantité de peinture pour
        /// une couleur (couleur,quantité). (QuantitePeintureCouleur)
        /// </summary>
        public List<(Color, double)> QuantitePeintureCouleur
        {
            get { return _quantitePeintureCouleur; }
            set { _quantitePeintureCouleur = value; }
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Méthode RecupererPoints. Récupère les points des forms qui sont dans les liste
        /// - LstLignes
        /// - LstRectangles
        /// - LstEllipses
        /// appelle la méthode CalculerEnPixels() et passe en paramètre
        /// - le point de départ
        /// - le point de fin
        /// - la figure
        /// </summary>
        private void RecupererPoints()
        {
            List<Ligne> lstLignes = LstLignes;
            List<Rectangle> lstRectangles = LstRectangles;
            List<Ellipse> lstEllipses = LstEllipses;
            foreach (Ligne uneLigne in lstLignes)
            {
                Point ptDepart = uneLigne.PointDepart;
                Point ptFin = uneLigne.PointFin;
                Color uneCouleur = uneLigne.Couleur;

                Figures uneFigures = uneLigne;

                CalculerEnPixels(ptDepart, ptFin, uneCouleur, uneFigures);
            }
            foreach (Rectangle unRectangle in lstRectangles)
            {
                Point ptDepart = unRectangle.PointDepart;
                Point ptFin = unRectangle.PointFin;
                Color uneCouleur = unRectangle.CouleurRemplissage;

                Figures uneFigures = unRectangle;

                CalculerEnPixels(ptDepart, ptFin, uneCouleur, uneFigures);
            }
            foreach (Ellipse unEllipse in lstEllipses)
            {
                Point ptDepart = unEllipse.PointDepart;
                Point ptFin = unEllipse.PointFin;
                Color uneCouleur = unEllipse.CouleurRemplissage;

                Figures uneFigures = unEllipse;

                CalculerEnPixels(ptDepart, ptFin, uneCouleur, uneFigures);
            }
        }

        /// <summary>
        /// Méthode CalculerEnPixels. Calcule la largeur et la hauteur en la multiplient par la hauteur ou la largeur qui est
        /// fournis par l'utilisateur, elle fait aussi une division de 600 sur cette valeur, car la taille du picture box est de 600px.
        /// La méthode prend en paramètre:
        ///     - un point de départ
        ///     - un point de fin
        ///     - la figure
        ///     - la couleur de la surface de la forme.
        /// Appelle la méthodes CalculerAire en lui passant la hauteur et la largeur calculer, ansis que le type et la couleur.
        /// </summary>
        /// <param name="pPtDepart">Point pPtDepart, -> De type Point représente le point de départ.</param>
        /// <param name="pPtFin">Point pPtDepart, -> De type Point représente le point de fin.</param>
        /// <param name="pUneFigure">Figure pUneFigure, -> De type Figures représente la figure.</param>
        /// <param name="pCouleur">Color pCOuleur, -> De type Color représente la couleur de peinture utiliser pour la surface de la forme.</param>
        private void CalculerEnPixels(Point pPtDepart, Point pPtFin, Color pCouleur, Figures pUneFigure)
        {
            double largeur = Math.Abs(pPtDepart.X - pPtFin.X);
            double hauteur = Math.Abs(pPtDepart.Y - pPtFin.Y);
            largeur = (largeur * LargeurReelle) / 600;
            hauteur = (hauteur * HauteurReelle) / 600;

            CalculerAire(largeur, hauteur, pCouleur, pUneFigure);
        }

        /// <summary>
        /// Méthode CalculerAire. Elle recoit en paramètre la largeur, la hauteur, la forme et la couleur de la forme.
        /// Elle calcule l'aire de la figure. Elle vérifie si la couleur est déja dans la liste QuantitePeintureCouleur.
        /// Si elle est présente elle mets a jour la quantité de peinture, sinon elle ajoute la couleur.
        /// </summary>
        /// <param name="pLargeur">double pLargeur, représent la largeur de la forme.</param>
        /// <param name="pHauteur">double pHauteur, représent la hauteur de la forme.</param>
        /// <param name="pUneFigure">Figure pUneFigure, représente la figure.</param>
        /// <param name="pCouleur">Color pCouleur, représente la couleur de la forme.</param>
        private void CalculerAire(double pLargeur, double pHauteur, Color pCouleur, Figures pUneFigure)
        {
            double aire = 0;

            if (pUneFigure is Rectangle)
            {
                Rectangle unRectangle = (Rectangle)pUneFigure;
                aire = unRectangle.CalculerAire(pHauteur, pLargeur);
            }
            else if (pUneFigure is Ligne)
            {
                Ligne uneLigne = (Ligne)pUneFigure;
                aire = uneLigne.CalculerAire(pHauteur, uneLigne.LargeurTrait);
            }
            else if (pUneFigure is Ellipse)
            {
                Ellipse unEllipse = (Ellipse)pUneFigure;
                aire = unEllipse.CalculerAire(pHauteur, pLargeur);
            }

            bool estPresent = false;
            int index = 0;
            for (int i = 0; i < QuantitePeintureCouleur.Count; i++)
            {
                if (QuantitePeintureCouleur[i].Item1 == pCouleur)
                {
                    estPresent = true;
                    index = i;
                }
            }

            if (estPresent == true)
            {
                (Color, double) tupleColorAir = QuantitePeintureCouleur[index];
                tupleColorAir.Item2 += aire;
                QuantitePeintureCouleur[index] = tupleColorAir;
            }
            else
            {
                QuantitePeintureCouleur.Add((pCouleur, aire));
            }
        }

        /// <summary>
        /// Méthode CalculerQuantitePeinture(). Appelle la méthode RecupererPoints(), et return la liste QuantitePeintureCouleur de type List<(Color, double)>,
        /// une fois que les calcule sont effectuer.
        /// </summary>
        /// <returns>Retourne une liste de quantité de peinture et de couleur. Cette liste représente les couleur ainsi que la quantité en double
        /// du dessin.</returns>
        public List<(Color, double)> CalculerQuantitePeinture()
        {
            RecupererPoints();
            return QuantitePeintureCouleur;
        }

        #endregion
    }
}
