using eKuharica.Model.DTO;
using eKuharica.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKuharica.WinUI.Articles
{
    public partial class frmAddArticles : Form
    {
        APIService _articleService = new APIService("Article");
        APIService _userService = new APIService("User");
        APIService _articleTranslationService = new APIService("ArticleTranslation");

        private ArticleDto _article;
        private ArticleTranslationDto _articleTranslation;
        private bool _translate;

        public frmAddArticles(ArticleDto article = null, ArticleTranslationDto articleTranslation = null, bool translate = false)
        {
            InitializeComponent();

            _article = article;
            _articleTranslation = articleTranslation;
            _translate = translate;
        }

        private void frmAddArticles_Load(object sender, EventArgs e)
        {
            if (_article != null && !_translate)
            {
                txtTitle.Text = _article.Title;
                txtContent.Text = _article.Content;
                txtKeyWords.Text = _article.KeyWords;
                lblDate.Text = _article.CreatedAt.ToShortDateString();
                pbPicture.Image = Helpers.Helper.ByteArrayToImage(_article.Picture);
            }
            else if (_articleTranslation != null)
            {
                txtTitle.Text = _articleTranslation.Title;
                txtContent.Text = _articleTranslation.Content;
                txtKeyWords.Text = _articleTranslation.KeyWords;
                lblDate.Text = _articleTranslation.CreatedAt.ToShortDateString();
                gbKeyWords.Top = gbKeyWords.Top;
                gbPicture.Hide();
            }
            else
            {
                lblDate.Text = DateTime.Now.ToShortDateString();
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if(string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                errorProvider1.SetError(txtTitle, "Required");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtContent.Text))
            {
                errorProvider1.SetError(txtContent, "Required");
                isValid = false;
            }
            if (!isValid)
                return;
            else
                errorProvider1.Clear();

            var loggedUserId = (await Helpers.Helper.GetLoggedUser(_userService, APIService.Username)).Id; 

            ArticleTranslationUpsertRequest articleTranslationRequest = new ArticleTranslationUpsertRequest();
            ArticleUpsertRequest articleRequest = new ArticleUpsertRequest();

            articleTranslationRequest.Title = articleRequest.Title = txtTitle.Text;
            articleTranslationRequest.ArticleId = _article != null ? _article.Id : 0;
            articleRequest.CreateUserId = loggedUserId;
            articleTranslationRequest.Content = articleRequest.Content = txtContent.Text;
            articleTranslationRequest.KeyWords = articleRequest.KeyWords = txtKeyWords.Text;
            articleTranslationRequest.ModifiedAt = articleRequest.ModifiedAt = DateTime.Now;
            articleRequest.Picture = Helpers.Helper.ImageToByteArray(pbPicture.Image);

            if (_article == null || (_articleTranslation == null && _translate))//add
            {
                articleTranslationRequest.CreatedAt = articleRequest.CreatedAt = DateTime.Now;

                if (_translate)
                {
                    _article.IsTranslated = true;

                    await _articleService.Update<ArticleDto>(_article.Id, _article);
                    await _articleTranslationService.Insert<ArticleTranslationDto>(articleTranslationRequest);
                }
                else
                {
                    await _articleService.Insert<ArticleDto>(articleRequest);
                }
            }
            else //edit
            {
                if (_translate)
                {
                    await _articleTranslationService.Update<ArticleTranslationDto>(_articleTranslation.Id, articleTranslationRequest);
                }
                else
                {
                    await _articleService.Update<ArticleDto>(_article.Id, articleRequest);
                }
            }

            frmArticles frmArticles = new frmArticles();
            frmArticles.MdiParent = MdiParent;
            frmArticles.WindowState = FormWindowState.Maximized;
            frmArticles.Show();
            Hide();
        }

        private void pbPicture_Click(object sender, EventArgs e)
        {
            var result = ofdPicture.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = ofdPicture.FileName;
                var file = File.ReadAllBytes(fileName);

                pbPicture.Image = Image.FromFile(fileName);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var article = new ArticleDto()
            {
                Content = txtContent.Text,
                Title = txtTitle.Text,
                KeyWords = txtKeyWords.Text,
                CreatedAt = DateTime.Now,
                Picture = Helpers.Helper.ImageToByteArray(pbPicture.Image),
                CreatedByUser = APIService.Username
            };

            frmShowArticles frmShowArticle = new frmShowArticles(article);
            frmShowArticle.MdiParent = MdiParent;
            frmShowArticle.WindowState = FormWindowState.Maximized;
            frmShowArticle.Show();
            Hide();
        }

    }
}
