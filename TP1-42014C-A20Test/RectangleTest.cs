using System;
using System.Drawing;
using System.Windows.Forms;
using NUnit.Framework;

namespace TP1_42014C_A20Test
{
    public class RectangleTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConstructeurTest()
        {
            Color colorBordure = Color.Aqua;

            Color couleurRemplissage = Color.AliceBlue;

            Point pointDepart = new Point();
            pointDepart.X = 60;
            pointDepart.Y = 63;

            Point pointFin = new Point();
            pointFin.Y = 120;
            pointFin.X = 130;

            int largeurTrait = 2;

            Tp1_42014C_A20.Rectangle unRectangle = new Tp1_42014C_A20.Rectangle(colorBordure, couleurRemplissage, pointDepart, pointFin, largeurTrait);

            Assert.AreEqual(unRectangle.CouleurBordure, colorBordure);
            Assert.AreEqual(unRectangle.CouleurRemplissage, couleurRemplissage);
            Assert.AreEqual(unRectangle.PointDepart, pointDepart);
            Assert.AreEqual(unRectangle.PointFin, pointFin);
            Assert.AreEqual(unRectangle.LargeurTrait, largeurTrait);
        }

        [Test]
        public void AfficherTest()
        {
            PictureBox pbDessin = new PictureBox();
            Graphics graphics = pbDessin.CreateGraphics();

            Color colorBordure = Color.Aqua;
            Color couleurRemplissage = Color.AliceBlue;
            Point pointDepart = new Point();
            pointDepart.X = 60;
            pointDepart.Y = 63;
            Point pointFin = new Point();
            pointFin.Y = 120;
            pointFin.X = 130;
            int largeurTrait = 2;

            Tp1_42014C_A20.Rectangle unRectangle = new Tp1_42014C_A20.Rectangle(colorBordure, couleurRemplissage, pointDepart, pointFin, largeurTrait);
            unRectangle.Afficher(graphics);
        }

        [Test]
        public void CalculerAireTest()
        {
            Color colorBordure = Color.Aqua;
            Color couleurRemplissage = Color.AliceBlue;
            Point pointDepart = new Point();
            pointDepart.X = 60;
            pointDepart.Y = 63;
            Point pointFin = new Point();
            pointFin.Y = 120;
            pointFin.X = 130;
            int largeurTrait = 2;

            Tp1_42014C_A20.Rectangle unRectangle = new Tp1_42014C_A20.Rectangle(colorBordure, couleurRemplissage, pointDepart, pointFin, largeurTrait);

            double hauteur = Math.Abs(pointDepart.Y - pointFin.Y);
            double largeur = Math.Abs(pointDepart.X - pointFin.X);
            hauteur = (hauteur * 1) / 600;

            double aire = unRectangle.CalculerAire(hauteur, largeur);

            Assert.AreEqual(aire, (hauteur * largeur));
        }
    }
}