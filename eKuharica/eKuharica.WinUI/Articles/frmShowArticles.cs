using eKuharica.Model.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKuharica.WinUI.Articles
{
    public partial class frmShowArticles : Form
    {
        private ArticleDto _article;
        public frmShowArticles(ArticleDto article)
        {
            InitializeComponent();
            _article = article;
        }

        private void frmShowArticles_Load(object sender, EventArgs e)
        {
            if (_article != null)
            {
                lblTitle.Text = _article.Title;
                lblAuthor.Text = _article.CreatedByUser;
                lblKeyWords.Text = _article.KeyWords;
                lblDate.Text = _article.CreatedAt.ToShortDateString();
                pbPicture.Image = Helpers.Helper.ByteArrayToImage(_article.Picture);
            }
        }
    }
}
