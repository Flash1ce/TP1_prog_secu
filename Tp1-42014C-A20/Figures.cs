using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Tp1_42014C_A20
{
    public abstract class Figures
    {
        #region Attribue

        /// <summary>
        /// Attribue Point représente le point de départ de la figure.
        /// </summary>
        protected Point _pointDepart;
        /// <summary>
        /// Attribue Point représente le point de fin de la figure.
        /// </summary>
        protected Point _pointFin;
        /// <summary>
        /// Attribue int représente la largeur du trait de la figure.
        /// </summary>
        protected int _largeurTrait;

        #endregion

        #region Get/set

        /// <summary>
        /// Get/set permet de modifier ou de récupérer le point de départ de la figures.
        /// </summary>
        public Point PointDepart
        {
            get { return _pointDepart; }
            set { _pointDepart = value; }
        }

        /// <summary>
        /// Get/set permet de modifier ou de récupérer le point de la fin de la figure.
        /// </summary>
        public Point PointFin
        {
            get { return _pointFin; }
            set { _pointFin = value; }
        }

        /// <summary>
        /// Get/set permet de modifier ou de récupérer la largeur du trait de la figure.
        /// </summary>
        public int LargeurTrait
        {
            get { return _largeurTrait; }
            set { _largeurTrait = value; }
        }

        #endregion

    }
}
