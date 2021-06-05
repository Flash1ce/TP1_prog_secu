using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Tp1_42014C_A20
{
    public partial class frmAccueil : Form
    {
        #region Attributs

        /// <summary>
        /// Attribue Boolean, représente si le dessin est en cours.
        /// </summary>
        private Boolean _bDessinEnCours;
        /// <summary>
        /// Attribue Point représente le point de la position de départ.
        /// </summary>
        private Point _pntPositionDepart;
        /// <summary>
        /// Attribue List<Ligne> représente la liste des lignes.
        /// </summary>
        private List<Ligne> _lstLignes;
        /// <summary>
        /// Attribue List<Rectangle> représente la liste des rectangles.
        /// </summary>
        private List<Rectangle> _lstRectangles;
        /// <summary>
        /// Attribue List<Ellipse> représenta la liste des ellipse.
        /// </summary>
        private List<Ellipse> _lstEllipses;
        /// <summary>
        /// Attribue Stack<Figure> une pile de figure.
        /// </summary>
        private Stack<Figures> _pileFigures;
        /// <summary>
        /// Attribue Stack<Figures> une pile de figure qui sont supprimer.
        /// </summary>
        private Stack<Figures> _pileFiguresSupp;

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur, Initialisation du formulaire Acceuil.
        /// </summary>
        public frmAccueil()
        {
            InitializeComponent();

            _bDessinEnCours = false;

            couleurRemplissage.Color = Color.Gray;
            btnCouleurRemplissage.BackColor = couleurRemplissage.Color;
            couleurBordure.Color = Color.Black;
            btnCouleurBordure.BackColor = couleurBordure.Color;

            _lstLignes = new List<Ligne>();
            _lstRectangles = new List<Rectangle>();
            _lstEllipses = new List<Ellipse>();

            _pileFigures = new Stack<Figures>();
            _pileFiguresSupp = new Stack<Figures>();
        }

        #endregion

        #region Get/set

        /// <summary>
        /// Get/set Modifie ou récupère si le dessin est en cours.
        /// </summary>
        public bool BDessinEnCours
        {
            get { return _bDessinEnCours; }
            set { _bDessinEnCours = value; }
        }

        /// <summary>
        /// Get/set modifie ou récupère la position de départ.
        /// </summary>
        public Point PntPositionDepart
        {
            get { return _pntPositionDepart; }
            set { _pntPositionDepart = value; }
        }

        /// <summary>
        /// Get/set modifie ou récupère la liste de lignes.
        /// </summary>
        public List<Ligne> LstLignes
        {
            get { return _lstLignes; }
            set { _lstLignes = value; }
        }

        /// <summary>
        /// Get/set modifie ou récupère la liste de rectangles.
        /// </summary>
        public List<Rectangle> LstRectangles
        {
            get { return _lstRectangles; }
            set { _lstRectangles = value; }
        }

        /// <summary>
        /// Get/set modifie ou récupère la liste de ellipses.
        /// </summary>
        public List<Ellipse> LstEllipses
        {
            get { return _lstEllipses; }
            set { _lstEllipses = value; }
        }

        /// <summary>
        /// Get/set modifie ou récupère la pile de figures.
        /// </summary>
        public Stack<Figures> PileFigures
        {
            get { return _pileFigures; }
            set { _pileFigures = value; }
        }

        /// <summary>
        /// Get/set modifie ou récupère la pile de figure qui est supprimer.
        /// </summary>
        public Stack<Figures> PileFiguresSupp
        {
            get { return _pileFiguresSupp; }
            set { _pileFiguresSupp = value; }
        }

        #endregion

        #region Événements

        /// <summary>
        /// Évènement quand le bouton couleur est clicker.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCouleur_Click(object sender, EventArgs e)
        {
            DialogResult dr = couleurRemplissage.ShowDialog();
            if (dr == DialogResult.OK)
            {
                btnCouleurRemplissage.BackColor = couleurRemplissage.Color;
            }
        }

        /// <summary>
        /// Évènement quand le bouton couleur bordure est clicker.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCouleurBordure_Click(object sender, EventArgs e)
        {
            DialogResult dr = couleurBordure.ShowDialog();
            if (dr == DialogResult.OK)
            {
                btnCouleurBordure.BackColor = couleurBordure.Color;
            }
        }

        /// <summary>
        /// Évènement quand la souris est appuyer. Cela créé le point de départ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbDessin_MouseDown(object sender, MouseEventArgs e)
        {
            BDessinEnCours = true;
            PntPositionDepart = new Point(e.X, e.Y);
        }

        /// <summary>
        /// Évènement pour dissiner dans le picture box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbDessin_Paint(object sender, PaintEventArgs e)
        {
            foreach (var ligne in LstLignes)
            {
                ligne.Afficher(e.Graphics);
            }

            foreach (var rectangle in LstRectangles)
            {
                rectangle.Afficher(e.Graphics);
            }

            foreach (var ellipse in LstEllipses)
            {
                ellipse.Afficher(e.Graphics);
            }
        }

        /// <summary>
        /// Évènement quand la souris est relaché. Cela créé le point final.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbDessin_MouseUp(object sender, MouseEventArgs e)
        {
            if (BDessinEnCours)
            {

                if (rbLigne.Checked)
                {
                    LstLignes.Add(new Ligne(couleurBordure.Color, _pntPositionDepart, new Point(e.X, e.Y),
                        int.Parse(cmbTrait.Text)));
                    PileFigures.Push(LstLignes[^1]);
                }
                else
                {
                    Point hautGauche = new Point(Math.Min(_pntPositionDepart.X, e.X), Math.Min(_pntPositionDepart.Y, e.Y));
                    Point basDroite = new Point(Math.Max(_pntPositionDepart.X, e.X), Math.Max(_pntPositionDepart.Y, e.Y));
                    if (rbRectangle.Checked)
                    {
                        LstRectangles.Add(new Rectangle(couleurBordure.Color, couleurRemplissage.Color,
                            hautGauche, basDroite, int.Parse(cmbTrait.Text)));
                        PileFigures.Push(LstRectangles[^1]);
                    }

                    else
                    {
                        LstEllipses.Add(new Ellipse(couleurBordure.Color, couleurRemplissage.Color, hautGauche,
                            basDroite, int.Parse(cmbTrait.Text)));
                        PileFigures.Push(LstEllipses[^1]);
                    }
                }

                BDessinEnCours = false;
                pbDessin.Refresh();
            }
        }

        /// <summary>
        /// Évènement lorsque le bouton calculerPeinture est clicker. Fait en sorte de calculer la quantité de peinture.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculerPeinture_Click(object sender, EventArgs e)
        {
            CalculerPeinture calculerPeinture;
            double hauteurReelle;
            double largeurReelle;
            List<(Color, double)> quantitePeinture = new List<(Color, double)>();
            if (this.txtLargeur.Text != null && this.txtHauteur.Text != null && this.txtLargeur.Text != "" && this.txtHauteur.Text != "")
            {
                bool largeurValide = true;
                bool hauteurValide = true;
                foreach (char caractere in this.txtLargeur.Text)
                {
                    if (char.IsNumber(caractere) == false) { largeurValide = false; }
                }
                foreach (char caractere in this.txtHauteur.Text)
                {
                    if (char.IsNumber(caractere) == false) { hauteurValide = false; }
                }
                if (largeurValide == true && hauteurValide == true)
                {
                    hauteurReelle = Convert.ToDouble(this.txtHauteur.Text);
                    largeurReelle = Convert.ToDouble(this.txtLargeur.Text);
                    calculerPeinture = new CalculerPeinture(LstLignes, LstRectangles, LstEllipses, hauteurReelle, largeurReelle);
                    quantitePeinture = calculerPeinture.CalculerQuantitePeinture();
                    AfficherQuantitePeinture(quantitePeinture);
                }
            }
        }

        /// <summary>
        /// Évènement quand l'option Annuler est clicker. Annule le dernier élément qui est déssiner.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuAnnuler_Click(object sender, EventArgs e)
        {
            if (PileFigures != null && PileFigures.Count > 0)
            {
                PileFiguresSupp.Push(PileFigures.Pop());
                MettreAJoursLesListeDeFormes();
                DessinerLesFigures();
            }
        }

        /// <summary>
        /// Évènement quand l'option Repeter est clicker. Répète le dernier élément qui est supprimer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuRepeter_Click(object sender, EventArgs e)
        {
            if (PileFiguresSupp != null && PileFiguresSupp.Count > 0)
            {
                PileFigures.Push(PileFiguresSupp.Pop());

                MettreAJoursLesListeDeFormes();
                DessinerLesFigures();
            }
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Méthode pour afficher la quantité de peinture dans le list box.
        /// </summary>
        /// <param name="pQuantitePeinture">La liste de quantite de peinture.</param>
        private void AfficherQuantitePeinture(List<(Color, double)> pQuantitePeinture)
        {
            this.lstQuantitePeinture.Items.Clear();
            for (int i = 0; i < pQuantitePeinture.Count; i++)
            {
                this.lstQuantitePeinture.Items.Add(string.Format("{0}, {1}", pQuantitePeinture[i].Item1.Name, Math.Round(pQuantitePeinture[i].Item2, 2)));
            }
        }

        /// <summary>
        /// Méthode pour reremplire la pileFigures.
        /// </summary>
        /// <param name="pPileFigures">Prend en paramètre une pile de figures.</param>
        /// <returns>Return un clone de la pile Figures</returns>
        private Stack<Figures> ReRemplirePileFigures(Stack<Figures> pPileFigures)
        {
            Stack<Figures> pileFiguresTempo = new Stack<Figures>();
            for (int i = pPileFigures.Count - 1; i >= 0; i--)
            {
                Figures uneFigures = pPileFigures.Pop();
                PileFigures.Push(uneFigures);
                pileFiguresTempo.Push(uneFigures);
            }
            Stack<Figures> pileFiguresInverser = new Stack<Figures>();
            for (int i = pileFiguresTempo.Count - 1; i >= 0; i--)
            {
                pileFiguresInverser.Push(pileFiguresTempo.Pop());
            }
            return pileFiguresInverser;
        }

        /// <summary>
        /// Méthode, permet de déssiner les figures dans le tableau.
        /// </summary>
        private void DessinerLesFigures()
        {
            Graphics graphics = pbDessin.CreateGraphics();
            foreach (var ligne in LstLignes)
            {
                ligne.Afficher(graphics);
            }

            foreach (var rectangle in LstRectangles)
            {
                rectangle.Afficher(graphics);
            }

            foreach (var ellipse in LstEllipses)
            {
                ellipse.Afficher(graphics);
            }
            pbDessin.Refresh();
        }

        /// <summary>
        /// Permet de mettre a jour les listes des formes.
        /// </summary>
        private void MettreAJoursLesListeDeFormes()
        {
            LstRectangles.Clear();
            LstEllipses.Clear();
            LstLignes.Clear();

            Stack<Figures> pileFiguresTempo = new Stack<Figures>();
            pileFiguresTempo = PileFigures;
            Stack<Figures> pileFiguresTempoInverser = new Stack<Figures>();

            for (int i = PileFigures.Count - 1; i >= 0; i--)
            {
                pileFiguresTempoInverser.Push(pileFiguresTempo.Pop());
            }
            pileFiguresTempoInverser = ReRemplirePileFigures(pileFiguresTempoInverser);
            for (int i = pileFiguresTempoInverser.Count - 1; i >= 0; i--)
            {
                Figures uneFigure = pileFiguresTempoInverser.Pop();
                if (uneFigure is Ligne)
                {
                    LstLignes.Add((Ligne)uneFigure);
                }
                else if (uneFigure is Rectangle)
                {
                    LstRectangles.Add((Rectangle)uneFigure);
                }
                else if (uneFigure is Ellipse)
                {
                    LstEllipses.Add((Ellipse)uneFigure);
                }
            }
        }

        #endregion

    }
}