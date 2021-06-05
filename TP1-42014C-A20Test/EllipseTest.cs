using System;
using System.Drawing;
using System.Windows.Forms;
using NUnit.Framework;

namespace TP1_42014C_A20Test
{
    public class EllipseTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConstructeurTest()
        {

            Color couleurBordure = Color.AliceBlue;

            Color couleurRemplissage = Color.Blue;

            Point pointDepart = new Point();
            pointDepart.Y = 60;
            pointDepart.X = 61;

            Point pointFin = new Point();
            pointFin.Y = 120;
            pointFin.X = 122;

            int largeurTrait = 1;

            Tp1_42014C_A20.Ellipse unEllipse = new Tp1_42014C_A20.Ellipse(
                couleurBordure, couleurRemplissage, pointDepart, pointFin, largeurTrait);

            Assert.AreEqual(unEllipse.CouleurBordure, couleurBordure);
            Assert.AreEqual(unEllipse.CouleurRemplissage, couleurRemplissage);
            Assert.AreEqual(unEllipse.PointDepart, pointDepart);
            Assert.AreEqual(unEllipse.PointFin, pointFin);
            Assert.AreEqual(unEllipse.LargeurTrait, largeurTrait);
        }

        [Test]
        public void AfficherTest()
        {
            PictureBox pbDessin = new PictureBox();
            Graphics graphics = pbDessin.CreateGraphics();

            Color couleurBordure = Color.AliceBlue;
            Color couleurRemplissage = Color.Blue;
            Point pointDepart = new Point();
            pointDepart.Y = 60;
            pointDepart.X = 61;
            Point pointFin = new Point();
            pointFin.Y = 120;
            pointFin.X = 122;
            int largeurTrait = 1;

            Tp1_42014C_A20.Ellipse unEllipse = new Tp1_42014C_A20.Ellipse(
                couleurBordure, couleurRemplissage, pointDepart, pointFin, largeurTrait);

            unEllipse.Afficher(graphics);
        }

        [Test]
        public void CalculerAireTest()
        {
            Color couleurBordure = Color.AliceBlue;
            Color couleurRemplissage = Color.Blue;
            Point pointDepart = new Point();
            pointDepart.Y = 60;
            pointDepart.X = 61;
            Point pointFin = new Point();
            pointFin.Y = 120;
            pointFin.X = 122;
            int largeurTrait = 1;

            Tp1_42014C_A20.Ellipse unEllipse = new Tp1_42014C_A20.Ellipse(
                couleurBordure, couleurRemplissage, pointDepart, pointFin, largeurTrait);

            double largeur = Math.Abs(pointDepart.X - pointFin.X);
            double hauteur = Math.Abs(pointDepart.Y - pointFin.Y);
            largeur = (largeur * 1) / 600;
            hauteur = (hauteur * 1) / 600;

            double aire = unEllipse.CalculerAire(hauteur, largeur);

            Assert.AreEqual(aire, (Math.PI * (hauteur / 2) * (largeur / 2)));
        }
    }
}