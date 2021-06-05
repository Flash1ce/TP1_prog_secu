using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using NUnit.Framework;

namespace TP1_42014C_A20Test
{
    public class LigneTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConstructeurTest()
        {
            Color couleur = Color.Aqua;

            Point pointDepart = new Point();
            pointDepart.X = 60;
            pointDepart.Y = 60;

            Point pointFin = new Point();
            pointFin.X = 120;
            pointFin.Y = 120;

            int largeurTrait = 1;

            Tp1_42014C_A20.Ligne uneLigne = new Tp1_42014C_A20.Ligne(couleur, pointDepart, pointFin, largeurTrait);

            Assert.AreEqual(uneLigne.Couleur, couleur);
            Assert.AreEqual(uneLigne.PointDepart, pointDepart);
            Assert.AreEqual(uneLigne.PointFin, pointFin);
            Assert.AreEqual(uneLigne.LargeurTrait, largeurTrait);

        }

        [Test]
        public void AfficherTest()
        {
            PictureBox pbDessin = new PictureBox();
            Graphics graphics = pbDessin.CreateGraphics();

            Color couleur = Color.Aqua;
            Point pointDepart = new Point();
            pointDepart.X = 60;
            pointDepart.Y = 60;
            Point pointFin = new Point();
            pointFin.X = 120;
            pointFin.Y = 120;
            int largeurTrait = 1;

            Tp1_42014C_A20.Ligne uneLigne = new Tp1_42014C_A20.Ligne(couleur, pointDepart, pointFin, largeurTrait);
            uneLigne.Afficher(graphics);
        }

        [Test]
        public void CalculerAireTest()
        {
            Color couleur = Color.Aqua;
            Point pointDepart = new Point();
            pointDepart.X = 60;
            pointDepart.Y = 60;
            Point pointFin = new Point();
            pointFin.X = 120;
            pointFin.Y = 120;
            int largeurTrait = 1;

            Tp1_42014C_A20.Ligne uneLigne = new Tp1_42014C_A20.Ligne(couleur, pointDepart, pointFin, largeurTrait);


            double hauteur = Math.Abs(pointDepart.Y - pointFin.Y);
            hauteur = (hauteur * 1) / 600;

            double aire = uneLigne.CalculerAire(hauteur, uneLigne.LargeurTrait);

            Assert.AreEqual(aire, (hauteur * uneLigne.LargeurTrait));
        }
    }
}
