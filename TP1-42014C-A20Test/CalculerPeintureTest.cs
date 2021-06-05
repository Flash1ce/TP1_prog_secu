using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NUnit.Framework;
using Tp1_42014C_A20;
using Rectangle = System.Drawing.Rectangle;

namespace TP1_42014C_A20Test
{
    public class CalculerPeintureTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConstructeurTest()
        {
            List<Ligne> lstLignes = new List<Ligne>();
            for (int i = 0; i < 2; i++)
            {
                Color couleur = Color.Blue;
                Point pointDepart = new Point();
                pointDepart.Y = 60 + i;
                pointDepart.X = 61 + i;
                Point pointFin = new Point();
                pointFin.Y = 120 + i;
                pointFin.X = 122 + i;
                int largeurTrait = 1;
                Tp1_42014C_A20.Ligne unRectangle = new Tp1_42014C_A20.Ligne(
                    couleur, pointDepart, pointFin, largeurTrait);
                lstLignes.Add(unRectangle);
            }

            List<Tp1_42014C_A20.Rectangle> lstRectangles = new List<Tp1_42014C_A20.Rectangle>();
            for (int i = 0; i < 2; i++)
            {
                Color couleurBordure = Color.AliceBlue;
                Color couleurRemplissage = Color.Blue;
                Point pointDepart = new Point();
                pointDepart.Y = 60 + i;
                pointDepart.X = 61 + i;
                Point pointFin = new Point();
                pointFin.Y = 120 + i;
                pointFin.X = 122 + i;
                int largeurTrait = 1;
                Tp1_42014C_A20.Rectangle unRectangle = new Tp1_42014C_A20.Rectangle(
                    couleurBordure, couleurRemplissage, pointDepart, pointFin, largeurTrait);
                lstRectangles.Add(unRectangle);
            }

            List<Ellipse> lstEllipses = new List<Ellipse>();
            for (int i = 0; i < 2; i++)
            {
                Color couleurBordure = Color.AliceBlue;
                Color couleurRemplissage = Color.Blue;
                Point pointDepart = new Point();
                pointDepart.Y = 60 + i;
                pointDepart.X = 61 + i;
                Point pointFin = new Point();
                pointFin.Y = 120 + i;
                pointFin.X = 122 + i;
                int largeurTrait = 1;
                Tp1_42014C_A20.Ellipse unEllipse = new Tp1_42014C_A20.Ellipse(
                    couleurBordure, couleurRemplissage, pointDepart, pointFin, largeurTrait);
                lstEllipses.Add(unEllipse);
            }

            double hauteurReelle = 10;
            double largeurReelle = 10;

            Assert.IsNotNull(lstLignes);
            Assert.IsNotNull(lstRectangles);
            Assert.IsNotNull(lstEllipses);

            int nb = lstLignes.Count;
            Assert.AreEqual(nb, 2);
            nb = lstRectangles.Count;
            Assert.AreEqual(nb, 2);
            nb = lstEllipses.Count;
            Assert.AreEqual(nb, 2);

            CalculerPeinture calculerPeinture = new CalculerPeinture(lstLignes, lstRectangles, lstEllipses, hauteurReelle, largeurReelle);

            Assert.IsNotNull(calculerPeinture);
            Assert.IsNotNull(calculerPeinture.LstEllipses);
            Assert.IsNotNull(calculerPeinture.LstRectangles);
            Assert.IsNotNull(calculerPeinture.LstLignes);
            Assert.AreEqual(calculerPeinture.HauteurReelle, hauteurReelle);
            Assert.AreEqual(calculerPeinture.LargeurReelle, largeurReelle);
        }

        [Test]
        public void CalculerQuantitePeinture()
        {
            List<Ligne> lstLignes = new List<Ligne>();
            for (int i = 0; i < 2; i++)
            {
                Color couleur = Color.Blue;
                Point pointDepart = new Point();
                pointDepart.Y = 60 + i;
                pointDepart.X = 61 + i;
                Point pointFin = new Point();
                pointFin.Y = 120 + i;
                pointFin.X = 122 + i;
                int largeurTrait = 1;
                Tp1_42014C_A20.Ligne unRectangle = new Tp1_42014C_A20.Ligne(
                    couleur, pointDepart, pointFin, largeurTrait);
                lstLignes.Add(unRectangle);
            }
            List<Tp1_42014C_A20.Rectangle> lstRectangles = new List<Tp1_42014C_A20.Rectangle>();
            for (int i = 0; i < 2; i++)
            {
                Color couleurBordure = Color.AliceBlue;
                Color couleurRemplissage = Color.Blue;
                Point pointDepart = new Point();
                pointDepart.Y = 60 + i;
                pointDepart.X = 61 + i;
                Point pointFin = new Point();
                pointFin.Y = 120 + i;
                pointFin.X = 122 + i;
                int largeurTrait = 1;
                Tp1_42014C_A20.Rectangle unRectangle = new Tp1_42014C_A20.Rectangle(
                    couleurBordure, couleurRemplissage, pointDepart, pointFin, largeurTrait);
                lstRectangles.Add(unRectangle);
            }
            List<Ellipse> lstEllipses = new List<Ellipse>();
            for (int i = 0; i < 2; i++)
            {
                Color couleurBordure = Color.AliceBlue;
                Color couleurRemplissage = Color.Blue;
                Point pointDepart = new Point();
                pointDepart.Y = 60 + i;
                pointDepart.X = 61 + i;
                Point pointFin = new Point();
                pointFin.Y = 120 + i;
                pointFin.X = 122 + i;
                int largeurTrait = 1;
                Tp1_42014C_A20.Ellipse unEllipse = new Tp1_42014C_A20.Ellipse(
                    couleurBordure, couleurRemplissage, pointDepart, pointFin, largeurTrait);
                lstEllipses.Add(unEllipse);
            }
            double hauteurReelle = 10;
            double largeurReelle = 10;


            CalculerPeinture calculerPeinture = new CalculerPeinture(lstLignes, lstRectangles, lstEllipses, hauteurReelle, largeurReelle);
            Assert.IsNotNull(calculerPeinture);

            calculerPeinture.CalculerQuantitePeinture();
        }

    }
}